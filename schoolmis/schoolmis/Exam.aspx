<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="schoolmis.Exam" %>

<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Create Score sheet</h2>
    <hr />
    <div class="container">
        <div class="row">

            <!-- create exam scoring sheet for the students-->

            <form runat="server">
                <asp:ValidationSummary ID="VldSmmry" runat="server" ForeColor="Red" />
                <!-- 2 column grid layout with text inputs for the first and last names -->
                <div class="row mb-4">
                    <!--text fields validators-->


                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="marktxt" runat="server" CssClass="form-control"></asp:TextBox>

                            <label class="form-label" for="mark">Mark</label>
                        </div>
                        <div class="row">
                            <asp:RequiredFieldValidator ID="RequiredFieldmarktxt"
                                runat="server"
                                ControlToValidate="marktxt"
                                ErrorMessage="Enter Marks"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>


                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorTxtbx"
                                runat="server" ErrorMessage="Please type only marks" ControlToValidate="marktxt"
                                ValidationExpression="^[1-9]{0}$" ForeColor="Red">
                            </asp:RegularExpressionValidator>



                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="studentidTxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="studentid">Student ID</label>
                        </div>
                        <div class="row">
                            <asp:RequiredFieldValidator ID="RequiredFieldstudentidTxt"
                                runat="server"
                                ControlToValidate="studentidTxt"
                                ErrorMessage="Enter student ID"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorTxtBxID"
                                runat="server" ErrorMessage="Please type only numeric ID" ControlToValidate="studentidTxt"
                                ValidationExpression="^[1-9]{0}$" ForeColor="Red">
                            </asp:RegularExpressionValidator>
                        </div>

                    </div>
                </div>

                <!-- Text input -->

                <div class="form-outline mb-4">
                    <asp:DropDownList ID="subjectddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList><br />
                    <label class="form-label" for="subjectnames">Subject</label>
                </div>


                <!-- dropdownlist for the teacher name from database -->


                <div class="form-outline mb-4">
                    <asp:DropDownList ID="teachernameddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList><br />
                    <label class="form-label" for="teachernameddl">Teacher Name</label>
                </div>

                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:DropDownList ID="classgradeddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList><br />
                    <label class="form-label" for="classgrade">Class Grade</label>
                </div>

                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:DropDownList ID="examtypeddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                        <asp:ListItem>Mid Term</asp:ListItem>
                        <asp:ListItem>Final</asp:ListItem>
                        <asp:ListItem>Quiz</asp:ListItem>
                    </asp:DropDownList><br />
                    <label class="form-label" for="examtypeddl">Exam Type</label>
                </div>

                <!-- Submit button -->
                <asp:Button ID="btnCreateScore" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Create" OnClick="btnCreateScore_Click" />
                <div class="form-outline mb-4">

                    <asp:Label ID="showMsg" runat="server" Text=""></asp:Label>
                </div>
            </form>
        </div>

    </div>
</asp:Content>
