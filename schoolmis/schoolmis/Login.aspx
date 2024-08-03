<%@ Page Title="" Language="C#" MasterPageFile="~/smis.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="schoolmis.Login" %>

<%@ MasterType VirtualPath="~/dashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">

    <!--LINKS -->
    <!-- CSS only -->
    <!--
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous"></script>

    -->


    <!--FONTAWESOME FOR THE ICONS-->
    <!--
    <link href="assets/StyleSheet.css?Version=1" rel="stylesheet" />

    <link href="assets/fontawesome-free-5.15.3-web/css/all.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
        -->

    <style>
        .form-container {
            position: absolute;
            top: 15vh;
            background: #fff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px 0px #000;
        }

        .cust-button {
            margin-top: 10px;
        }
        h2 {
            border-radius:10px;
            background-color: #271c1c;
            font-family: Arial, Helvetica, sans-serif;
            height: 60px;
            padding: 10px 10px 5px;
            margin: 20px 20px;
            color: #ffffff;
            justify-content: center;
        }
    </style>

    <title>Members Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">


       <div class="col-12 justify-content-center">

        <h2 class="heading"><i class="fas fa-sign-in-alt" style="padding: 5px;"></i>Membership Login</h2>

    </div>



    <!--Start of login form coding-->



    <div class="container-fluid">
        <div class="row justify-content-center">
            <div class="col-12 col-sm-6 col-md-3">

                <form runat="server" class="">
                    <div class="form-group">
                        <asp:Label ID="errorMsgLbl" runat="server" Text="errorMsg"></asp:Label>

                    </div>
                    <div class="form-group">
                        <label for="Membername">Member Name</label>
                        <asp:TextBox ID="StudentName" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="password">Password</label>
                        <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                    </div>
                    <div>
                    </div>
                    <!--dropdownlist for the members type-->
                    <div class="form-group">

                        <label for="password">Membership type</label>

                        <asp:DropDownList ID="usertypeddl" runat="server" CssClass="form-control">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Student</asp:ListItem>
                            <asp:ListItem>Teacher</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>

                        </asp:DropDownList>

                    </div>
                    <div class="form-group">
                        <asp:Button ID="loginbtn" runat="server" Text="Login" CssClass="btn btn-primary cust-button" OnClick="loginbtn_Click" Width="111px" />

                    </div>

                </form>



            </div>
        </div>


    </div>


</asp:Content>

