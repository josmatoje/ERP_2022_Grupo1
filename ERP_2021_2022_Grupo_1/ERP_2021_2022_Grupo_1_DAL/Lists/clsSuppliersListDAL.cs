using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Conexion;
using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsSuppliersListDAL : clsUtilitySelectDAL
    {
        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public static List(clsSupplier) getSuppliersListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of suppliers from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the suppliers from the Supplier table
        /// </summary>
        /// <returns> List(clsSupplier) supplierList representing the list of suppliers from the DB</returns>
        public static List<clsSupplier> getSuppliersListDAL()
        {
            clsSupplier supplier;
            List<clsSupplier> supplierList = new List<clsSupplier>();
            openConection();
            MyReader = executeSelect("SELECT ID, Name FROM Suppliers");
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    supplier = new clsSupplier((int)MyReader["ID"],(string)MyReader["Name"]);
                    supplierList.Add(supplier);
                }
            }
            closeFlow();
            return supplierList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsSupplier getSupplierDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific supplier from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific supplier from the supplier table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsSupplier supplier representing the specific supplier from the DB</returns>
        public static clsSupplier getSupplierDAL(int id)
        {
            clsSupplier supplier = null;
            openConection();
            MyReader = executeSelectCondition("SELECT ID, Name FROM Suppliers WHERE ID = @id", id);
            if (MyReader.HasRows)
            {
                MyReader.Read();
                supplier = new clsSupplier((int)MyReader["ID"], (string)MyReader["Name"]);
            }
            closeFlow();
            return supplier;
        }
        #endregion
    }
}
