<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.MemberList>" %>
<%@ Import Namespace="Grace.Helpers" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        var htmlAttributes = new Dictionary<string, object> { { "data-autopostback", "true" } }; 
    %>

    <h2>Member Maintenance</h2>

    <%
        using (Html.BeginForm("Index", "Member", FormMethod.Get, new { id = "memberSearch" }))
        { %>
    <div>
        <label>
            Last Name</label>
        <%:Html.TextBox("LastName", Model.LastName, new { size = 30, maxlength = "40" })%>
        <input type="submit" value="Search" class="btnNeutral" />
    </div>
    <% } %>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

    <%= Html.Grid(Model.MembersModel) 
    .Columns(column => {
        column.For(a => Html.ActionLink("Edit", "Edit", new { id = a.MemberID })).InsertAt(0).Encode(false);
        column.For(a => a.FullNameLastFirst).Named("Name").SortColumnName("LastName").Sortable(true);
        column.For(a => a.Address1 + " " + a.Address2).Named("Address 1").Named("Address").Sortable(false);
        column.For(a => a.City).Sortable(true);
        column.For(a => Html.GetStateAbbreviation(a.State)).Named("State").SortColumnName("StateID").Sortable(true);
        column.For(a => a.HomePhone).Sortable(false);
        column.For(a => a.WorkPhone).Sortable(false);
        column.For(a => a.EMail).Named("Email").Sortable(false);
        column.For(a => Html.GetMemberJoinType(a.MemberJoinType)).Named("Member Join Type").SortColumnName("MemberJoinTypeID").Sortable(true);
        column.For(a => Html.GetMemberLeaveType(a.MemberLeaveType)).Named("Member Leave Type").SortColumnName("MemberLeaveTypeID").Sortable(true);
    }).Sort((GridSortOptions)ViewData[Grace.Core.Config.ViewDataVariables.Sort])
%>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

