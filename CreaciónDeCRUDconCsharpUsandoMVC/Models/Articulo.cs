using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class Articulo
    {
        [Key]
        public int Id_articulo { set; get; }

        [Display(Name ="Producto")]
        public string Product_name { set; get; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        [Display(Name ="Precio")]
        public decimal Unit_price { set; get; }

        public virtual ICollection<OrderDetail> OrderDetails { set; get; }
    }
}