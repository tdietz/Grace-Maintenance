using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlSSClassTeacherRepository : ISSClassTeacherRepository
    {
        private db _db;

        public SqlSSClassTeacherRepository()
        {
            _db = new db();
        }

        public void Add(SSClassTeacher ssClassTeacher)
        {
            _db.SSClassTeachers.InsertOnSubmit(ssClassTeacher);
            _db.SubmitChanges();
        }

        public IQueryable<SSClassTeacher> FindAllSSClassTeachers()
        {
            return _db.SSClassTeachers;
        }

        public SSClassTeacher GetSSClassTeacher(int id)
        {
            return _db.SSClassTeachers.SingleOrDefault(x => x.SSClassTeacherID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(SSClassTeacher ssClassTeacher)
        {
            _db.SSClassTeachers.DeleteOnSubmit(ssClassTeacher);
            _db.SubmitChanges();
        }
    }
}
