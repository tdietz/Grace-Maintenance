using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface ISSClassMemberRepository
    {
        void Add(SSClassMember ssClassMember);
        IQueryable<SSClassMember> FindAllSSClassMembers();
        SSClassMember GetSSClassMember(int id);
        void Update();
        void Delete(SSClassMember ssClassMember);
    }
}
