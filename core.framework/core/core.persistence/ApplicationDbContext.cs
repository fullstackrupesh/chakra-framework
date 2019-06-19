using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace core.persistence
{
   public class ApplicationDbContext : DbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
      {

      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {

         var assemblyPaths = AppDomain.CurrentDomain.GetAssemblies()
           .Where(x => !x.IsDynamic)
           .Select(x => x.Location);
         var loadedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
         var unloadedAssemblies = loadedPaths
             .Where(r => !assemblyPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase));
         foreach (var idx in unloadedAssemblies)
         {
            AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(idx));
         }

         foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
         {
            if (!assembly.FullName.Contains("core"))
               continue;

            var types = assembly.GetTypes();

            var nonEmptyTypes = types.Where(t => !string.IsNullOrEmpty(t.Namespace)).ToList();

            var typeFilter = new TypeFilter(InterfaceFilter);

            List<Type> validTypes = new List<Type>();
            

            nonEmptyTypes.ForEach(t =>
            {
               var findInterface = t.FindInterfaces(typeFilter, "Microsoft.EntityFrameworkCore.IEntityTypeConfiguration");
               if (findInterface.Any())
               {
                  validTypes.Add(t);
               }               
            });

            var typesToRegister = assembly.GetTypes()
               .Where(type => !string.IsNullOrEmpty(type.Namespace))
               .Where(type =>
                  type.BaseType != null &&
                  type.BaseType.IsGenericType &&
                  type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));


            foreach (var type in validTypes)
            {
               dynamic configurationInstance = Activator.CreateInstance(type);
               modelBuilder.ApplyConfiguration(configurationInstance);
            }
         }

         base.OnModelCreating(modelBuilder);
      }

      private bool InterfaceFilter(Type typeObj, object filterCriteria)
      {
         return typeObj.ToString().StartsWith(filterCriteria.ToString());
      }
   }
}
