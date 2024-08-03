<%@ Page Title="" Language="C#" MasterPageFile="~/adminDashboard.Master" AutoEventWireup="true" CodeBehind="adminProfile.aspx.cs" Inherits="schoolmis.adminProfile" %>

<%@ MasterType VirtualPath="~/adminDashboard.Master" %>

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
                            <label class="form-label" for="tazkiraLbl">Tazkira Nr:</label>
                            <asp:Label ID="tazkiraLbl" runat="server" Text=""></asp:Label>

                        </div>
                        <div class="form-outline">
                            <label class="form-label" for="emailLbl">Email:</label>
                            <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label>

                        </div>

                        <div class="form-outline">
                            <label class="form-label" for="contactLbl">Contact Nr:</label>
                            <asp:Label ID="contactLbl" runat="server" Text=""></asp:Label>

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
