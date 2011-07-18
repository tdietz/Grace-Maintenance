using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IMemberRelationRepository
    {
        void Add(MemberRelation memberRelation);
        IQueryable<MemberRelation> FindAllMemberRelations();
        MemberRelation GetMemberRelation(int id);
        void Update();
        void Delete(MemberRelation memberRelation);
    }
}
