using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grace.Models;
using System.Web.Mvc;

namespace Grace.Helpers
{
    public static class ViewExtensions
    {
        public static string GetStateAbbreviation(this HtmlHelper helper, State state)
        {
            if (state == null) return string.Empty; else return state.StateAbbreviation;
        }

        public static string GetMemberJoinType(this HtmlHelper helper, MemberJoinType memberJoinType)
        {
            if (memberJoinType == null) return string.Empty; else return memberJoinType.Description;
        }

        public static string GetMemberLeaveType(this HtmlHelper helper, MemberLeaveType memberLeaveType)
        {
            if (memberLeaveType == null) return string.Empty; else return memberLeaveType.Description;
        }
    }
}