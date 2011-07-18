using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Models
{
    public interface IStateRepository
    {
        IQueryable<State> FindAllStates();
        State GetState(int id);
    }
}
