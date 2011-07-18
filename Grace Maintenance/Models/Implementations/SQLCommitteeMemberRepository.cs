using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlCommitteeMemberRepository : ICommitteeMemberRepository
    {
        private db _db;

        public SqlCommitteeMemberRepository()
        {
            _db = new db();
        }

        public void Add(CommitteeMember committeeMember)
        {
            _db.CommitteeMembers.InsertOnSubmit(committeeMember);
            _db.SubmitChanges();
        }

        public IQueryable<CommitteeMember> FindAllCommitteeMembers()
        {
            return _db.CommitteeMembers;
        }

        public CommitteeMember GetCommitteeMember(int id)
        {
            return _db.CommitteeMembers.SingleOrDefault(x => x.CommitteeMemberID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(CommitteeMember committeeMember)
        {
            _db.CommitteeMembers.DeleteOnSubmit(committeeMember);
            _db.SubmitChanges();
        }
    }
}
