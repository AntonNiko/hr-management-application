<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageItem.aspx.cs" Inherits="hr_management_application.Admin.ManageItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:100px;">
        <style>
        .dataentry input{
        width: 250px;
        margin-left: 20px;
        margin-top: 15px;
        }
        .dataentry textarea{
        width: 250px;
        margin-left: 20px;
        margin-top: 15px;
        }
        .dataentry label{
        width: 75px;
        margin-left: 20px;
        margin-top: 15px;
        }
        </style>
        <div class="dataentry">
            <asp:Label runat="server" Text="Description" AssociatedControlID="tbDescription"></asp:Label>
            <asp:TextBox runat="server" ID="tbDescription" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="dataentry">
            <asp:Label runat="server" Text="Cost" AssociatedControlID="tbCost"></asp:Label>
            <asp:TextBox runat="server" ID="tbCost"></asp:TextBox>
        </div>
        <div class="dataentry">
        <asp:Label runat="server" Text="Acquired Date"
        AssociatedControlID="tbAcquiredDate" />
        <asp:TextBox runat="server" ID="tbAcquiredDate" />
        </div>
        <asp:Button Text="Save Item" runat="server" OnClick="SaveItem_Clicked" />
    </div>
</asp:Content>
