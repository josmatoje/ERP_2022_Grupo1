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
        /// <b>Prototype:</b> public List(clsProduct) getProductListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of products from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the products from the Product table
        /// </summary>
        /// <returns> List(clsProduct) productList representing the list of products from the DAL</returns>
        public List<clsProduct> getProductsListBL()
        {
            return new clsProductsListDAL().getProductsListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public clsProduct getProductBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific product from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific product from the Product table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsProduct product representing the specific product from the DAL</returns>
        public clsProduct getProductBL(int id)
        {
            return new clsProductsListDAL().getProductDAL(id);
        }

        /// <summary>
        /// <b>Prototype:</b> public clsProduct getProductListSupplierBL(int idSupplier)<br/>
        /// <b>Commentaries:</b> Returns a list of products from the DAL whose has this id supplier<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Call  clsProductsListDAL().getProductListSupplierDAL(idSupplier) and get the list of
        /// products has the id parameter supplier
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> List(clsProduct) productList representing the list of products from the DAL</returns>
        public List<clsProduct> getProductListSupplierBL(int idSupplier)
        {
            return new clsProductsListDAL().getProductListSupplierDAL(idSupplier);
        }
    }
}
