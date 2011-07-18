using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlMemberJoinTypeRepository : IMemberJoinTypeRepository
    {
        private db _db;

        public SqlMemberJoinTypeRepository()
        {
            _db = new db();
        }

        public IQueryable<MemberJoinType> FindAllMemberJoinTypes()
        {
            return _db.MemberJoinTypes;
        }

        public MemberJoinType GetMemberJoinType(int id)
        {
            return _db.MemberJoinTypes.SingleOrDefault(x => x.MemberJoinTypeID == id);
        }
    }
}
