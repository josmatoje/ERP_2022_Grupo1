using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_Entities;
using ERP_2021_2022_Grupo_1_DAL.Lists;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsProductsListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List(clsProduct) getProductListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of products from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the products from the Product table
        /// </summary>
        /// <returns> List(clsProduct) productList representing the list of products from the DAL</returns>
        public static List<clsProduct> getProductsListBL()
        {
            return clsProductsListDAL.getProductsListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsProduct getProductBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific product from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific product from the Product table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsProduct product representing the specific product from the DAL</returns>
        public static clsProduct getProductBL(int id)
        {
            return clsProductsListDAL.getProductDAL(id);
        }
    }
}
