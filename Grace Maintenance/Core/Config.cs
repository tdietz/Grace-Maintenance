using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grace.Core
{
    public class Config
    {
        public static class CacheVariables
        {
            public static string States = "States";
            public static string MemberJoinTypes = "MemberJoinTypes";
            public static string MemberLeaveTypes = "MemberLeaveTypes";
            public static string MemberRelationTypes = "MemberRelationTypes";
            public static string SSClassTeacherTypes = "SSClassTeacherTypes";
            public static string CommitteeRoles = "CommitteeRoles";
        }

        public static class SessionVariables
        {
            public static string LastName = "LastName";
            public static string MemberSort = "MemberSort";
            public static string SSClassSort = "SSClassSort";
            public static string CommitteeSort = "CommitteeSort";
        }

        public static class ViewDataVariables
        {
            public static string Members = "Members";
            public static string Sort = "sort";
        }

        public static class AppSettingVariables
        {
            public static string ChurchID = "ChurchID";
        }

        public static class ActionVariables
        {
            public static string Index = "Index";
            public static string Edit = "Edit";
            public static string Delete = "Delete";
            public static string Create = "Create";
        }

        public static class ControllerVariables
        {
            public static string Member = "Member";
            public static string MemberRelation = "MemberRelation";
            public static string SSClassMember = "SSClassMember";
            public static string SSClassTeacher = "SSClassTeacher";
            public static string SSClass = "SSClass";
            public static string Committee = "Committee";
            public static string CommitteeMember = "CommitteeMember";
            public static string WebForms = "WebForms";
        }

        public static class ReportVariables
        {
            public static string Birthdays = "Birthdays.aspx";
            public static string Directory = "Directory.aspx";
            public static string Membership = "Membership.aspx";
            public static string MemberDataDump = "MemberDataDump.aspx";
        }

        public static class NavigationDescriptions
        {
            public static string MemberMaintenance = "Member Maintenance";
            public static string SSClassMaintenance = "SS Class Maintenance";
            public static string CommitteeMaintenance = "Committee Maintenance";
            public static string BirthdaysReport = "Birthdays Report";
            public static string DirectoryReport = "Directory Report";
            public static string MembershipReport = "Membership Report";
            public static string MemberDataDumpReport = "Member Data Dump Report";
        }
    }
}