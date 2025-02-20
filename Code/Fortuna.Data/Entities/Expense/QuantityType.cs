using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Entities.Expense
{
    public class QuantityType
    {
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

        /// <summary>
        /// Gets or sets the UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedDate
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the QuantityTypeId
        /// </summary>
        public int QuantityTypeId { get; set; }
    }
}
