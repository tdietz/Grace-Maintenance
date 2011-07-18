using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IMemberRepository
    {
        void Add(Member member);
        IQueryable<Member> FindAllMembers();
        Member GetMember(int id);
        void Update();
        void Delete(Member member);
    }
}
