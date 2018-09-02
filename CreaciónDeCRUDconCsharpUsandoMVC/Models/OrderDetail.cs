using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id_orderDetail { set; get; }

        public int Id_order { set; get; }

        public int Id_articulo { set; get; }

        [Display(Name ="Cantidad")]
        public int Cantidad { set; get; }

        [Display(Name ="Precio")]
        public decimal Unit_price { set; get; }
        
        public virtual  Orders Orders { set; get; }
        public virtual Articulo Articulos { set; get; }
    }
}