<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="teacherProfile.aspx.cs" Inherits="schoolmis.teacherProfile" %>
<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">

    <div class="container">
        <div class="row">
            <h1>User Profile Details</h1>
            <hr />



            <!--profile details fields-->

            <form runat="server">
                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <label class="form-label" for="nameLbl">Name:</label>
                            <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="fnameLbl">F/Name:</label>
                            <asp:Label ID="fnameLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="lastnameLbl">Last Name:</label>
                            <asp:Label ID="lastnameLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="tazkiraLbl">Tazkira Nr:</label>
                            <asp:Label ID="tazkiraLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="DOBLbl">DOB:</label>
                            <asp:Label ID="DOBLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="ageLbl">Age:</label>
                            <asp:Label ID="ageLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="contactLbl">Contact Nr:</label>
                            <asp:Label ID="contactLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="homeaddLbl">Home address:</label>
                            <asp:Label ID="homeaddLbl" runat="server" Text=""></asp:Label>

                            <br />
                        </div>
                    </div>
                    <div class="col">
                        <p>Photo</p>
                        <asp:Image ID="userImge" runat="server" Height="300px" Width="250px" CssClass="border"/>
                    </div>

                </div>
            </form>


        </div>
    </div>
</asp:Content>
