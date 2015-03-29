using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Pages
{
    public partial class Store : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            adminProducts.HRef = RouteTable.Routes.GetVirtualPath(null, "admin_products", null).VirtualPath;
            adminOrders.HRef = RouteTable.Routes.GetVirtualPath(null, "admin_orders", null).VirtualPath;
        }
    }
}