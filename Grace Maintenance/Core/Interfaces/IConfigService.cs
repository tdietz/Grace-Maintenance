using System;
namespace Grace.Core
{
    public interface IConfigService
    {
        string GetFromConfig(string key);
    }
}
