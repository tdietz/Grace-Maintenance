using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class SSClassMember
    {

        public SSClassMember() : this(new Grace.Models.SSClassMember()) 
        {
        }

        public SSClassMember(Grace.Models.SSClassMember ssClassMember)
        {
            SSClassMemberModel = ssClassMember;
        }

        public Grace.Models.SSClassMember SSClassMemberModel { get; set; }
        public IEnumerable<Grace.Models.Member> Members { get; set; }
    }
}