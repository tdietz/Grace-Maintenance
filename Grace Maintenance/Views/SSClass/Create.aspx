<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grace.Models.SSClass>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create New SS Class</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>

            <%= Html.HiddenFor(model => model.ChurchID) %>
            
            <div class="editor-label">
                Short Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ShortDescription) %>
                <%: Html.ValidationMessageFor(model => model.ShortDescription) %>
            </div>
            
            <div class="editor-label">
                Long Description
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LongDescription) %>
                <%: Html.ValidationMessageFor(model => model.LongDescription) %>
            </div>
            
            <div class="editor-label">
                Date Formed
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.DateFormed) %>
                <%: Html.ValidationMessageFor(model => model.DateFormed) %>
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

