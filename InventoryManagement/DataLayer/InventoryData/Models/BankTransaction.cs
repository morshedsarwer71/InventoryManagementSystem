using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataLayer.InventoryData.Models
{
    public class BankTransaction
    {
        [Key]
        public int BankTransactionID { get; set; }
        [Required]
        public int TransactionType { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string CheckNumber { get; set; }
        [Required]
        public string BearerName { get; set; }
        public string Description { get; set; }
        public int ConcernID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public int Creator { get; set; }
        public int IsDelete { get; set; }
        [Required]
        public int BankID { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public string Voucher { get; set; }
    }
}