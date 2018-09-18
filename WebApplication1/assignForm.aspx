<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="assignForm.aspx.cs" Inherits="WebApplication1.assignForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
    <h1>Demo of Linq to sql and DataGrid Control</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
        </Columns> 
 
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyScriptContent" runat="server">
</asp:Content>
