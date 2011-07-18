using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IMemberJoinTypeRepository
    {
        IQueryable<MemberJoinType> FindAllMemberJoinTypes();
        MemberJoinType GetMemberJoinType(int id);
    }
}
