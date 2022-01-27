using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsSupplier
    {
        int idSupplier;
        string name;

        public clsSupplier(int idSupplier, string name)
        {
            this.idSupplier = idSupplier;
            this.name = name;
        }

        public int IdSupplier { get => idSupplier; }
        public string Name { get => name; set => name = value; }
    }
}
