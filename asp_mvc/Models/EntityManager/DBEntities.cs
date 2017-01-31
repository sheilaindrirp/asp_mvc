using System;

namespace asp_mvc_2.Models.EntityManager
{
    internal class DBEntities
    {
        public object SYSUserProfiles { get; internal set; }
        public object SYSUserRoles { get; internal set; }
        public object SYSUsers { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}