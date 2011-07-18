using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class SSClassList
    {
        public SSClassList(IEnumerable<Grace.Models.SSClass> ssClasses)
        {
            SSClassesModel = ssClasses;
        }

        public IEnumerable<Grace.Models.SSClass> SSClassesModel { get; set; } 
    }
}