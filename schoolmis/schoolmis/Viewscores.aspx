<%@ Page Title="" Language="C#" MasterPageFile="~/adminDashboard.Master" AutoEventWireup="true" CodeBehind="Viewscores.aspx.cs" Inherits="schoolmis.Viewscores" %>
<%@ MasterType VirtualPath="~/adminDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h1>Review Scores</h1>
    <hr />
    <div class="container">
        <div class="row">


            <!-- create outline proress notation-->

            <form runat="server">

                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:DropDownList ID="classDdl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                            </asp:DropDownList>
                            <br />
                            <label class="form-label" for="classDdl">Class Grade</label>
                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:DropDownList ID="subDdl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                            </asp:DropDownList>
                            <br />
                            <label class="form-label" for="subDdl">Subject</label>
                        </div>
                    </div>
                </div>

                <!-- Submit button -->
                <asp:Button ID="btnShowResult" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show Result" OnClick="btnShowResult_Click" />
                <div class="form-outline mb-4">

                    <asp:Label ID="showMsg" runat="server" Text=""></asp:Label>
                </div>
            </form>
            <asp:PlaceHolder ID="PlaceHolder_scoreview" runat="server"></asp:PlaceHolder>

        </div>
    </div>
</asp:Content>

