﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsProduct
    {
        private int orderId;
        private string name;
        private string description;
        private double unitPrice;
        private String category;

        public clsProduct(int orderId, string name, string description, double unitPrice, String category)
        {
            this.orderId = orderId;
            this.name = name;
            this.description = description;
            this.unitPrice = unitPrice;
            this.category = category;
        }

        public int OrderId { get => orderId; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string Category { get => category; set => category = value; }
    }
}
