using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsProduct
    {
        int orderId;
        string name;
        string description;
        double unitPrice;
        int categoryId;

        public clsProduct(int orderId, string name, string description, double unitPrice, int categoryId)
        {
            this.orderId = orderId;
            this.name = name;
            this.description = description;
            this.unitPrice = unitPrice;
            this.categoryId = categoryId;
        }

        public int OrderId { get => orderId; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }

    }
}
