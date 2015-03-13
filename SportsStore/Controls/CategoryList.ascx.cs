using SportsStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Controls
{
    public partial class CategoryList : System.Web.UI.UserControl
    {
        Repository repo = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateHomeLinkHtml()
        {
            var query = repo.Products;
        }
    }
}