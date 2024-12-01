using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Expense
{
    public class ExpenseTypeDto
    {
        /// <summary>
        /// Gets or sets the ExpenseTypeId
        /// </summary>
        public int ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseTypeValue
        /// </summary>
        public string ExpenseTypeValue { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseTypeDisplayValue
        /// </summary>
        public string ExpenseTypeDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseTypeDescription
        /// </summary>
        public string ExpenseTypeDescription { get; set; }

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
