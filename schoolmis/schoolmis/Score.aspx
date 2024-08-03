<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Score.aspx.cs" Inherits="schoolmis.Score" %>

<%@ MasterType VirtualPath="~/dashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">

    <h2>Scores Result</h2>
    <hr />
    <div class="container">
        <div class="row">

            <form runat="server">
                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:DropDownList ID="examDdl" runat="server" Height="45px" Width="193px" class="btn btn-secondary ">
                                <asp:ListItem>mid-term</asp:ListItem>
                                <asp:ListItem>final</asp:ListItem>
                                <asp:ListItem>quiz</asp:ListItem>
                            </asp:DropDownList><br />
                            <label class="form-label" for="examDdl">Search Attandance Result by Name</label>
                            <br />
                            <!-- Submit button -->
                            <asp:Button ID="btnShowExamResult" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show" OnClick="btnShowExamResult_Click" />
                        </div>
                    </div>
                </div>
            </form>

            <!--Load HTML table from database for student score details-->
            <asp:PlaceHolder ID="htmlTablePlaceHolder" runat="server"></asp:PlaceHolder>
        </div>

    </div>

</asp:Content>
