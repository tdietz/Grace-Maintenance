<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.MemberRelation>" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create New Relationship</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>

            <%= Html.HiddenFor(model => model.MemberRelationModel.HeadMemberID) %>
            
            <div class="editor-label">
                Relative
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.MemberRelationModel.RelationMemberID, new SelectList(Model.Members, "MemberID", "FullName"), "-- Select Member --")%> 
                <%: Html.ValidationMessageFor(model => model.MemberRelationModel.RelationMemberID)%>
            </div>
            
            <div class="editor-label">
                Relationship Type
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.MemberRelationModel.MemberRelationTypeID, new SelectList(Model.MemberRelationTypes, "MemberRelationTypeID", "Description"), "-- Select Member Relation Type --")%> 
                <%: Html.ValidationMessageFor(model => model.MemberRelationModel.MemberRelationTypeID)%>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>

        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.Member, new { id = Model.ReturnId }, null)%>
    </div>

</asp:Content>

