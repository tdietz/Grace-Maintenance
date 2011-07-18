using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.ViewModels
{
    public class CommitteeList
    {
        public CommitteeList(IEnumerable<Grace.Models.Committee> committees)
        {
            CommitteesModel = committees;
        }

        public IEnumerable<Grace.Models.Committee> CommitteesModel { get; set; } 
    }
}