using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class ArticuloOrder: Articulo
    {
        public int quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal partial { get { return Unit_price * quantity; } }
    }
}