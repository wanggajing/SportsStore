using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //We have added a new property called Orders to add support for the Products table. We don’t need to add a
//property for the OrderLines table because we won’t be working with it directly. The way that the Entity Framework
//handles foreign key relationships means that OrderLine objects will be handled automatically through the Order
//objects they are associated with.
        public DbSet<Order> Orders { get; set; }
    }
}