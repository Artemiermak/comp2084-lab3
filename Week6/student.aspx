<%@ Page Title="Students from Contoso Db" Language="C#" MasterPageFile="~/week6.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Week6.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Students</h1>


    <a href="student-details.aspx">Add a Student</a>
    <asp:GridView 
        ID="grdStudents" 
        runat="server" 
        CssClass="table table-striped"
        Autogeneratecolumns="false" 
        DataKeyNames="StudentID" 
        OnRowDeleting="grdStudents_RowDeleting">
        <Columns>
            <asp:Boundfield DataField="LastName" HeaderText = "Last Name" />
            <asp:Boundfield DataField="FirstMidName" HeaderText = "First and Midle Name" />
            <asp:Boundfield DataField="EnrollmentDate" HeaderText = "Enrollment Date" DataformatString="{0:d}" />
            <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/student-details.aspx" DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="~/student-details.aspx?StudentID={0}" />
            <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ControlStyle-CssClass="confirmation" />
        </Columns>
    </asp:GridView>
</asp:Content>
