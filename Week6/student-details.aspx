<%@ Page Title="Student details" Language="C#" MasterPageFile="~/week6.Master" AutoEventWireup="true" CodeBehind="student-details.aspx.cs" Inherits="Week6.student_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student details</h1>

    <!-- 0000000000 Last Name 0000000000 -->
    <div class="form-group">
        <label for="txtLastName" class="col-sm-4 control-label">Last Name: </label>
        <asp:TextBox ID="txtLastName" runat="server" required />
    </div>

    <!-- 0000000000 First and Midle Name 0000000000 -->
    <div class="form-group">
        <label for="txtFirstMidName" class="col-sm-4 control-label">First and Midle Name: </label>
        <asp:TextBox ID="txtFirstMidName" runat="server" required />
    </div>

    <!-- 0000000000 Enrollment Date 0000000000 -->
    <div class="form-group">
        <label for="txtEnrollmentDate" class="col-sm-3 control-label">Enrollment Date: </label>
        <asp:TextBox 
            ID="txtEnrollmentDate" 
            runat="server" 
            Type="date"  
            required />
    </div>
    <asp:Button class="btn btn-success col-sm-offset-3" id="btnSave"  runat="server" text="Save" OnClick="btnSave_Click" />
</asp:Content>
