using System;
namespace Grace.Core
{
    public interface ISessionCacheService
    {
        T Get<T>(string key);
        void Set(string key, object objectToSave);
    }
}
