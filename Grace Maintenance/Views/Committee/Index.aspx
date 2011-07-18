<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.CommitteeList>" %>
<%@ Import Namespace="Grace.Helpers" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Committee Maintenance</h2>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

    <%= Html.Grid(Model.CommitteesModel) 
    .Columns(column => {
        column.For(a => Html.ActionLink(Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ActionVariables.Edit, new { id = a.CommitteeID })).InsertAt(0).Encode(false);
        column.For(a => a.Name).Sortable(true);
        column.For(a => a.Description).Sortable(false);
        column.For(a => a.DateFormed).Named("Date Formed").Sortable(true);
        column.For(a => a.DateDisbanded).Named("Date Disbanded").Sortable(true);
        column.For(a => a.CommitteeMembers.Count).Named("# of Members").Sortable(false);
    }).Sort((GridSortOptions)ViewData[Grace.Core.Config.ViewDataVariables.Sort])
%>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

