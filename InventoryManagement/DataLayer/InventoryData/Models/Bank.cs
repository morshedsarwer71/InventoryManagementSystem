using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataLayer.InventoryData.Models
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string BranchAddress { get; set; }
        [Required]
        public int BranchContact { get; set; }
        public string Description { get; set; }
        public int ConcernID { get; set; }
        public DateTime CreationDate { get; set; }
        public int Creator { get; set; }
        public int IsDelete { get; set; }
    }
}