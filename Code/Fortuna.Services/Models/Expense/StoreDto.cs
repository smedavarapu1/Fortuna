using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Expense
{
    public class StoreDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int? StoreId { get; set; }

        /// <summary>
        /// Gets or sets the StoreValue
        /// </summary>
        public string StoreValue { get; set; }

        /// <summary>
        /// Gets or sets the StoreDisplayValue
        /// </summary>
        public string StoreDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the StoreDescription
        /// </summary>
        public string StoreDescription { get; set; }

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
