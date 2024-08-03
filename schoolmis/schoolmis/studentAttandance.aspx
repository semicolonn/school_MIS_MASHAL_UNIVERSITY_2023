<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="studentAttandance.aspx.cs" Inherits="schoolmis.studentAttandance" %>
<%@ MasterType VirtualPath="~/teacherDashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Attandance Update</h2>
    <hr />

    <div class="container">
        <div class="row">
            <asp:Label ID="msgLabl" runat="server" Text=""></asp:Label>
            <form id="form1" runat="server">

                <!--dropdownlist for the class names-->
                <div class="form-outline mb-4">
                    <asp:DropDownList ID="classgradeddl" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="showDetails" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Show Attandance Sheet" Height="36px" OnClick="showDetails_Click" />

                    <br />
                    <label class="form-label" for="classgradeddl">Class</label>
                </div>

                <asp:DropDownList ID="DropDownListDay" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="DropDownListMonth" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="DropDownListYear" runat="server"></asp:DropDownList>
                <p>Select Date</p>


                <div class="form-outline mb-4">
                    <asp:GridView ID="dataGrdVw" runat="server" Width="100%">
                        <Columns>
                            <asp:TemplateField HeaderText="Attandance Status">
                                <ItemTemplate>
                                    <asp:CheckBox ID="attandanceStatChk" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <!-- Submit button -->
                <div class="form-outline mb-4">

                    <asp:Button ID="updateAttandanceBtn" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Submit" OnClick="updateAttandanceBtn_Click" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
