using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsOrderLine
    {
        #region attributes
        private int id;
        private int quantity;
        private double currentUnitPrice;
        private double subtotal;
        private int orderId;
        private int productId;
        #endregion
        #region constructor
        public clsOrderLine(int id, int quantity, double currentUnitPrice, double subtotal, int orderId, int productId)
        {
            this.id = id;
            this.quantity = quantity;
            this.currentUnitPrice = currentUnitPrice;
            this.subtotal = subtotal;
            this.orderId = orderId;
            this.productId = productId;
        }
        public clsOrderLine()
        {
            this.id = 0;
            this.quantity = 0;
            this.currentUnitPrice = 0;
            this.subtotal = 0;
            this.orderId = 0;
            this.productId = 0;
        }
        #endregion
        #region public methods
        public int Id { get => id; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double CurrentUnitPrice { get => currentUnitPrice; set => currentUnitPrice = value; }
        public double Subtotal { get => subtotal; }

        public int OrderId { get => orderId; set => orderId = value; }
        public int ProductId { get => productId; set => productId = value; }
        #endregion
    }
}
