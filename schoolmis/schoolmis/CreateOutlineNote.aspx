<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="CreateOutlineNote.aspx.cs" Inherits="schoolmis.CreateOutlineNote" %>

<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h1>Create Outline Progress Note</h1>
    <hr />
    <div class="container">
        <div class="row">


            <!-- create outline proress notation-->

            <form runat="server">
                <!-- 2 column grid layout with text inputs for the first and last names -->
                <asp:ValidationSummary ID="formVldsmmry" runat="server" ForeColor="Red" />

                <div class="form-outline mb-4">

                    <asp:Label ID="showMsg" runat="server" Text=""></asp:Label>
                </div>
                <!--dropdownlist for the subjects-->


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="subjectddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="subjectnames">Subject</label>

                </div>


                <!-- Text input -->



                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="titletxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="mark">Title</label>
                            <asp:RequiredFieldValidator ID="reqFldttl"
                                runat="server"
                                ControlToValidate="titletxt"
                                ErrorMessage="Enter the title"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="contentTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="studentid">Content</label>
                            <asp:RequiredFieldValidator ID="reqFldcontenttxt"
                                runat="server"
                                ControlToValidate="contentTxt"
                                ErrorMessage="Enter the content text"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="dateTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="datetxt">Date</label>
                    <asp:RequiredFieldValidator ID="reqfldDate"
                        runat="server"
                        ControlToValidate="dateTxt"
                        ErrorMessage="Enter the content date"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </div>

                <!-- dropdownlist -->


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="classgradeddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="classgradeddl">Class</label>
                </div>


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="teachernameddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="teachernameddl">Teacher Name</label>
                </div>

                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="stdNumtxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="stdNumtxt">Student Number</label>
                    <asp:RequiredFieldValidator ID="reqFldstNr"
                        runat="server"
                        ControlToValidate="stdNumtxt"
                        ErrorMessage="Enter student number"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <!-- Submit button -->
                <asp:Button ID="btnCreatOutlineNote" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Create" OnClick="btnCreatOutlineNote_Click" />

            </form>
        </div>

    </div>
</asp:Content>
