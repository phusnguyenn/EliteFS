﻿using Elite_Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Core.EliteModels
{
    public class Order : BaseModel
    {
        public string Message { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalProduct { get; set; }
        public int TotalQuanlity { get; set; }
        public string Description { get; set; }
    }
}
