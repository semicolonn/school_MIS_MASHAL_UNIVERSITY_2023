<%@ Page Title="" Language="C#" MasterPageFile="~/adminDashboard.Master" AutoEventWireup="true" CodeBehind="viewattandance.aspx.cs" Inherits="schoolmis.viewattandance" %>

<%@ MasterType VirtualPath="~/adminDashboard.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Body" runat="server">
    <h1>View Student Attandance</h1>
    <hr />
    <div class="container">
        <div class="row">


            <!-- create outline proress notation-->

            <form runat="server">

                <div class="row mb-4">
                    <div class="col">
                        <div class="form-outline">
                            <asp:dropdownlist id="classDdl" runat="server" cssclass="btn btn-secondary " height="61px" width="222px">
                            </asp:dropdownlist>
                            <br />
                            <label class="form-label" for="classDdl">Class Grade</label>
                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:dropdownlist id="monthDdl" runat="server" cssclass="btn btn-secondary " height="61px" width="222px">
                            </asp:dropdownlist>
                            <br />
                            <label class="form-label" for="monthDdl">Month</label>
                        </div>
                    </div>
                    <div class="col">
                        <div class="form-outline">
                            <asp:dropdownlist id="yearDdl" runat="server" cssclass="btn btn-secondary " height="61px" width="222px">
                            </asp:dropdownlist>
                            <br />
                            <label class="form-label" for="subDdl">Year</label>
                        </div>
                    </div>
                </div>

                <!-- Submit button -->
                <asp:button id="btnShowResult" cssclass="btn btn-primary btn-block mb-8" runat="server" text="Show Result" OnClick="btnShowResult_Click" />
                <div class="form-outline mb-4">
                </div>
            </form>
            <asp:placeholder id="PlaceHolder_attandview" runat="server"></asp:placeholder>

        </div>
    </div>
</asp:Content>
