using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsOrderLine
    {
        int id;
        int quantity;
        double currentUnitPrice;
        int subtotal;

        public clsOrderLine(int id, int quantity, double currentUnitPrice, int subtotal)
        {
            this.id = id;
            this.quantity = quantity;
            this.currentUnitPrice = currentUnitPrice;
            this.subtotal = subtotal;
        }

        public int Id { get => id; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double CurrentUnitPrice { get => currentUnitPrice; set => currentUnitPrice = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
    }
}
