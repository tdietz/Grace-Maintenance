using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class MemberRelation
    {
        public MemberRelation() : this(new Grace.Models.MemberRelation()) 
        {
        }

        public MemberRelation(Grace.Models.MemberRelation memberRelation)
        {
            MemberRelationModel = memberRelation;
        }

        public Grace.Models.MemberRelation MemberRelationModel { get; set; }
        public List<MemberRelationType> MemberRelationTypes { get; set; }
        public IEnumerable<Grace.Models.Member> Members { get; set; }
        public int ReturnId { get; set; }
    }
}