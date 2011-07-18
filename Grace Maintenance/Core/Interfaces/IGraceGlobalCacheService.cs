using System;
using System.Collections.Generic;

namespace Grace.Core
{
    public interface IGraceGlobalCacheService
    {
        List<Grace.Models.CommitteeRole> CommitteeRoles { get; set; }
        List<Grace.Models.MemberJoinType> MemberJoinTypes { get; set; }
        List<Grace.Models.MemberLeaveType> MemberLeaveTypes { get; set; }
        List<Grace.Models.MemberRelationType> MemberRelationTypes { get; set; }
        List<Grace.Models.SSClassTeacherType> SSClassTeacherTypes { get; set; }
        List<Grace.Models.State> States { get; set; }
    }
}
