using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlMemberRelationTypeRepository : IMemberRelationTypeRepository
    {
        private db _db;

        public SqlMemberRelationTypeRepository()
        {
            _db = new db();
        }

        public IQueryable<MemberRelationType> FindAllMemberRelationTypes()
        {
            return _db.MemberRelationTypes;
        }

        public MemberRelationType GetMemberRelationType(int id)
        {
            return _db.MemberRelationTypes.SingleOrDefault(x => x.MemberRelationTypeID == id);
        }
    }
}
