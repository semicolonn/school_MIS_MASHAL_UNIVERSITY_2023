<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="AttandanceReport.aspx.cs" Inherits="schoolmis.AttandanceReport" %>

<%@ MasterType VirtualPath="~/dashboard.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Student Attandance Report</h2>
    <hr />
    <div class="container">
        <div class="row">
            <form runat="server">

                <!--two colums in single row-->

                <asp:ValidationSummary ID="ValidationSmmry" runat="server" ForeColor="Red" />
                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="studentIdTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="studentNameTxt">Student ID</label>
                            <div class="row">

                                <asp:RequiredFieldValidator ID="reqFldIdTxt"
                                    runat="server"
                                    ControlToValidate="studentIdTxt"
                                    ErrorMessage="Enter your ID"
                                    ForeColor="Red">
                                </asp:RequiredFieldValidator>
   
                            </div>

                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="studentNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="studentNameTxt">Student Name</label>
                            <asp:RequiredFieldValidator ID="reqStuTxt"
                                runat="server"
                                ControlToValidate="studentNameTxt"
                                ErrorMessage="Enter your name"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <!-- Submit button -->

                <div class="row mb-4">

                    <div class="form-outline">
                        <asp:Button ID="btnShowResultAttandance" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show" OnClick="btnShowResultAttandance_Click" />

                    </div>
                </div>

                <div class="border">
                    <div class="row">
                        <asp:Label ID="getPresentDaysRp" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Label ID="getAbsDays" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Label ID="getSickDays" runat="server" Text=""></asp:Label>
                    </div>
                </div>

            </form>

        </div>

        <!--placeholder for student-->
        <asp:PlaceHolder ID="placeholder_studentAttandce" runat="server"></asp:PlaceHolder>

    </div>

</asp:Content>
