using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Grace.Core;
using Grace.Models;
using Ninject;
using Ninject.Modules;

namespace Grace
{
    internal class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel = new StandardKernel(new GraceDependencies());

        protected override IController GetControllerInstance(RequestContext requestContext,
                                                             Type controllerType)
        {
            return controllerType != null ? (IController)kernel.Get(controllerType)
                                          : null;
        }

        private class GraceDependencies : NinjectModule
        {
            public override void Load()
            {
                Bind<IFormsAuthenticationService>().To<FormsAuthenticationService>();
                Bind<IMembershipService>().To<AccountMembershipService>();
                
                Bind<IConfigService>().To<ConfigService>();
                Bind<ISessionCacheService>().To<HttpContextSessionCacheService>();
                Bind<IGlobalCacheService>().To<HttpRuntimeCacheService>();

                Bind<IGraceConfigService>().To<GraceConfigService>();
                Bind<IGraceSessionService>().To<GraceSessionService>();
                Bind<IGraceGlobalCacheService>().To<GraceGlobalCacheService>();

                Bind<ISSClassRepository>().To<SqlSSClassRepository>();
                Bind<IMemberRepository>().To<SqlMemberRepository>();
                Bind<ICommitteeRepository>().To<SqlCommitteeRepository>();
                Bind<IMemberRelationRepository>().To<SqlMemberRelationRepository>();

                Bind<IStateRepository>().To<SqlStateRepository>();
                Bind<IMemberJoinTypeRepository>().To<SqlMemberJoinTypeRepository>();
                Bind<IMemberLeaveTypeRepository>().To<SqlMemberLeaveTypeRepository>();
                Bind<IMemberRelationTypeRepository>().To<SqlMemberRelationTypeRepository>();
                Bind<ISSClassTeacherTypeRepository>().To<SqlSSClassTeacherTypeRepository>();
                Bind<ISSClassMemberRepository>().To<SqlSSClassMemberRepository>();
                Bind<ISSClassTeacherRepository>().To<SqlSSClassTeacherRepository>();
                Bind<ICommitteeMemberRepository>().To<SqlCommitteeMemberRepository>();
                Bind<ICommitteeRoleRepository>().To<ICommitteeRoleRepository>();
            }
        }
    }
}