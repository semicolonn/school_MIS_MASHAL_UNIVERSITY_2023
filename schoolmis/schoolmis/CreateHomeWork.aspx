<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="CreateHomeWork.aspx.cs" Inherits="schoolmis.CreateHomeWork" %>

<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Create Homework</h2>
    <hr />

    <div class="container">
        <div class="row">


            <!-- create exam homework for the students-->

            <form runat="server">

                <!-- validation summery-->


                <asp:ValidationSummary ID="formVldsmmry" runat="server" ForeColor="Red" />

                <div class="form-outline mb-4">

                    <asp:Label ID="showMsg" runat="server" Text=""></asp:Label>
                </div>

                <!-- 2 column grid layout with text inputs for the first and last names -->


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
                            <asp:RequiredFieldValidator ID="reqFldtitleTxt"
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
                            <asp:RequiredFieldValidator ID="reqFldcontext"
                                runat="server"
                                ControlToValidate="contentTxt"
                                ErrorMessage="Enter the content"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>

                    </div>

                </div>
                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="dateTxt" runat="server" CssClass="form-control"></asp:TextBox>

                    <label class="form-label" for="datetxt">Date</label>
                    <asp:RequiredFieldValidator ID="reqFlddate"
                        runat="server"
                        ControlToValidate="dateTxt"
                        ErrorMessage="Enter the date"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>


                <div class="form-outline mb-4">
                    <asp:TextBox ID="deadLinetxt" runat="server" CssClass="form-control"></asp:TextBox>

                    <label class="form-label" for="deadLinetxt">Deadline</label>
                    <asp:RequiredFieldValidator ID="reqFldddline"
                        runat="server"
                        ControlToValidate="deadLinetxt"
                        ErrorMessage="Enter the deadline date"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="row">
                </div>


                <!-- dropdownlist for the teacher name from database -->


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="teachernameddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="teachernameddl">Teacher Name</label>
                </div>


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="classgradeddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="classgradeddl">Class</label>
                </div>

                <!-- Submit button -->
                <asp:Button ID="btnHmework" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Create" OnClick="btnHmework_Click" />

            </form>
        </div>

    </div>
</asp:Content>
