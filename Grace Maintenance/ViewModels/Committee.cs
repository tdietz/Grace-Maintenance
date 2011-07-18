using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class Committee
    {
        public Committee() : this(new Grace.Models.Committee()) 
        {
        }

        public Committee(Grace.Models.Committee committee)
        {
            CommitteeModel = committee;
            CommitteeMembers = committee.CommitteeMembers.OrderBy(z=>z.FullNameLastFirst);
        }

        public string Exception;
        public Grace.Models.Committee CommitteeModel { get; set; } 
        public IEnumerable<Grace.Models.CommitteeMember> CommitteeMembers { get; set; }
    }
}