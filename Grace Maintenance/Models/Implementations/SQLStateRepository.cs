using System;
using System.Linq;

namespace Grace.Models
{
    public class SqlStateRepository : IStateRepository
    {
        private db _db;

        public SqlStateRepository()
        {
            _db = new db();
        }

        public IQueryable<State> FindAllStates()
        {
            return _db.States;
        }

        public State GetState(int id)
        {
            return _db.States.SingleOrDefault(x => x.StateID == id);
        }
    }
}
