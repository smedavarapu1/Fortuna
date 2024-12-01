using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Services.Models.Asset
{
    public class AssetDto
    {
        /// <summary>
        /// Gets or sets the AssetId
        /// </summary>
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or sets the AssetTypeId
        /// </summary>
        public int AssetTypeId { get; set; }

        /// <summary>
        /// Gets or sets the AssetName
        /// </summary>
        public string AssetName { get; set; }

        /// <summary>
        /// Gets or sets the BoughtPrice
        /// </summary>
        public decimal? BoughtPrice { get; set; }

        /// <summary>
        /// Gets or sets the CurrentPrice
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Gets or sets the CountryId
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the Year
        /// </summary>
        public int? Year { get; set; }

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
