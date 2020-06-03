using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mawjoud2.Models
{
    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Le nom du produit est obligatoire !")]
        [StringLength(100, ErrorMessage = "la longueur du nom du produit doit être comprise entre 3 et 100 caractères")]
        public string ProductName { get; set; }
        public string ProductPlace { get; set; }
        public string Description { get; set; }
        [Required]
        public string ProductImage { get; set; }
        public Nullable<bool> IsActive { get; set; }
       
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        public Nullable<int> CategoryId { get; set; }
        [Required(ErrorMessage ="Le prix est obligatoire !")]
        [Range(typeof(int),"1","2000000000",ErrorMessage ="Le prix est invalide!")]
        public int Price { get; set; }
        public int MemberId { get; set; }
    }
}