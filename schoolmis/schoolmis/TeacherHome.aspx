<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="TeacherHome.aspx.cs" Inherits="schoolmis.TeacherHome" %>
<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <div class="container">
        <div class="row">
            <h1>Home</h1>
            <hr />


            <div class="col-lg-10" style="align-content: center; text-align: center;">

                <div class="container">
                    <div class="row">

                        <div class="col-lg-4 gridA dashelement">
                            <a href="TeacherHome.aspx" class="fontcol"><i class="fas fa-2x fa-home icons"></i>Home</a>
                        </div>


                        <div class="col-lg-4 gridA dashelement">
                            <a href="Exam.aspx" class="fontcol"><i class="fas fa-2x fa-edit icons"></i>Create Result</a>
                        </div>
                        <div class="col-lg-4 gridA dashelement">
                            <a href="CreateHomeWork.aspx" class="fontcol"><i class="fas fa-2x fa-edit icons"></i>Create Homework</a>

                        </div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-4 gridB dashelement">
                            <a href="CreateOutlineNote.aspx" class="fontcol"><i class="fas fa-2x fa-edit icons"></i>Create Outline Note</a>

                        </div>
                        <div class="col-lg-4 gridB dashelement">
                            <a href="studentAttandance.aspx" class="fontcol"><i class="fas fa-2x fa-clipboard-check icons"></i>Update Attandance</a>

                        </div>
                        <div class="col-lg-4 gridB dashelement">
                            <a href="vewscore_teacher.aspx" class="fontcol"><i class="fas fa-2x fa-clipboard-check icons"></i>Review Scores</a>

                        </div>
                        <div class="col-lg-12 gridB dashelement">
                            <a href="teacherProfile.aspx" class="fontcol"><i class="fas fa-2x fa-user-circle icons"></i>User Details</a>

                        </div>

                    </div>
            </div>
            <!--
                <div class="container">
                    <div class="col-lg-3 gridA dashelement fontcol">
                        <p class="center"><i class="bi bi-house-door-fill icons"></i>Home</p>

                    </div>
                    <div class="col-lg-3 gridB dashelement fontcol">
                        <p class="center"><i class="bi bi-gear icons"></i>Settings</p>

                    </div>
                    <div class="col-lg-3 gridC dashelement fontcol">
                        <p class="center"><i class="bi bi-chat-fill icons"></i>Chat</p>

                    </div>
                </div>

                <div class="container">
                    <div class="col-lg-3 gridA dashelement fontcol">
                        <p class="center"><i class="bi bi-cloud-download-fill icons"></i>Download</p>

                    </div>
                    <div class="col-lg-3 gridB dashelement fontcol">
                        <p class="center"><i class="bi bi-card-image icons "></i>Photos</p>

                    </div>
                    <div class="col-lg-3 gridC dashelement fontcol">
                        <p class="center"><i class="bi bi-person-circle icons"></i>Account</p>

                    </div>
                </div>
                -->
        </div>



    </div>
    </div>
</asp:Content>
