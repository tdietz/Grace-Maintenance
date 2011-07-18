using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcContrib.UI.Grid;

namespace Grace.Core
{
    public class GraceSessionService : IGraceSessionService
    {
        private readonly ISessionCacheService _sessionCacheService;

        public GraceSessionService(ISessionCacheService sessionCacheService)
        {
            _sessionCacheService = sessionCacheService;
        }

        public GridSortOptions CommitteeSort
        {
            get
            {
                return _sessionCacheService.Get<GridSortOptions>(Grace.Core.Config.SessionVariables.CommitteeSort);
            }
            set
            {
                _sessionCacheService.Set(Grace.Core.Config.SessionVariables.CommitteeSort, value);
            }
        }

        public GridSortOptions MemberSort
        {
            get
            {
                return _sessionCacheService.Get<GridSortOptions>(Grace.Core.Config.SessionVariables.MemberSort);
            }
            set
            {
                _sessionCacheService.Set(Grace.Core.Config.SessionVariables.MemberSort, value);
            }
        }

        public GridSortOptions SSClassSort
        {
            get
            {
                return _sessionCacheService.Get<GridSortOptions>(Grace.Core.Config.SessionVariables.SSClassSort);
            }
            set
            {
                _sessionCacheService.Set(Grace.Core.Config.SessionVariables.SSClassSort, value);
            }
        }

        public string LastName
        {
            get
            {
                return _sessionCacheService.Get<string>(Grace.Core.Config.SessionVariables.LastName);
            }
            set
            {
                _sessionCacheService.Set(Grace.Core.Config.SessionVariables.LastName, value);
            }
        }
    }
}