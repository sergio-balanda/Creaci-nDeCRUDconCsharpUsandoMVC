using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreaciónDeCRUDconCsharpUsandoMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id_customer { get; set; }

        [Display(Name = "Compañia")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CompanyName { get; set; }

        [Display(Name = "Contacto")]
        public string Contact_name { get; set; }

        //un cliente hace varias ordenes
        public virtual ICollection<Orders> Orders { get; set; }
    }
}