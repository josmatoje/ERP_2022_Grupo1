using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_Entities.Models
{
    public class clsOrderLineWithProductName : clsOrderLine
    {
        #region attributes
        private string productname;
        #endregion
        #region constructor
        public clsOrderLineWithProductName() : base() { }
        public clsOrderLineWithProductName(int id, int quantity, double currentUnitPrice, double subtotal, int orderId, int productId, string productName) : base(id, quantity, currentUnitPrice, subtotal, orderId, productId)
        {
            this.productname = productName;
        }

        #endregion
        #region public methods
        public string Productname { get => productname; set => productname = value; }
        #endregion
    }
}
