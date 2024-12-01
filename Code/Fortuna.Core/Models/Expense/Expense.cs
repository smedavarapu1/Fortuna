using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Core.Models.Expense
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
        /// Gets or sets the ExpenseItemId
        /// </summary>
        public int ExpenseItemId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseAmount
        /// </summary>
        public decimal ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseName
        /// </summary>
        public string ExpenseName { get; set; }
    }
}
