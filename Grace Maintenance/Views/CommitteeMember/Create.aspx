<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.CommitteeMember>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Add Teacher to Sunday School Class
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Teacher to Sunday School Class</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <%: Html.HiddenFor(model => model.CommitteeMemberModel.CommitteeID) %>
            
            <div class="editor-label">
                Member
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.CommitteeMemberModel.MemberID, new SelectList(Model.Members, "MemberID", "FullNameLastFirst"), "-- Select Member --")%> 
                <%: Html.ValidationMessageFor(model => model.CommitteeMemberModel.MemberID)%>
            </div>
            
            <div class="editor-label">
                Type of Teacher
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.CommitteeMemberModel.CommitteeRoleID, new SelectList(Model.CommitteeRoles, "CommitteeRoleID", "Description"), "-- Select Role --")%> 
                <%: Html.ValidationMessageFor(model => model.CommitteeMemberModel.CommitteeRoleID) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.Committee, new { id = Model.CommitteeMemberModel.CommitteeID }, null)%>
    </div>

</asp:Content>

