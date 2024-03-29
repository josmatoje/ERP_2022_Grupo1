﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsProduct
    {
        #region attributes
        private int orderId;
        private string name;
        private string description;
        private double unitPrice;
        private String category;
        #endregion
        #region constructor
        public clsProduct(int orderId, string name, string description, double unitPrice, String category)
        {
            this.orderId = orderId;
            this.name = name;
            this.description = description;
            this.unitPrice = unitPrice;
            this.category = category;
        }
        #endregion
        #region public methods
        public int OrderId { get => orderId; }
        public string Name { get => name;}
        public string Description { get => description;}
        public double UnitPrice { get => unitPrice;}
        public string Category { get => category;}
        #endregion
    }
}
