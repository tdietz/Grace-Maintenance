using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grace.Core
{
    public interface IGlobalCacheService
    {
        T Get<T>(string key);
        void Set(string key, object objectToSave);
    }
}
