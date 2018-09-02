using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class Orders
    {
        [Key]
        public int Id_order { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Order_date { set; get; }

        public int Id_customer { get; set; }

        //muchas ordenes pueden pertenecer a un usuario
        public virtual Customer Customer { get; set; }
         //relacion virtual con customer 
         //una orden puede tener muchos detalles
         public virtual ICollection<OrderDetail> OrderDetails { set; get; } 
    }
}