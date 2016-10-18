<%@ Page Title="departments page. Connection with Contoso DB. - IWDD. COMP2084. Week6" Language="C#" MasterPageFile="~/week6.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="Week6.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Departments</h1>


    <a href="department-details.aspx">Add a Department</a>
    <asp:GridView 
        ID="grdDepartments" 
        runat="server" 
        CssClass="table table-striped"
        Autogeneratecolumns="false">
        <Columns>
            <asp:Boundfield DataField="DepartmentID" HeaderText = "ID" />
            <asp:Boundfield DataField="Name" HeaderText = "Department Name" />
            <asp:Boundfield DataField="Budget" HeaderText = "Budget" DataformatString="{0:c}" />
        </Columns>

    </asp:GridView>

</asp:Content>
