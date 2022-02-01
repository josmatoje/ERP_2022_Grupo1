using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Conexion;
using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsProductsListDAL : clsUtilitySelectDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List(clsProduct) getProductsListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of products from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the products from the Product table
        /// </summary>
        /// <returns> List(clsProduct) productList representing the list of products from the DB</returns>
        public static List<clsProduct> getProductsListDAL()
        {
            List<clsProduct> productList = new List<clsProduct>();
            executeSelect("SELECT * FROM Products");
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    clsProduct product = new clsProduct((int)MyReader["ID"], (string)MyReader["Name"],(string)MyReader["Description"],(double)MyReader["UnitPrice"],(int)MyReader["CategoryID"]);
                    productList.Add(product);
                }
            }
            closeFlow();
            return productList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsProduct getProductDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific product from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific product from the Product table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsProduct product representing the specific product from the DB</returns>
        public static clsProduct getProductDAL(int id)
        {
            clsProduct product = null;
            executeSelectCondition("SELECT * FROM Products",id);
            if (MyReader.HasRows)
            {
                product = new clsProduct((int)MyReader["ID"], (string)MyReader["Name"], (string)MyReader["Description"], (double)MyReader["UnitPrice"], (int)MyReader["CategoryID"]);
            }
            closeFlow();
            return product;
        }
    }
}
