using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlMemberRepository : IMemberRepository
    {
        private db _db;

        public SqlMemberRepository()
        {
            _db = new db();
        }

        public void Add(Member member)
        {
            _db.Members.InsertOnSubmit(member);
            _db.SubmitChanges();
        }

        public IQueryable<Member> FindAllMembers()
        {
            return _db.Members;
        }

        public Member GetMember(int id)
        {
            return _db.Members.SingleOrDefault(x => x.MemberID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(Member member)
        {
            _db.Members.DeleteOnSubmit(member);
            _db.SubmitChanges();
        }
    }
}
