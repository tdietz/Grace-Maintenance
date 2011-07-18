using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;

namespace Grace.Core
{
    public class GraceGlobalCacheService : IGraceGlobalCacheService
    {
        private readonly IGlobalCacheService _globalCacheService;

        public GraceGlobalCacheService(IGlobalCacheService globalCacheService)
        {
            _globalCacheService = globalCacheService;
        }

        public List<State> States
        {
            get
            {
                return _globalCacheService.Get<List<State>>(Grace.Core.Config.CacheVariables.States);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.States, value);
            }
        }

        public List<MemberJoinType> MemberJoinTypes
        {
            get
            {
                return _globalCacheService.Get<List<MemberJoinType>>(Grace.Core.Config.CacheVariables.MemberJoinTypes);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.MemberJoinTypes, value);
            }
        }

        public List<MemberLeaveType> MemberLeaveTypes
        {
            get
            {
                return _globalCacheService.Get<List<MemberLeaveType>>(Grace.Core.Config.CacheVariables.MemberLeaveTypes);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.MemberLeaveTypes, value);
            }
        }

        public List<MemberRelationType> MemberRelationTypes
        {
            get
            {
                return _globalCacheService.Get<List<MemberRelationType>>(Grace.Core.Config.CacheVariables.MemberRelationTypes);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.MemberRelationTypes, value);
            }
        }

        public List<SSClassTeacherType> SSClassTeacherTypes
        {
            get
            {
                return _globalCacheService.Get<List<SSClassTeacherType>>(Grace.Core.Config.CacheVariables.SSClassTeacherTypes);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.SSClassTeacherTypes, value);
            }
        }

        public List<CommitteeRole> CommitteeRoles
        {
            get
            {
                return _globalCacheService.Get<List<CommitteeRole>>(Grace.Core.Config.CacheVariables.CommitteeRoles);
            }
            set
            {
                _globalCacheService.Set(Grace.Core.Config.CacheVariables.CommitteeRoles, value);
            }
        }
    }
}