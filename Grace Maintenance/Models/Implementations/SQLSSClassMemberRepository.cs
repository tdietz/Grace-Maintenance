using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlSSClassMemberRepository : ISSClassMemberRepository
    {
        private db _db;

        public SqlSSClassMemberRepository()
        {
            _db = new db();
        }

        public void Add(SSClassMember ssClassMember)
        {
            _db.SSClassMembers.InsertOnSubmit(ssClassMember);
            _db.SubmitChanges();
        }

        public IQueryable<SSClassMember> FindAllSSClassMembers()
        {
            return _db.SSClassMembers;
        }

        public SSClassMember GetSSClassMember(int id)
        {
            return _db.SSClassMembers.SingleOrDefault(x => x.SSClassMemberID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(SSClassMember ssClassMember)
        {
            _db.SSClassMembers.DeleteOnSubmit(ssClassMember);
            _db.SubmitChanges();
        }
    }
}
