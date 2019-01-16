using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
   public class Product:BaseEntity<int>
    {
        public string PName { get; set; }
        [Required]
        [Index(IsUnique =true)]
        public string Barkod { get; set; }
        public decimal UBPrice { get; set; }
        public byte[] UPicture { get; set; }
        public decimal Stock { get; set; }

        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


    }
}
