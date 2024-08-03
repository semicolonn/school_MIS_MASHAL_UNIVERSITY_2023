<%@ Page Title="" Language="C#" MasterPageFile="~/adminDashboard.Master" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="schoolmis.adminHome" %>
<%@ MasterType VirtualPath="~/adminDashboard.Master" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Home</h2>
    <hr />
        <div class="col-lg-10" style="align-content: center; text-align: center;">

            <div class="container">
                <div class="row">

                    <div class="col-lg-4 gridA dashelement">
                        <a href="adminHome.aspx" class="fontcol"><i class="fas fa-2x fa-home icons"></i>Home</a>
                    </div>


                    <div class="col-lg-4 gridA dashelement">
                        <a href="StudentRegisteration.aspx" class="fontcol"><i class="fas fa-2x fa-plus-circle icons"></i>Add New Student</a>
                    </div>
                    <div class="col-lg-4 gridA dashelement">
                        <a href="TeacherRegisteration.aspx" class="fontcol"><i class="fas fa-2x fa-plus-circle icons"></i>Add New Teacher</a>

                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">

                    <div class="col-lg-4 gridA dashelement">
                        <a href="Viewscores.aspx" class="fontcol"><i class="fas fa-2x fa-eye icons"></i>View Scores</a>
                    </div>
                    <div class="col-lg-4 gridA dashelement">
                        <a href="viewattandance.aspx" class="fontcol"><i class="fas fa-2x fa-eye icons"></i>View Attandance</a>
                    </div>
                    
                <div class="col-lg-4 gridA dashelement">
                    <a href="adminProfile.aspx" class="fontcol"><i class="fas fa-2x fa-user-circle icons"></i>User Details </a>
                </div>

                </div>
            </div>

        </div>
</asp:Content>
