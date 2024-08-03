<%@ Page Title="" Language="C#" MasterPageFile="~/adminDashboard.Master" AutoEventWireup="true" CodeBehind="TeacherRegisteration.aspx.cs" Inherits="schoolmis.TeacherRegisteration" %>
<%@ MasterType VirtualPath="~/adminDashboard.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Register New Teacher</h2>
    <hr />

    <!--Show Success Message is data saved in to database-->


    <div class="container">
        <div class="row">
            <div class="col-8">
                <asp:Label ID="msg" runat="server" Text="" CssClass="SuccessMsg"></asp:Label>

            </div>
        </div>
    </div>
    <br />
    <!--FORM SECTION FOR REGISTERATION-->
    <div class="container">
        <div class="row">
            <form runat="server">
                <asp:ValidationSummary ID="formVldsmmry" runat="server" ForeColor="Red" />

                <!-- 2 column grid layout with text inputs for the first and last names -->
                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="firstnametxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="firstnametxt">First Name</label>
                            <asp:RequiredFieldValidator ID="reqFldstreg"
                                runat="server"
                                ControlToValidate="firstnametxt"
                                ErrorMessage="Enter first name"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:TextBox ID="fnametxt" runat="server" CssClass="form-control"></asp:TextBox>
                            <label class="form-label" for="fnametxt">F/Name</label>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorfname"
                                runat="server"
                                ControlToValidate="fnametxt"
                                ErrorMessage="Enter first father name"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

                        </div>
                    </div>
                </div>

                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="lastNametxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="lastNametxt">Last Name</label>


                    <asp:RequiredFieldValidator ID="ReqfldlastName"
                        runat="server"
                        ControlToValidate="lastNametxt"
                        ErrorMessage="Enter last name"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="passwordtxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="passwordtxt">Password</label>



                    <asp:RequiredFieldValidator ID="Reqfldpassword"
                        runat="server"
                        ControlToValidate="passwordtxt"
                        ErrorMessage="Enter a password"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </div>


                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="tazkiratxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="tazkiratxt">Tazkira ID</label>






                    <asp:RequiredFieldValidator ID="reqfldTazid"
                        runat="server"
                        ControlToValidate="tazkiratxt"
                        ErrorMessage="Enter tazkira ID"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>


                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="dobtxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="dobtxt">Date of Birth</label>


                    <asp:RequiredFieldValidator ID="reqFldDOB"
                        runat="server"
                        ControlToValidate="dobtxt"
                        ErrorMessage="Enter Date of birth"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>


                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="agetxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="agetxt">Age</label>

                    <asp:RequiredFieldValidator ID="ReqFldage"
                        runat="server"
                        ControlToValidate="agetxt"
                        ErrorMessage="Enter age"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>

                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="contactnrtxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <label class="form-label" for="contactnrtxt">Contact Nr</label>
                    <asp:RequiredFieldValidator ID="reqFldcontact"
                        runat="server"
                        ControlToValidate="contactnrtxt"
                        ErrorMessage="Enter contact number"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </div>



                <!-- Text input -->
                <div class="form-outline mb-4">
                    <asp:TextBox ID="addresstxt" runat="server" CssClass="form-control" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
                    <label class="form-label" for="addresstxt">Home Address</label>

                    <asp:RequiredFieldValidator ID="reqFldhomeadd"
                        runat="server"
                        ControlToValidate="addresstxt"
                        ErrorMessage="Enter home address"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>


                <!--Drop Down List-->
                <div class="form-outline mb-4">

                    <asp:DropDownList ID="classGradddl" runat="server" CssClass="btn btn-secondary " Height="52px" Width="395px"></asp:DropDownList><br />
                    <label class="form-label" for="classGradddl">Select Class Grade</label>

                </div>


                <div class="form-outline mb-4">

                    <asp:DropDownList ID="degreeddl" runat="server" CssClass="btn btn-secondary " Height="34px" Width="394px">
                        <asp:ListItem>Bachelor</asp:ListItem>
                        <asp:ListItem>Master</asp:ListItem>
                        <asp:ListItem>Phd</asp:ListItem>
                        <asp:ListItem>Baculuria</asp:ListItem>

                    </asp:DropDownList><br />
                    <label class="form-label" for="degreeddl">Select Degree</label>

                </div>



                <!-- Email input -->
                <div class="form-outline mb-4">
                    <asp:FileUpload ID="fucontrl" runat="server" CssClass="form-control" />
                    <label class="form-label" for="fucontrl">Upload Photo</label>
                </div>

                <!-- Submit button -->
                <asp:Button ID="btnReg" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Register" OnClick="btnReg_Click" />
            </form>

        </div>

    </div>


</asp:Content>
