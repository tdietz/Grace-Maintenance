using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grace.Models
{
    public partial class Member
    {
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public string FullNameLastFirst
        {
            get
            {
                return this.LastName + ", " + this.FirstName;
            }
        }
    }
}