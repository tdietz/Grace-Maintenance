using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IMemberLeaveTypeRepository
    {
        IQueryable<MemberLeaveType> FindAllMemberLeaveTypes();
        MemberLeaveType GetMemberLeaveType(int id);
    }
}
