using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Common
{
    public class CountryDto
    {
        /// <summary>
        /// Gets or sets the CountryId
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the CountryValue
        /// </summary>
        public string CountryValue { get; set; }

        /// <summary>
        /// Gets or sets the CountryDisplayValue
        /// </summary>
        public string CountryDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the CountryDescription
        /// </summary>
        public string CountryDescription { get; set; }

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
