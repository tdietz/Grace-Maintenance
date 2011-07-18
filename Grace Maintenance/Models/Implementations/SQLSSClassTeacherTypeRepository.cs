using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlSSClassTeacherTypeRepository : ISSClassTeacherTypeRepository
    {
        private db _db;

        public SqlSSClassTeacherTypeRepository()
        {
            _db = new db();
        }

        public IQueryable<SSClassTeacherType> FindAllSSClassTeacherTypes()
        {
            return _db.SSClassTeacherTypes;
        }

        public SSClassTeacherType GetSSClassTeacherType(int id)
        {
            return _db.SSClassTeacherTypes.SingleOrDefault(x => x.SSTeacherTypeID == id);
        }
    }
}
