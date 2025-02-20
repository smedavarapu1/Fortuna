using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Expense
{
    public class QuantityTypeDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int QuantityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the QuantityTypeValue
        /// </summary>
        public string QuantityTypeValue { get; set; }

        /// <summary>
        /// Gets or sets the QuantityTypeDisplayValue
        /// </summary>
        public string QuantityTypeDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the QuantityTypeDescription
        /// </summary>
        public string QuantityTypeDescription { get; set; }

        /// <summary>
        /// Gets or sets the SortOrder
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the Active
        /// </summary>
        public bool Active { get; set; }
    }
}
