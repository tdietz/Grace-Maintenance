using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlSSClassRepository : ISSClassRepository
    {
        private db _db;

        public SqlSSClassRepository()
        {
            _db = new db();
        }

        public void Add(SSClass ssClass)
        {
            _db.SSClasses.InsertOnSubmit(ssClass);
            _db.SubmitChanges();
        }

        public IQueryable<SSClass> FindAllSSClasses()
        {
            return _db.SSClasses;
        }

        public SSClass GetSSClass(int id)
        {
            return _db.SSClasses.SingleOrDefault(x => x.SSClassID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(SSClass ssClass)
        {
            _db.SSClasses.DeleteOnSubmit(ssClass);
            _db.SubmitChanges();
        }
    }
}
