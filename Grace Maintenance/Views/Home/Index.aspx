<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Grace.Core" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <ul>
        <li><%: Html.ActionLink(Config.NavigationDescriptions.MemberMaintenance, Config.ActionVariables.Index, Config.ControllerVariables.Member)%></li>
        <li><%: Html.ActionLink(Config.NavigationDescriptions.SSClassMaintenance, Config.ActionVariables.Index, Config.ControllerVariables.SSClass)%></li>
        <li><%: Html.ActionLink(Config.NavigationDescriptions.CommitteeMaintenance, Config.ActionVariables.Index, Config.ControllerVariables.Committee)%></li>
    </ul>
    <ul>
        <li><%=Html.ActionLink(Config.NavigationDescriptions.BirthdaysReport, Config.ReportVariables.Birthdays, Config.ControllerVariables.WebForms) %></li>
        <li><%=Html.ActionLink(Config.NavigationDescriptions.DirectoryReport, Config.ReportVariables.Directory, Config.ControllerVariables.WebForms) %></li>
        <li><%=Html.ActionLink(Config.NavigationDescriptions.MembershipReport, Config.ReportVariables.Membership, Config.ControllerVariables.WebForms) %></li>
        <li><%=Html.ActionLink(Config.NavigationDescriptions.MemberDataDumpReport, Config.ReportVariables.MemberDataDump, Config.ControllerVariables.WebForms) %></li>
    </ul>
</asp:Content>
