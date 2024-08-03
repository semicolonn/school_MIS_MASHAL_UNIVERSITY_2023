<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="schoolmis.Home" %>

<%@ MasterType VirtualPath="~/dashboard.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">

    <h3>Home</h3>
    <hr />

    <div class="col-lg-10" style="align-content: center; text-align: center;">

        <div class="container">
            <div class="row">

                <div class="col-lg-4 gridA dashelement">
                    <a href="Home.aspx" class="fontcol"><i class="fas fa-2x fa-home icons"></i>Home</a>
                </div>


                <div class="col-lg-4 gridA dashelement">
                    <a href="Score.aspx" class="fontcol"><i class="fas fa-2x fa-star-half-alt icons"></i>Score & Marks</a>
                </div>
                <div class="col-lg-4 gridA dashelement">
                    <a href="AttandanceReport.aspx" class="fontcol"><i class="far fa-2x fa-edit icons"></i>Attandance</a>

                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">

                <div class="col-lg-4 gridA dashelement">
                    <a href="Subjects.aspx" class="fontcol"><i class="fas fa-2x fa-book icons"></i>Subject</a>
                </div>
                <div class="col-lg-4 gridA dashelement">
                    <a href="Homework.aspx" class="fontcol"><i class="fas fa-2x fa-book-reader icons"></i>Homework</a>
                </div>


                <div class="col-lg-4 gridA dashelement">
                    <a href="Chapters.aspx" class="fontcol"><i class="fas fa-2x fa-book-open icons"></i>Chapters & Books    </a>
                </div>
                
                <div class="col-lg-12 gridA dashelement">
                    <a href="UserDetails.aspx" class="fontcol"><i class="fas fa-2x fa-user-circle icons"></i>User Details</a>
                </div>

            </div>
        </div>

    </div>


</asp:Content>
