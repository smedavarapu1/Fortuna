using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.Entities.Expense
{
    public class Store
    {
        /// <summary>
        /// Gets or sets the StoreId
        /// </summary>
        public int StoreId { get; set; }

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

        /// <summary>
        /// Gets or sets the UpdatedBy
        /// </summary>
        public string UpdatedBy = "System";

        /// <summary>
        /// Gets or sets the UpdatedDate
        /// </summary>
        public DateTime UpdatedDate = DateTime.Now;

    }
}
