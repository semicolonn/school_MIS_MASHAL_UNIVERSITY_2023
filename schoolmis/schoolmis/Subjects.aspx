<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="schoolmis.Subjects" %>
<%@ MasterType VirtualPath="~/dashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Subjects</h2>
    <hr />
    <div class="container">
        <div class="row">


            <!--Dropdown list for the months list-->
            <form id="frmsub" runat="server">

                <div class="form-outline mb-4">

                    <asp:DropDownList ID="class_ddl" runat="server" CssClass="btn btn-secondary " Height="45px" Width="200px">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>

                    </asp:DropDownList><br />
                    <label class="form-label" for="classGradddl">Select Class Grade</label>

                </div>
                <div class="form-outline mb-4">

                    <!--Display the report for the student attandance sheet-->
                    <asp:Button ID="subjectsBtn" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show Subjects" OnClick="subjectsBtn_Click" />


                </div>

            </form>
            <asp:PlaceHolder ID="PlaceHolder_subject" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>
