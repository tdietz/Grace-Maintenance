using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;
using Ninject.Modules;

namespace Grace.Core
{
    public class AppLoaderDependencies : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppLoaderService>().To<AppLoaderService>();
            Bind<IStateRepository>().To<SqlStateRepository>(); 
            Bind<IMemberJoinTypeRepository>().To<SqlMemberJoinTypeRepository>();
            Bind<IMemberLeaveTypeRepository>().To<SqlMemberLeaveTypeRepository>();
            Bind<IMemberRelationTypeRepository>().To<SqlMemberRelationTypeRepository>();
            Bind<ISSClassTeacherTypeRepository>().To<SqlSSClassTeacherTypeRepository>();
            Bind<ICommitteeRoleRepository>().To<SqlCommitteeRoleRepository>();
            Bind<IGraceGlobalCacheService>().To<GraceGlobalCacheService>();
            Bind<IGlobalCacheService>().To<HttpRuntimeCacheService>();
        }
    }
}