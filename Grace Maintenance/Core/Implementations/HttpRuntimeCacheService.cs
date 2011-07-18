using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grace.Core
{
    public class HttpRuntimeCacheService : IGlobalCacheService
    {
        public T Get<T>(string key)
        {
            object value = HttpRuntime.Cache[key];

            return value == null ? default(T) : (T)value;
        }

        public void Set(string key, object objectToSave)
        {
            HttpRuntime.Cache.Insert(key, objectToSave);
        }
    }
}