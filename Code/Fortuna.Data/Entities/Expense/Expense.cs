using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Entities.Expense
{
    public class Expense
    {
        /// <summary>
        /// Gets or sets the ExpenseId
        /// </summary>
        public int ExpenseId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseTypeId
        /// </summary>
        public int ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseItemTypeId
        /// </summary>
        public int ExpenseItemTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseAmount
        /// </summary>
        public decimal ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseName
        /// </summary>
        public string ExpenseName { get; set; }

        public int? QuantityTypeId { get; set; }

        public int? Quantity { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime UpdatedDate = DateTime.Now;

        public string UpdatedBy = "system";

        public int StoreId { get; set; }
    }
}
