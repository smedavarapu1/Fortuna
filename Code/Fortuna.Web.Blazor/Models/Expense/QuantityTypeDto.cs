namespace Fortuna.Web.Blazor.Models.Expense
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
