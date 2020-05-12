using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Advanced.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(30, ErrorMessage = "A {0} deverá ter entre {2} e {1}", MinimumLength = 3)]
        [Required(ErrorMessage = "Tem de inserir o {0}")]
        [Display(Name = "Primeiro nome")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "A {0} deverá ter entre {2} e {1}", MinimumLength = 3)]
        [Required(ErrorMessage = "Tem de inserir o {0}")]
        [Display(Name = "Apelido")]
        public string LastName { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "Tem de inserir um valor para o {0}")]
        public decimal Salary { get; set; }

        [Range(0,20,ErrorMessage ="O valor da {0} deverá ser entre {1} e {2}")]
        [Display(Name = "Percentagem de bónus")]
        public float BonusPercent { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Tem de inserir uma {0}")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de início")]
        [Required(ErrorMessage = "Tem de inserir uma {0}")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string URL { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "Tem de inserir um {0}")]
        public int DocumentTypeID { get; set; }

        [Display(Name = "Idade")]
        [NotMapped]
        public int Age
        {
            get
            {
                if(DateTime.Now.DayOfYear > BirthDate.DayOfYear)
                {
                    return DateTime.Now.Year - BirthDate.Year;
                }
                else
                {
                    return DateTime.Now.Year - BirthDate.Year - 1;
                }
                
            }
        }

        public virtual DocumentType DocumentType { get; set; }

    }
}