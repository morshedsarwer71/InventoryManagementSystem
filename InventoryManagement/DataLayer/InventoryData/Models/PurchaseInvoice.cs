﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataLayer.InventoryData.Models
{
    public class PurchaseInvoice
    {
        [Key]
        public int PurchaseInvoiceID { get; set; }
        public string PurchaseInvoiceCode { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal SalesUnitPrice { get; set; }
        public int SupplierID { get; set; }
        public int ConcernID { get; set; }
        public string Description { get; set; }
        public System.DateTime CreationDate { get; set; }
        public int Creator { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal CashPayment { get; set; }
        public decimal DuePayment { get; set; }
        public decimal Discount { get; set; }
    }
}