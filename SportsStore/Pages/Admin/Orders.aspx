﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="SportsStore.Pages.Admin.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outerContainer">
        <table class="orderTable">
            <tr><th>Name</th><th>City</th><th>Items</th><th>Total</th><th></th></tr>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="SportsStore.Models.Order" SelectMethod="GetOrders">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.Name%></td>
                        <td><%#:Item.City%></td>
                        <td><%#Item.OrderLines.Sum(ol=>ol.Quantity)%></td>
                        <td></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
