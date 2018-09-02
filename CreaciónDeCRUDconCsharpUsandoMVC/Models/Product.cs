using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class Product
    {
        [Key]
        public int codigo { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal precio { get; set; }
        [Display(Name = "Fecha de compra")]
        public DateTime ultima_compra { get; set; }
        [Display(Name = "Cantidad")]
        public int unidades { get; set; }
    }
}