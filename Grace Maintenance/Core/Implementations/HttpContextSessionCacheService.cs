using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grace.Core
{
    public class HttpContextSessionCacheService : ISessionCacheService
    {
        public T Get<T>(string key)
        {
            object value = HttpContext.Current.Session[key];

            return value == null ? default(T) : (T)value;
        }

        public void Set(string key, object objectToSave)
        {
            HttpContext.Current.Session[key] = objectToSave;
        }
    }
}