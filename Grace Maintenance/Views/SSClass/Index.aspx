<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.SSClassList>" %>
<%@ Import Namespace="Grace.Helpers" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>SS Class Maintenance</h2>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

    <%= Html.Grid(Model.SSClassesModel) 
    .Columns(column => {
        column.For(a => Html.ActionLink(Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ActionVariables.Edit, new { id = a.SSClassID })).InsertAt(0).Encode(false);
        column.For(a => a.ShortDescription).Named("Short Description").Sortable(true);
        column.For(a => a.LongDescription).Named("Long Description").Sortable(true);
        column.For(a => a.DateFormed).Named("Date Formed").Sortable(true);
        column.For(a => a.SSClassMembers.Count).Named("# of Members").Sortable(false);
    }).Sort((GridSortOptions)ViewData[Grace.Core.Config.ViewDataVariables.Sort])
%>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

