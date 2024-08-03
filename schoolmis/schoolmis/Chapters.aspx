<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Chapters.aspx.cs" Inherits="schoolmis.Chapters" %>
<%@ MasterType VirtualPath="~/dashboard.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/StyleSheet.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h2>Chapter and Books</h2>
    <hr />
    <div class="container">
        <div class="row">
            <form runat="server">

                <asp:DropDownList ID="classGrdddl" runat="server" Height="47px" Width="200px" CssClass="btn btn-secondary   "></asp:DropDownList><br />
                Select Class
                <br />
                <asp:Button ID="loadBooksChapters" CssClass="btn btn-primary btn-block mb-8" runat="server" Text="Load Books and Chapters" OnClick="loadBooksChapters_Click" Height="47px" />
                <hr />
                <!--<asp:PlaceHolder ID="bookChapterPlaceHolder" runat="server"></asp:PlaceHolder>-->

                <asp:GridView ID="bookChapterGrdVw" runat="server" Width="100%" DataKeyNames="bookpath" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Download">
                            <ItemTemplate>
                                <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" Text="Download" CssClass="btn btn-primary btn-block mb-8" />
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </form>

        </div>
    </div>
</asp:Content>
