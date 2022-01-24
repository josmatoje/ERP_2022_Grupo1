using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsSuppliersListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List<clsSupplier> getSuppliersListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of suppliers from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the suppliers from the Supplier table
        /// </summary>
        /// <returns> List<clsSupplier> supplierList representing the list of suppliers from the DAL</returns>
        public static List<clsSupplier> getSuppliersListBL()
        {
            return clsSuppliersListDAL.getSuppliersListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsSupplier getSupplierBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific supplier from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific supplier from the supplier table
        /// </summary>
        /// <returns> clsSupplier supplier representing the specific supplier from the DAL</returns>
        public static clsSupplier getSupplierBL(int id)
        {
            return clsSuppliersListDAL.getSupplierDAL(id);
        }
    }
}
