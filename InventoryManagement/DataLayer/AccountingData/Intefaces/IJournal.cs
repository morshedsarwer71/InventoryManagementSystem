using InventoryManagement.DataLayer.AccountingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DataLayer.AccountingData.Intefaces
{
    public interface IJournal
    {
        void Add(Journal journal);
    }
}
