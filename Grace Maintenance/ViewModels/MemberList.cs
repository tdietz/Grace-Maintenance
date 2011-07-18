using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class MemberList
    {
        public MemberList(IEnumerable<Grace.Models.Member> members)
        {
            MembersModel = members;
        }

        public IEnumerable<Grace.Models.Member> MembersModel { get; set; } 
        public string LastName { get; set; }
    }
}