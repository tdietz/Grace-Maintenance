using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;
using Ninject;

namespace Grace.Core
{
    public class AppLoaderService : IAppLoaderService
    {
        private readonly IStateRepository _stateRepository;
        private readonly IMemberJoinTypeRepository _memberJoinTypeRepository;
        private readonly IMemberLeaveTypeRepository _memberLeaveTypeRepository;
        private readonly IMemberRelationTypeRepository _memberRelationTypeRepository;
        private readonly ISSClassTeacherTypeRepository _ssClassTeacherTypeRepository;
        private readonly ICommitteeRoleRepository _committeeRoleRepository;
        private readonly IGraceGlobalCacheService _graceGlobalCacheService;

        public AppLoaderService(IStateRepository stateRepository, IMemberJoinTypeRepository memberJoinTypeRepository, 
            IMemberLeaveTypeRepository memberLeaveTypeRepository, IMemberRelationTypeRepository memberRelationTypeRepository,
            ISSClassTeacherTypeRepository ssClassTeacherTypeRepository, ICommitteeRoleRepository committeeRoleRepository,
            IGraceGlobalCacheService graceGlobalCacheService)
        {
            _stateRepository = stateRepository;
            _memberJoinTypeRepository = memberJoinTypeRepository;
            _memberLeaveTypeRepository = memberLeaveTypeRepository;
            _memberRelationTypeRepository = memberRelationTypeRepository;
            _ssClassTeacherTypeRepository = ssClassTeacherTypeRepository;
            _committeeRoleRepository = committeeRoleRepository;
            _graceGlobalCacheService = graceGlobalCacheService;
        }

        public void AppStartup()
        {
            _graceGlobalCacheService.States = _stateRepository.FindAllStates().ToList();
            _graceGlobalCacheService.MemberJoinTypes = _memberJoinTypeRepository.FindAllMemberJoinTypes().ToList();
            _graceGlobalCacheService.MemberLeaveTypes = _memberLeaveTypeRepository.FindAllMemberLeaveTypes().ToList();
            _graceGlobalCacheService.MemberRelationTypes = _memberRelationTypeRepository.FindAllMemberRelationTypes().ToList();
            _graceGlobalCacheService.SSClassTeacherTypes = _ssClassTeacherTypeRepository.FindAllSSClassTeacherTypes().ToList();
            _graceGlobalCacheService.CommitteeRoles = _committeeRoleRepository.FindAllCommitteeRoles().ToList();
        }
    }
}