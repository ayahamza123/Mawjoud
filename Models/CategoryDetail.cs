using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mawjoud2.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Le nom du produit est obligatoire")]
        [StringLength(100, ErrorMessage = "la longueur du nom du produit doit être comprise entre 3 et 100 caractères")]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}