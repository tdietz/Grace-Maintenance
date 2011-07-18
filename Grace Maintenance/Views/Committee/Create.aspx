<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.Models.Committee>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create New Committee</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>

            <%= Html.HiddenFor(model => model.ChurchID) %>
            
            <div class="editor-label">
                Name
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name) %>
                <%: Html.ValidationMessageFor(model => model.Name)%>
            </div>
            
            <div class="editor-label">
                Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Description) %>
                <%: Html.ValidationMessageFor(model => model.Description) %>
            </div>
            
            <div class="editor-label">
                Date Formed
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.DateFormed) %>
                <%: Html.ValidationMessageFor(model => model.DateFormed) %>
            </div>

            <div class="editor-label">
                Date Disbanded
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.DateDisbanded)%>
                <%: Html.ValidationMessageFor(model => model.DateDisbanded)%>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", Grace.Core.Config.ActionVariables.Index)%>
    </div>

</asp:Content>

