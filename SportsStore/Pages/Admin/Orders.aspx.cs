using SportsStore.Models;
using SportsStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Pages.Admin
{
    public partial class Orders : System.Web.UI.Page
    {
        private Repository repo = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int dispatchID;
                if (int.TryParse(Request["dispatch"],out dispatchID))
                {
                    Order myOrder = repo.Orders.Where(o => o.OrderId == dispatchID).FirstOrDefault();
                    if (myOrder != null)
                    {
                        myOrder.Dispatched = true;
                        repo.SaveOrder(myOrder);
                    }
                }
            }
        }
        public decimal Total(IEnumerable<OrderLine> orderlines)
        {
            decimal total = 0;
            foreach (OrderLine ol in orderlines)
            {
                total += ol.Product.Price * ol.Quantity;
            }
            return total;
        }
        //It is very important to use the full name System.Web.ModelBinding.Control, otherwise it will be recognized as System.Web.UI.Control
        //This allow GetOrders method to obtain parameters from a Control in webform, in this case a checkbox.
        public IEnumerable<Order> GetOrders([System.Web.ModelBinding.Control] bool showDispatched)
        {
            if (showDispatched)
            {
                return repo.Orders;
            }
            else
            {
                return repo.Orders.Where(o => !o.Dispatched);
            }
        }
    }
}