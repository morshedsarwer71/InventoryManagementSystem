﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataLayer.InventoryData.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryID { get; set; }
        public int ConcernID { get; set; }
        public string Description { get; set; }
        public System.DateTime CreationDate { get; set; }
        public int Creator { get; set; }
        public int IsDelete { get; set; }
    }
}