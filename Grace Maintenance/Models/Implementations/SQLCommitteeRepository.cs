using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlCommitteeRepository : ICommitteeRepository
    {
        private db _db;

        public SqlCommitteeRepository()
        {
            _db = new db();
        }

        public void Add(Committee committee)
        {
            _db.Committees.InsertOnSubmit(committee);
            _db.SubmitChanges();
        }

        public IQueryable<Committee> FindAllCommittees()
        {
            return _db.Committees;
        }

        public Committee GetCommittee(int id)
        {
            return _db.Committees.SingleOrDefault(x => x.CommitteeID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(Committee committee)
        {
            _db.Committees.DeleteOnSubmit(committee);
            _db.SubmitChanges();
        }
    }
}
