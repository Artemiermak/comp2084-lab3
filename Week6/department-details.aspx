<%@ Page Title="Details abouy departments" Language="C#" MasterPageFile="~/week6.Master" AutoEventWireup="true" CodeBehind="department-details.aspx.cs" Inherits="Week6.department_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Department details</h1>

    <div class="form-group">
        <label for="txtName" class="col-sm-3 control-label">Name: </label>
        <asp:TextBox ID="txtName" runat="server" required />
    </div>

    <div class="form-group">
        <label for="txtBudget" class="col-sm-3 control-label">Budget: </label>
        <asp:TextBox 
            ID="txtBudget" 
            runat="server" 
            Type="number"  
            required 
            min="0" max="99999999999" 
            step="1"/>
    </div>
    <asp:Button class="btn btn-success col-sm-offset-3" id="btnSave"  runat="server" text="Save" OnClick="btnSave_Click" />
</asp:Content>
