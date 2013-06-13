<%@ Page Title="" Language="C#" MasterPageFile="~/RoseMaster.master" 
AutoEventWireup="true" CodeFile="FileUpload.aspx.cs" Inherits="FileUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <h2 style="color:Green">Please upload your CV and resume</h2>
    <asp:FileUpload ID="fileupload1" runat="server" />
    <br />
    <br />
    <asp:Button ID="button1" Text="Upload" runat="server" Width="73px" 
        onclick="button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#000099"></asp:Label>
     <br /> <br /> <br />
    <object data = "kkkkk.pdf" type = "application/pdf" width = "600" height = "400" ></object >
</div>
</asp:Content>

