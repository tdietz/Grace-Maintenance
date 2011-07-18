<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.SSClassTeacher>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Add Teacher to Sunday School Class
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Teacher to Sunday School Class</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <%: Html.HiddenFor(model => model.SSClassTeacherModel.SSClassID) %>
            
            <div class="editor-label">
                Member
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.SSClassTeacherModel.MemberID, new SelectList(Model.Members, "MemberID", "FullNameLastFirst"), "-- Select Member --")%> 
                <%: Html.ValidationMessageFor(model => model.SSClassTeacherModel.MemberID)%>
            </div>
            
            <div class="editor-label">
                Type of Teacher
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.SSClassTeacherModel.SSClassTeacherTypeID, new SelectList(Model.SSClassTeacherTypes, "SSTeacherTypeID", "Description"), "-- Select Type of Teacher --")%> 
                <%: Html.ValidationMessageFor(model => model.SSClassTeacherModel.SSClassTeacherTypeID) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.SSClass, new { id = Model.SSClassTeacherModel.SSClassID }, null)%>
    </div>

</asp:Content>

