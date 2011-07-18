<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.SSClassMember>" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Add Member to Sunday School Class
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Member to Sunday School Class</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <%: Html.HiddenFor(model => model.SSClassMemberModel.SSClassID) %>
            
            <div class="editor-label">
                Member
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.SSClassMemberModel.MemberID, new SelectList(Model.Members, "MemberID", "FullNameLastFirst"), "-- Select Member --")%> 
                <%: Html.ValidationMessageFor(model => model.SSClassMemberModel.MemberID) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>

            
    </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.SSClass, new { id = Model.SSClassMemberModel.SSClassID }, null)%>
    </div>

</asp:Content>

