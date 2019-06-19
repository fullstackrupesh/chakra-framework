using core.contracts;
using System;

namespace core.model
{
    public class DbModel : IDbModel
    {
        public virtual int Id { get; set; }

        public bool InUse { get; set; }

        public DateTime LastModified { get; set; }

        public virtual int GetId()
        {
            return Id;
        }
    }
}
