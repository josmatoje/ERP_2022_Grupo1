using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsOrder
    {
        int orderId;
        int total;
        DateTime orderDate;
        DateTime limitOrderDate;
        String notes;
        clsSupplier suplier;

        public clsOrder(int orderId, int total, DateTime orderDate, DateTime limitOrderDate, string notes, clsSupplier suplier)
        {
            this.orderId = orderId;
            this.total = total;
            this.orderDate = orderDate;
            this.limitOrderDate = limitOrderDate;
            this.notes = notes;
        }

        public int OrderId { get => orderId; }
        public int Total { get => total; }
        public DateTime OrderDate { get => orderDate;  }
        public DateTime LimitOrderDate { get => limitOrderDate; }
        public string Notes { get => notes; set => notes = value; }
        public clsSupplier Suplier { get => suplier; set => suplier = value; }
    }
}
