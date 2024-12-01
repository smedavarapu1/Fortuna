using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Expense
{
    public class ExpenseItemTypeDto
    {
        /// <summary>
        /// Gets or sets the ExpenseItemId
        /// </summary>
        public int ExpenseItemId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseItemTypeValue
        /// </summary>
        public string ExpenseItemTypeValue { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseItemTypeDisplayValue
        /// </summary>
        public string ExpenseItemTypeDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseItemTypeDescription
        /// </summary>
        public string ExpenseItemTypeDescription { get; set; }

        /// <summary>
        /// Gets or sets the SortOrder
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the Active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedDate
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
