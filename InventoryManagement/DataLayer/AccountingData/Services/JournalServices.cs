using InventoryManagement.DataLayer.AccountingData.Intefaces;
using InventoryManagement.DataLayer.AccountingData.Models;
using InventoryManagement.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataLayer.AccountingData.Services
{
    public class JournalServices : IJournal
    {
        private readonly DataContext _context;
        public JournalServices(DataContext context)
        {
            _context = context;
        }
        public void Add(Journal journal)
        {
            _context.Journals.Add(journal);
            _context.SaveChanges();
        }
    }
}