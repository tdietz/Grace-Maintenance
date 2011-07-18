using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlCommitteeRoleRepository : ICommitteeRoleRepository
    {
        private db _db;

        public SqlCommitteeRoleRepository()
        {
            _db = new db();
        }

        public IQueryable<CommitteeRole> FindAllCommitteeRoles()
        {
            return _db.CommitteeRoles;
        }

        public CommitteeRole GetCommitteeRole(int id)
        {
            return _db.CommitteeRoles.SingleOrDefault(x => x.CommitteeRoleID == id);
        }
    }
}
