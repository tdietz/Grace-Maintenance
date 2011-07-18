using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlMemberRelationRepository : IMemberRelationRepository
    {
        private db _db;

        public SqlMemberRelationRepository()
        {
            _db = new db();
        }

        public void Add(MemberRelation memberRelation)
        {
            _db.MemberRelations.InsertOnSubmit(memberRelation);
            _db.SubmitChanges();
        }

        public IQueryable<MemberRelation> FindAllMemberRelations()
        {
            return _db.MemberRelations;
        }

        public MemberRelation GetMemberRelation(int id)
        {
            return _db.MemberRelations.SingleOrDefault(x => x.RelationshipID == id);
        }

        public void Update()
        {
            _db.SubmitChanges();
        }

        public void Delete(MemberRelation memberRelation)
        {
            _db.MemberRelations.DeleteOnSubmit(memberRelation);
            _db.SubmitChanges();
        }
    }
}
