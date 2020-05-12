using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Advanced.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Tipo documento")]
        public int DocumentTypeID { get; set; }

        [Display(Name = "Documento")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } 
    }
}