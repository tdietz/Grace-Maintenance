<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.Member>" %>
<%@ Import Namespace="Grace.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create New Member</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>

            <%= Html.HiddenFor(model => model.MemberModel.ChurchID) %>
            
            <div class="editor-label">
                First Name
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.FirstName) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.FirstName) %>
            </div>
            
            <div class="editor-label">
                Middle Initial
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.MiddleInitial) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.MiddleInitial) %>
            </div>
            
            <div class="editor-label">
                Last Name
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.LastName) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.LastName) %>
            </div>
            
            <div class="editor-label">
                Address 1
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.Address1) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.Address1) %>
            </div>
            
            <div class="editor-label">
                Address 2
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.Address2) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.Address2) %>
            </div>
            
            <div class="editor-label">
                City
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.City) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.City) %>
            </div>
            
            <div class="editor-label">
                State
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.MemberModel.StateID, new SelectList((List<State>)Model.States, "StateID", "StateAbbreviation"), "-- Select State --")%> 
                <%: Html.ValidationMessageFor(model => model.MemberModel.StateID) %>
            </div>
            
            <div class="editor-label">
                Zip Code
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.ZipCode) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.ZipCode) %>
            </div>
            
            <div class="editor-label">
                Home Phone
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.HomePhone) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.HomePhone) %>
            </div>
            
            <div class="editor-label">
                Work Phone
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.WorkPhone) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.WorkPhone) %>
            </div>
            
            <div class="editor-label">
                Email
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.EMail) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.EMail) %>
            </div>
            
            <div class="editor-label">
                Alternate Email
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MemberModel.AlternateEMail) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.AlternateEMail) %>
            </div>
            
            <div class="editor-label">
                Birth Date
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MemberModel.BirthDate) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.BirthDate) %>
            </div>
            
            <div class="editor-label">
                Is Member
            </div>
            <div class="editor-field">
                <%: Html.CheckBoxFor(model => model.MemberModel.Member1) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.Member1) %>
            </div>
            
            <div class="editor-label">
                Date Joined
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MemberModel.DateJoin) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.DateJoin) %>
            </div>
            
            <div class="editor-label">
                Join Type
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model=>model.MemberModel.MemberJoinTypeID, new SelectList((List<MemberJoinType>)Model.MemberJoinTypes, "MemberJoinTypeID", "Description"), "-- Select Member Join Type --")%> 
                <%: Html.ValidationMessageFor(model => model.MemberModel.MemberJoinTypeID) %>
            </div>
            
            <div class="editor-label">
                Date Left
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MemberModel.DateLeave) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.DateLeave) %>
            </div>
            
            <div class="editor-label">
                Leave Type
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.MemberModel.MemberLeaveTypeID, new SelectList((List<MemberLeaveType>)Model.MemberLeaveTypes, "MemberLeaveTypeID", "Description"), "-- Select Member Leave Type --")%> 
                <%: Html.ValidationMessageFor(model => model.MemberModel.MemberLeaveTypeID) %>
            </div>
            
            <div class="editor-label">
                Is Male?
            </div>
            <div class="editor-field">
                <%: Html.CheckBoxFor(model => model.MemberModel.IsMale) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.IsMale) %>
            </div>
            
            <div class="editor-label">
                Salvation Date
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MemberModel.SalvationDate) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.SalvationDate) %>
            </div>
            
            <div class="editor-label">
                Baptism Date
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MemberModel.BaptismDate) %>
                <%: Html.ValidationMessageFor(model => model.MemberModel.BaptismDate) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Index) %>
    </div>

</asp:Content>

