using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_Entities
{
    public class clsSupplier
    {
        #region attributes
        private int idSupplier;
        private string name;
        #endregion
        #region constructor
        public clsSupplier(int idSupplier, string name)
        {
            this.idSupplier = idSupplier;
            this.name = name;
        }
        #endregion
        #region public methods
        public int IdSupplier { get => idSupplier; }
        public string Name { get => name; set => name = value; }
        #endregion
    }
}
