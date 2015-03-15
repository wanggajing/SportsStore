using SportsStore.Models;
using SportsStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repo = new Repository();
        private int pageSize = 4;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected IEnumerable<Product> GetProducts()
        {
            //the
//Skip method to ignore the Product objects that occur before our desired page, and the Take method to select the
//quantity of Product objects we show to the user.
            return FilterProducts().OrderBy(p => p.ProductID)
                                .Skip((CurrentPage - 1) * pageSize)
                                .Take(pageSize); 
        }
        protected int CurrentPage
        {
            get
            {
                //int page;
                //page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                int page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }
        protected int MaxPage
        {
            get
            {
                int productCount = FilterProducts().Count();
                return (int)Math.Ceiling((decimal)productCount / pageSize);
            }
        }
        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ?? 
                Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
        private IEnumerable<Product> FilterProducts()
        {
            IEnumerable<Product> products = repo.Products;
            string currentCategory = (string)RouteData.Values["category"] ?? Request.QueryString["category"];
            return currentCategory == null ? products : products.Where(p => p.Category == currentCategory);
        }
    }
}