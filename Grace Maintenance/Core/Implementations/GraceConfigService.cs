using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;

namespace Grace.Core
{
    public class GraceConfigService : IGraceConfigService
    {
        private readonly IConfigService _configService;

        public GraceConfigService(IConfigService configService)
        {
            _configService = configService;
        }

        public int ChurchID
        {
            get
            {
                int churchID;
                string churchIDString = _configService.GetFromConfig(Config.AppSettingVariables.ChurchID);
                if (Int32.TryParse(churchIDString, out churchID))
                {
                    return churchID;
                }
                else
                {
                    throw new Exception(churchIDString + " is not a valid integer");
                }
            }
        }
    }
}