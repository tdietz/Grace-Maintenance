using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ICommitteeRoleRepository
    {
        IQueryable<CommitteeRole> FindAllCommitteeRoles();
        CommitteeRole GetCommitteeRole(int id);
    }
}
