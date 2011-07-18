<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.Committee>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit <%= Model.CommitteeModel.Name %></h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>

            <span style="color: Red"><%= Model.Exception %></span>
            
            <div class="editor-label">
                Name
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CommitteeModel.Name)%>
                <%: Html.ValidationMessageFor(model => model.CommitteeModel.Name)%>
            </div>
            
            <div class="editor-label">
                Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CommitteeModel.Description)%>
                <%: Html.ValidationMessageFor(model => model.CommitteeModel.Description)%>
            </div>
            
            <div class="editor-label">
                Date Formed
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CommitteeModel.DateFormed)%>
                <%: Html.ValidationMessageFor(model => model.CommitteeModel.DateFormed)%>
            </div>

            <div class="editor-label">
                Date Formed
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CommitteeModel.DateDisbanded)%>
                <%: Html.ValidationMessageFor(model => model.CommitteeModel.DateDisbanded)%>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>

            <div>
                <table>
                    <tr>
                        <th colspan="4" style="text-align: center;">
                            <h2>
                            Members</h2>
                        </th>
                    </tr>
                    <tr>
                        <th>
                        </th>
                        <th>
                            Name
                        </th>
                    </tr>
                    <% foreach (var committeeMember in Model.CommitteeMembers)
                        { %>
                    <tr>
                        <td>
                            <%: Html.ActionLink("Delete", Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.CommitteeMember, new { id = committeeMember.CommitteeMemberID }, null)%>
                        </td>
                        <td>
                            <%: committeeMember.FullNameLastFirst%>
                        </td>
                    </tr>
                    <% } %>
                </table>
                <%: Html.ActionLink("Add New Member", Grace.Core.Config.ActionVariables.Create, Grace.Core.Config.ControllerVariables.CommitteeMember, new { id = Model.CommitteeModel.CommitteeID }, null)%>
            </div>

        </fieldset>

    <% } %>

    <% using (Html.BeginForm(Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.Committee)) { %>
        <%=Html.Hidden("id", Model.CommitteeModel.CommitteeID) %>
        <input type="submit" value="Delete" />
    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

