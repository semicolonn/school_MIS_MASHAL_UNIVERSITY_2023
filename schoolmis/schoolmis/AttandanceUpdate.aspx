<%@ Page Title="" Language="C#" MasterPageFile="~/teacherDashboard.Master" AutoEventWireup="true" CodeBehind="AttandanceUpdate.aspx.cs" Inherits="schoolmis.AttandanceUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Attandance Update</h2>
    <hr />

    <div class="container">
        <div class="row">
            <form id="form1" runat="server">

                <!--dropdownlist for the class names-->
                <div class="form-outline mb-4">
                    <asp:DropDownList ID="classgradeddl" runat="server" CssClass="btn btn-secondary " Height="61px" Width="222px">
                    </asp:DropDownList>
                    <br />
                    <label class="form-label" for="classgradeddl">Class</label>
                </div>
                <div class="form-outline mb-4">

                    <asp:GridView runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSourceSchoolMIS" ForeColor="Black" GridLines="Vertical" Width="792px">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                            <asp:BoundField DataField="fname" HeaderText="F/Name" SortExpression="fname" />
                            <asp:BoundField DataField="classgradeId_fk" HeaderText="Class" SortExpression="classgradeId_fk" />

                            <asp:TemplateField HeaderText="Present">
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox_prAbstatus" runat="server" />
                                </ItemTemplate>
                                <FooterStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSourceSchoolMIS" runat="server" ConnectionString="<%$ ConnectionStrings:schoolmisConnectionString %>" SelectCommand="SELECT [id], [name], [fname],[classgradeId_fk] FROM [student]"></asp:SqlDataSource>

                </div>
                <!-- Submit button -->
                <div class="form-outline mb-4">

                    <asp:Button ID="updateAttandanceBtn" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Submit" />
                </div>
            </form>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
