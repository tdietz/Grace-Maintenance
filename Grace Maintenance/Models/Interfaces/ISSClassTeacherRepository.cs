using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ISSClassTeacherRepository
    {
        void Add(SSClassTeacher ssClassTeacher);
        IQueryable<SSClassTeacher> FindAllSSClassTeachers();
        SSClassTeacher GetSSClassTeacher(int id);
        void Update();
        void Delete(SSClassTeacher ssClassTeacher);
    }
}
