using HuyShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyShop.Model.Models
{
    [Table("Posts")]
  public  class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }


        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }

        public string Content { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }



        public bool? HomeFlat { set; get; }

        public bool? HotFlat { set; get; }

        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

    }
}
