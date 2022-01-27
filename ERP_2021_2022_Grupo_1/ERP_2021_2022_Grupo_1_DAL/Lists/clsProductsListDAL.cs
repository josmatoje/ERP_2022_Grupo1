using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsProductsListDAL
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
            clsProduct product = new clsProduct();
            return product;
        }
    }
}
