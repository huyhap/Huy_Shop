﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessenger { set; get; }

        public decimal CreateDate { set; get; }

        public string CreateBy { set; get; }
        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        
        public string PaymentStatus { set; get; }
        
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
