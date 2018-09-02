using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class OrderView
    {
        public CustomerOrder Customer { get; set; }

        public ArticuloOrder Titles { set; get; }

        public List<ArticuloOrder> Articulos { get; set; }

        /*
         *orderview va a permitir guardar datos en orders
         * y ordersdetail, customer pide la orden pero customer no 
         * tiene la fecha de la orden; y articulos no tiene la cantidad y
         * no multiplica cantidad * precio.
         * Por eso herencia
         */
    }
}