<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="schoolmis.Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <div class="container">

        <br />
        <br />
        <br />
        <h1>Schedule:</h1>
        <hr />

        <asp:PlaceHolder ID="scheduleTablesph" runat="server"></asp:PlaceHolder>


    </div>
</asp:Content>
