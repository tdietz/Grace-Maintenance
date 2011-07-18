using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class SSClass
    {
        public SSClass() : this(new Grace.Models.SSClass()) 
        {
        }

        public SSClass(Grace.Models.SSClass ssClass)
        {
            SSClassModel = ssClass;
            SSClassMembers = ssClass.SSClassMembers.OrderBy(a => a.FullNameLastFirst);
            SSClassTeachers = ssClass.SSClassTeachers.OrderBy(a => a.FullNameLastFirst);
        }

        public string Exception;
        public Grace.Models.SSClass SSClassModel { get; set; } 
        public IEnumerable<Grace.Models.SSClassMember> SSClassMembers { get; set; }
        public IEnumerable<Grace.Models.SSClassTeacher> SSClassTeachers { get; set; }
    }
}