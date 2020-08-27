﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderGift
    {
        [Key]
        public Guid OrderGiftID { get; set; }
        public Guid OrderDetailID { get; set; }
        public Guid ProductGiftID { get; set; }
        public int Quantity { get; set; }
    }
}
