<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.ViewModels.SSClass>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit <%= Model.SSClassModel.ShortDescription %></h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>

            <span style="color: Red"><%= Model.Exception %></span>
            
            <div class="editor-label">
                Short Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.SSClassModel.ShortDescription)%>
                <%: Html.ValidationMessageFor(model => model.SSClassModel.ShortDescription)%>
            </div>
            
            <div class="editor-label">
                Long Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.SSClassModel.LongDescription)%>
                <%: Html.ValidationMessageFor(model => model.SSClassModel.LongDescription)%>
            </div>
            
            <div class="editor-label">
                Date Formed
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.SSClassModel.DateFormed)%>
                <%: Html.ValidationMessageFor(model => model.SSClassModel.DateFormed)%>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>

            <table style="width:100%">
                <tr style="width:100%">
                    <td style="width:50%">
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
                                <% foreach (var ssClassMember in Model.SSClassMembers)
                                   { %>
                                <tr>
                                    <td>
                                        <%: Html.ActionLink("Delete", Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.SSClassMember, new { id = ssClassMember.SSClassMemberID }, null)%>
                                    </td>
                                    <td>
                                        <%: ssClassMember.FullNameLastFirst %>
                                    </td>
                                </tr>
                                <% } %>
                            </table>
                            <%: Html.ActionLink("Add New Member", Grace.Core.Config.ActionVariables.Create, Grace.Core.Config.ControllerVariables.SSClassMember, new { id = Model.SSClassModel.SSClassID }, null)%>
                        </div>
                    </td>
                    <td style="width:50%">
                        <div>
                            <table>
                                <tr>
                                    <th colspan="4" style="text-align: center;">
                                        <h2>
                                        Teachers
                                    </th>
                                </tr>
                                <tr>
                                    <th>
                                    </th>
                                    <th>
                                        Name
                                    </th>
                                    <th>
                                        Type
                                    </th>
                                </tr>
                                <% foreach (var ssClassTeacher in Model.SSClassTeachers)
                                   { %>
                                <tr>
                                    <td>
                                        <%: Html.ActionLink("Delete", Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.SSClassTeacher, new { id = ssClassTeacher.SSClassTeacherID }, null)%>
                                    </td>
                                    <td>
                                        <%: ssClassTeacher.FullNameLastFirst %>
                                    </td>
                                    <td>
                                        <%: ssClassTeacher.SSClassTeacherType.Description %>
                                    </td>
                                </tr>
                                <% } %>
                            </table>
                            <%: Html.ActionLink("Add New Teacher", Grace.Core.Config.ActionVariables.Create, Grace.Core.Config.ControllerVariables.SSClassTeacher, new { id = Model.SSClassModel.SSClassID }, null)%>
                        </div>
                    </td>
                </tr>
            </table>

        </fieldset>

    <% } %>

    <% using (Html.BeginForm(Grace.Core.Config.ActionVariables.Delete, Grace.Core.Config.ControllerVariables.SSClass)) { %>
        <%=Html.Hidden("id", Model.SSClassModel.SSClassID) %>
        <input type="submit" value="Delete" />
    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

