using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsSuppliersListDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List<clsSupplier> getSuppliersListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of suppliers from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the suppliers from the Supplier table
        /// </summary>
        /// <returns> List<clsSupplier> supplierList representing the list of suppliers from the DB</returns>
        public static List<clsSupplier> getSuppliersListDAL()
        {
            List<clsSupplier> supplierList = new List<clsSupplier>();
            return supplierList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsSupplier getSupplierDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific supplier from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific supplier from the supplier table
        /// </summary>
        /// <returns> clsSupplier supplier representing the specific supplier from the DB</returns>
        public static clsSupplier getSupplierDAL(int id)
        {
            clsSupplier supplier = new clsSupplier();
            return supplier;
        }
    }
}
