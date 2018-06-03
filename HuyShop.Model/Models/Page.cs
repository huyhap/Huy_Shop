using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        public string Content { set; get; }

        public string MetaDescription { set; get; }

        public string MetaKeyword { set; get; }

        public bool Status { set; get; }
    }
}
