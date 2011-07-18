using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class CommitteeMember
    {
        public CommitteeMember() : this(new Grace.Models.CommitteeMember()) 
        {
        }

        public CommitteeMember(Grace.Models.CommitteeMember committeeMember)
        {
            CommitteeMemberModel = committeeMember;
        }

        public Grace.Models.CommitteeMember CommitteeMemberModel { get; set; }
        public List<CommitteeRole> CommitteeRoles { get; set; }
        public IEnumerable<Grace.Models.Member> Members { get; set; }
    }
}