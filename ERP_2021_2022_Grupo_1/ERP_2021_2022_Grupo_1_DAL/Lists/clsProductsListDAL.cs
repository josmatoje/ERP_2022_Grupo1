﻿using System;
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
        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public static List(clsProduct) getProductsListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of products from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the products from the Product table
        /// </summary>
        /// <returns> List(clsProduct) productList representing the list of products from the DB</returns>
        public static List<clsProduct> getProductsListDAL()
        {
            openConection();
            List<clsProduct> productList = new List<clsProduct>();
            //executeSelect("SELECT * FROM Products");
            MyReader = executeSelect("SELECT P.ID, P.Name, P.Description, UnitPrice, C.Name AS Category from products AS P" +
                            "INNER JOIN Categories AS C" +
                            "ON P.CategoryID = C.ID");
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    clsProduct product = new clsProduct((int)MyReader["ID"], (string)MyReader["Name"],(string)MyReader["Description"],(double)MyReader["UnitPrice"],(string)MyReader["Category"]);
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
            openConection();
            clsProduct product = null;
            MyReader = executeSelectCondition("SELECT P.ID, P.Name, P.Description, UnitPrice, C.Name AS Category from products AS P" +
                                    "INNER JOIN Categories AS C" +
                                    "ON P.CategoryID = C.ID"
                                    , id);
            if (MyReader.HasRows)
            {
                product = new clsProduct((int)MyReader["ID"], (string)MyReader["Name"], (string)MyReader["Description"], (double)MyReader["UnitPrice"], (string)MyReader["Category"]);
            }
            closeFlow();
            return product;
        }
        #endregion
    }
}
