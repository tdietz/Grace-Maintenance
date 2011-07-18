<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.Member>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit <%= Model.MemberModel.FullName %></h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Edit</legend>
            
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
                <%= Html.DropDownListFor(model=>model.MemberModel.StateID, new SelectList(Model.States, "StateID", "StateAbbreviation", Model.MemberModel.StateID), "-- Select State --")%> 
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
                <%: Html.EditorFor(model => model.MemberModel.DateJoin)%>
                <%: Html.ValidationMessageFor(model => model.MemberModel.DateJoin) %>
            </div>
            
            <div class="editor-label">
                Join Type
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model=>model.MemberModel.MemberJoinTypeID, new SelectList(Model.MemberJoinTypes, "MemberJoinTypeID", "Description", Model.MemberModel.MemberJoinTypeID), "-- Select Member Join Type --")%> 
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
                <%= Html.DropDownListFor(model=>model.MemberModel.MemberLeaveTypeID, new SelectList(Model.MemberLeaveTypes, "MemberLeaveTypeID", "Description", Model.MemberModel.MemberLeaveTypeID), "-- Select Member Leave Type --")%> 
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
                <input type="submit" value="Save" />
            </p>

            <div>
                <table>
                    <tr>
                        <th colspan="4" style="text-align:center;">
                            <h2>
                                Head of House: <%= Model.HeadOfHousehold %></h2>
                        </th>
                    </tr>
                    <tr>
                        <th>
                        </th>
                        <th>
                            Relation Type
                        </th>
                        <th>
                            First Name
                        </th>
                        <th>
                            Last Name
                        </th>
                    </tr>
                    <% foreach (var memberRelationItem in Model.MemberRelations)
                       { %>
                    <tr>
                        <td>
                            <%: Html.ActionLink("Edit", Grace.Core.Config.ActionVariables.Edit, Grace.Core.Config.ControllerVariables.MemberRelation, new { id = memberRelationItem.RelationshipID }, null)%>
                        </td>
                        <td>
                            <%: memberRelationItem.MemberRelationType.Description%>
                        </td>
                        <td>
                            <%: memberRelationItem.Member1.FirstName%>
                        </td>
                        <td>
                            <%: memberRelationItem.Member1.LastName%>
                        </td>
                    </tr>
                    <% } %>
                </table>
                <%: Html.ActionLink("Add New Member Relation", Grace.Core.Config.ActionVariables.Create, Grace.Core.Config.ControllerVariables.MemberRelation, new { id = Model.HeadMemberID, returnId = Model.MemberModel.MemberID }, null)%>
            </div>
        </fieldset>

    <% } %>

    <% using (Html.BeginForm(Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.Member))
       { %>
        <%=Html.Hidden("id", Model.MemberModel.MemberID) %>
        <input type="submit" value="Delete" />
    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Index)%>
    </div>

</asp:Content>

