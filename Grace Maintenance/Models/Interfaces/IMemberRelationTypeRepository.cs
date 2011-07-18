using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IMemberRelationTypeRepository
    {
        IQueryable<MemberRelationType> FindAllMemberRelationTypes();
        MemberRelationType GetMemberRelationType(int id);
    }
}
