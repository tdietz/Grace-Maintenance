using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class SSClassTeacher
    {
        public SSClassTeacher() : this(new Grace.Models.SSClassTeacher()) 
        {
        }

        public SSClassTeacher(Grace.Models.SSClassTeacher ssClassTeacher)
        {
            SSClassTeacherModel = ssClassTeacher;
        }

        public Grace.Models.SSClassTeacher SSClassTeacherModel { get; set; }
        public List<SSClassTeacherType> SSClassTeacherTypes { get; set; }
        public IEnumerable<Grace.Models.Member> Members { get; set; }
    }
}