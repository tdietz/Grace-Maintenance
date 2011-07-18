using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ISSClassRepository
    {
        void Add(SSClass ssClass);
        IQueryable<SSClass> FindAllSSClasses();
        SSClass GetSSClass(int id);
        void Update();
        void Delete(SSClass ssClass);
    }
}
