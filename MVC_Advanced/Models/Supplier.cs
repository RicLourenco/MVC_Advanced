using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Advanced.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        
        [Required(ErrorMessage ="Tem de introduzir um {0} para o Fornecedor")]
        [Display(Name="Nome")]
        [StringLength(30,ErrorMessage ="O campo {0} deverá conter entre {2} e {1} carateres", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name="Nome do contacto")]
        [Required(ErrorMessage = "Tem de introduzir um {0} para o Fornecedor")]
        [StringLength(30, ErrorMessage = "O campo {0} deverá conter entre {2} e {1} carateres", MinimumLength = 3)]
        public string ContactFirstName { get; set; }

        [Display(Name = "Apelido do contacto")]
        [Required(ErrorMessage = "Tem de introduzir um {0} para o Fornecedor")]
        [StringLength(30, ErrorMessage = "O campo {0} deverá conter entre {2} e {1} carateres", MinimumLength = 3)]
        public string ContactLastName { get; set; }

        [Display(Name = "Número de contacto")]
        [Required(ErrorMessage = "Tem de introduzir um {0}")]
        [StringLength(15, ErrorMessage = "O campo {0} deverá conter entre {2} e {1} carateres", MinimumLength = 9)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Tem de introduzir um {0}")]
        [Display(Name = "Morada")]
        [StringLength(100, ErrorMessage = "O campo {0} deverá conter entre {2} e {1} carateres", MinimumLength = 3)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}