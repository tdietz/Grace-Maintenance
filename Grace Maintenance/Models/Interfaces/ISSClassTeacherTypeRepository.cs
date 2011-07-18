using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ISSClassTeacherTypeRepository
    {
        IQueryable<SSClassTeacherType> FindAllSSClassTeacherTypes();
        SSClassTeacherType GetSSClassTeacherType(int id);
    }
}
