using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Grace.Core
{
    public class ConfigService : IConfigService
    {
        public string GetFromConfig(string key)
        {
            if (ConfigurationManager.AppSettings[key] != null)
            {
                return ConfigurationManager.AppSettings[key];
            }
            else
            {
                throw new Exception(key + " was not found in config file");
            }
        }
    }
}