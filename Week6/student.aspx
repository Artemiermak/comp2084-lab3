﻿<%@ Page Title="Students from Contoso Db" Language="C#" MasterPageFile="~/week6.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Week6.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Students</h1>


    <a href="student-details.aspx">Add a Student</a>
    <asp:GridView 
        ID="grdStudents" 
        runat="server" 
        CssClass="table table-striped"
        Autogeneratecolumns="false">
        <Columns>
            <asp:Boundfield DataField="LastName" HeaderText = "Last Name" />
            <asp:Boundfield DataField="FirstMidName" HeaderText = "First and Midle Name" />
            <asp:Boundfield DataField="EnrollmentDate" HeaderText = "Enrollment Date" DataformatString="{0:d}" />
        </Columns>
    </asp:GridView>
</asp:Content>
