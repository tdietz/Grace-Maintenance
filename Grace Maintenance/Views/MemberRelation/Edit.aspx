<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.MemberRelation>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Relationship</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Edit</legend>
            
            <div class="editor-label">
                Relative
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.MemberRelationModel.RelationMemberID, new SelectList(Model.Members, "MemberID", "FullNameLastFirst"), "-- Select Member --")%> 
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
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <% using (Html.BeginForm("delete", "memberRelation")) { %>
        <%=Html.Hidden("id", Model.MemberRelationModel.RelationshipID) %>
        <input type="submit" value="Delete" />
    <% } %>

    <div>
        <%: Html.ActionLink("Back to Member", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.Member, new { id = Model.MemberRelationModel.HeadMemberID }, null)%>
    </div>

</asp:Content>

