namespace Fortuna.Web.Blazor.Models.Asset
{
    public class AssetTypeDto
    {
        /// <summary>
        /// Gets or sets the AssetTypeId
        /// </summary>
        public int AssetTypeId { get; set; }

        /// <summary>
        /// Gets or sets the AssetTypeValue
        /// </summary>
        public string AssetTypeValue { get; set; }

        /// <summary>
        /// Gets or sets the AssetTypeDisplayValue
        /// </summary>
        public string AssetTypeDisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the AssetTypeDescription
        /// </summary>
        public string AssetTypeDescription { get; set; }

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
