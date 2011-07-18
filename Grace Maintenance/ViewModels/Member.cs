using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class Member
    {
        public Member() : this(new Grace.Models.Member()) 
        {
        }

        public Member(Grace.Models.Member member)
        {
            MemberModel = member;

            if (member.MemberID != 0)
            {
                if (member.MemberRelations.Count > 0)
                {
                    HeadOfHousehold = "Self";
                    HeadMemberID = member.MemberID;
                    MemberRelations = member.MemberRelations.ToList();
                }
                else
                {
                    if (member.MemberRelations1.Count > 0)
                    {
                        HeadOfHousehold = member.MemberRelations1[0].Member.FullName;
                        HeadMemberID = member.MemberRelations1[0].HeadMemberID;
                        MemberRelations = member.MemberRelations1[0].Member.MemberRelations.ToList();
                    }
                    else
                    {
                        HeadOfHousehold = "Self";
                        HeadMemberID = member.MemberID;
                        MemberRelations = member.MemberRelations1.ToList();
                    }
                }
            }
        }

        public Grace.Models.Member MemberModel { get; set; } 
        public List<State> States { get; set; }
        public List<MemberJoinType> MemberJoinTypes { get; set; }
        public List<MemberLeaveType> MemberLeaveTypes { get; set; }
        public List<Grace.Models.MemberRelation> MemberRelations { get; set; }
        public string HeadOfHousehold { get; set; }
        public int HeadMemberID { get; set; }
    }
}