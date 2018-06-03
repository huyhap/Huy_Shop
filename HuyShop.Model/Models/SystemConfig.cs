﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyShop.Model.Models
{
    [Table("SystemConfig")]
  public  class SystemConfig
    {
        [Key]
        public int ID { set; get; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Code { set; get; }
        [MaxLength(50)]
        public string ValueString   { set; get; }

        public string ValueInt { set; get; }
    }
}
