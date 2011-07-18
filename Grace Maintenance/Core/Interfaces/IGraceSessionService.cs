using System;
using MvcContrib.UI.Grid;

namespace Grace.Core
{
    public interface IGraceSessionService
    {
        GridSortOptions CommitteeSort { get; set; }
        GridSortOptions MemberSort { get; set; }
        GridSortOptions SSClassSort { get; set; }
        string LastName { get; set; }
    }
}
