using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CreaciónDeCRUDconCsharpUsandoMVC.Models;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Context
{
    public class DataStore: DbContext//: hereda de la clase
    {
        public DbSet<Product> Products { set; get; }

        public System.Data.Entity.DbSet<CreaciónDeCRUDconCsharpUsandoMVC.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<CreaciónDeCRUDconCsharpUsandoMVC.Models.Orders> Orders { get; set; }

        public System.Data.Entity.DbSet<CreaciónDeCRUDconCsharpUsandoMVC.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<CreaciónDeCRUDconCsharpUsandoMVC.Models.Articulo> Articuloes { get; set; }

    }
    //linea de comando poner Enable-Migrations -ContextTypeName DataStore -EnableAutomaticMigrations
}