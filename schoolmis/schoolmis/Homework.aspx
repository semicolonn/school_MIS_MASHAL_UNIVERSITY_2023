<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Homework.aspx.cs" Inherits="schoolmis.Homework" %>

<%@ MasterType VirtualPath="~/dashboard.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h3>Homework</h3>
    <hr />
    <form runat="server">
        <!--Drop Down List-->
        <div class="form-outline mb-4">

            <asp:DropDownList ID="classGradddl" runat="server" CssClass="btn btn-secondary " Height="45px" Width="200px"></asp:DropDownList>
            <br />
            <label class="form-label" for="classGradddl">Select Class Grade</label>

        </div>
        <div class="form-outline mb-4">

            <!--Display the report for the student attandance sheet-->
            <asp:Button ID="btnResult" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show Result" OnClick="btnResult_Click" />


        </div>
    </form>

    <asp:PlaceHolder ID="homeworkPholder" runat="server"></asp:PlaceHolder>

</asp:Content>
