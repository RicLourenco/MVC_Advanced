namespace MVC_Advanced.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name ="Descrição")]
        [StringLength(30,ErrorMessage ="A {0} deverá ter entre {2} e {1}", MinimumLength = 3)]
        [Required(ErrorMessage ="Deve inserir uma {0}")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Deve inserir um {0}")]
        [Display(Name ="Preço")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Última compra")]
        public DateTime LastPurchase { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Stock { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Observações")]
        public string Remarks { get; set; }
    }
}