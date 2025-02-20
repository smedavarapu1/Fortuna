namespace Fortuna.Web.Blazor.Models.Expense
{
    public class ExpenseDto
    {
        /// <summary>
        /// Gets or sets the ExpenseId
        /// </summary>
        public int ExpenseId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseTypeId
        /// </summary>
        public int ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseItemTypeId
        /// </summary>
        public int ExpenseItemTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseAmount
        /// </summary>
        public decimal ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or sets the ExpenseName
        /// </summary>
        public string ExpenseName { get; set; }

        public int? QuantityTypeId { get; set; }

        public int? Quantity { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int StoreId { get; set; }
    }
}
