using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grace.Models
{
    public partial class SSClassMember
    {
        public string FullNameLastFirst
        {
            get
            {
                return this.Member.FullNameLastFirst;
            }
        }
    }
}