using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlMemberLeaveTypeRepository : IMemberLeaveTypeRepository
    {
        private db _db;

        public SqlMemberLeaveTypeRepository()
        {
            _db = new db();
        }

        public IQueryable<MemberLeaveType> FindAllMemberLeaveTypes()
        {
            return _db.MemberLeaveTypes;
        }

        public MemberLeaveType GetMemberLeaveType(int id)
        {
            return _db.MemberLeaveTypes.SingleOrDefault(x => x.MemberLeaveTypeID == id);
        }
    }
}
