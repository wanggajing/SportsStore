<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="SportsStore.Pages.Admin.Orders" EnableViewState="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outerContainer">
        <table class="orderTable">
            <tr><th>Name</th><th>City</th><th>Items</th><th>Total</th><th></th></tr>
            <asp:Repeater runat="server" ItemType="SportsStore.Models.Order" SelectMethod="GetOrders">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.Name%></td>
                        <td><%#: Item.City%></td>
                        <td><%# Item.OrderLines.Sum(ol=>ol.Quantity)%></td>
                        <td><%# Total(Item.OrderLines).ToString("C") %></td>
                        <td>
                            <asp:PlaceHolder runat="server" Visible="<%# !Item.Dispatched %>">
                                <button type="submit" name="dispatch" value="<%# Item.OrderId %>">Dispatch</button>
                            </asp:PlaceHolder>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div id="ordersCheck">
        <asp:CheckBox ID="showDispatched" runat="server" Checked="false" AutoPostBack="true" />Show Dispatched Orders?
    </div>
</asp:Content>
