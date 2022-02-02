using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsOrder
    {
        private int orderId;
        private int total;
        private DateTime orderDate;
        private DateTime limitOrderDate;
        private String notes;
        private int supplierId;

        public clsOrder(int orderId, int total, DateTime orderDate, DateTime limitOrderDate, string notes,int supplierId)
        {
            this.orderId = orderId;
            this.total = total;
            this.orderDate = orderDate;
            this.limitOrderDate = limitOrderDate;
            this.notes = notes;
            this.supplierId = supplierId;
        }

        public int OrderId { get => orderId; }
        public int Total { get => total; }
        public DateTime OrderDate { get => orderDate;  }
        public DateTime LimitOrderDate { get => limitOrderDate; }
        public string Notes { get => notes; set => notes = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
    }
}
