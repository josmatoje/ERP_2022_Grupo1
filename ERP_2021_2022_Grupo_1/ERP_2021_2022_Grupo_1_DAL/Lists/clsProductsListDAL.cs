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
        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public List(clsProduct) getProductsListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of products from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the products from the Product table
        /// </summary>
        /// <returns> List(clsProduct) productList representing the list of products from the DB</returns>
        public List<clsProduct> getProductsListDAL()
        {
            openConection();
            clsProduct product;
            List<clsProduct> productList = new List<clsProduct>();
            //executeSelect("SELECT * FROM Products");
            MyReader = executeSelect("SELECT [Products].ID, [Products].Name, [Products].Description, UnitPrice, [Categories].Name AS Category from products " +
                                        "INNER JOIN Categories " +
                                        "ON [Products].CategoryID = [Categories].ID");
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    product = new clsProduct((int)MyReader["ID"], 
                                            (string)MyReader["Name"],
                                            (string)(MyReader["Description"]== System.DBNull.Value ? "" : (MyReader["Description"])),
                                            Decimal.ToDouble((decimal)MyReader["UnitPrice"]),
                                            (string)MyReader["Category"]);
                    productList.Add(product);
                }
            }
            closeFlow();
            return productList;
        }

        public List<clsProduct> getProductListSupplierDAL(int idSupplier)
        {
            openConection();
            clsProduct product;
            List<clsProduct> productList = new List<clsProduct>();
            //executeSelect("SELECT * FROM Products");
            MyReader = executeSelect("SELECT [Products].ID, [Products].Name, [Products].Description, UnitPrice, [Categories].Name AS Category FROM Categories "+
                                    "INNER JOIN Products ON[Categories].ID = [Products].CategoryID "+
                                    "INNER JOIN ProductsSuppliers ON[Products].ID = [ProductsSuppliers].IdProduct " +
                                    "INNER JOIN Suppliers ON[ProductsSuppliers].IdSupplier = [Suppliers].ID "+
                                    "WHERE IdSupplier = "+ idSupplier);
            while (MyReader.Read())
            {
                product = new clsProduct((int)MyReader["ID"],
                                        (string)MyReader["Name"],
                                        (string)(MyReader["Description"] == System.DBNull.Value ? "" : (MyReader["Description"])),
                                        Decimal.ToDouble((decimal)MyReader["UnitPrice"]),
                                        (string)MyReader["Category"]);
                productList.Add(product);
            }
            return productList;
        }

        /// <summary>
        /// <b>Prototype:</b> public clsProduct getProductDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific product from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific product from the Product table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsProduct product representing the specific product from the DB</returns>
        public clsProduct getProductDAL(int id)
        {
            openConection();
            clsProduct product = null;
            MyReader = executeSelectCondition("SELECT [Products].ID, [Products].Name, [Products].Description, UnitPrice, [Categories].Name AS Category from products " +
                                                "INNER JOIN Categories " +
                                                "ON [Products].CategoryID = [Categories].ID " +
                                                "WHERE [Products].ID = @id"
                                                , id);
            if (MyReader.HasRows)
            {
                MyReader.Read();
                product = new clsProduct((int)MyReader["ID"],
                                        (string)MyReader["Name"],
                                        (string)(MyReader["Description"] == System.DBNull.Value ? "" : (MyReader["Description"])),
                                        Decimal.ToDouble((decimal)MyReader["UnitPrice"]),
                                        (string)MyReader["Category"]);
            }
            closeFlow();
            return product;
        }      
        #endregion
    }
}
