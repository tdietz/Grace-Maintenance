using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ICommitteeRepository
    {
        void Add(Committee committee);
        IQueryable<Committee> FindAllCommittees();
        Committee GetCommittee(int id);
        void Update();
        void Delete(Committee committee);
    }
}
