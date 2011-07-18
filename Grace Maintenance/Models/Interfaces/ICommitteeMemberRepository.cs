using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ICommitteeMemberRepository
    {
        void Add(CommitteeMember committeeMember);
        IQueryable<CommitteeMember> FindAllCommitteeMembers();
        CommitteeMember GetCommitteeMember(int id);
        void Update();
        void Delete(CommitteeMember committeeMember);
    }
}
