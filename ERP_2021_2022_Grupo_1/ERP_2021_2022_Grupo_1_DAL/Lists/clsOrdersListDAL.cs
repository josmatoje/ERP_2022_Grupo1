using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;
namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsOrdersListDAL : clsUtilitySelectDAL
    {
        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public static List(clsOrder) getOrdersListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of orders from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with all the orders from the Order table
        /// </summary>
        /// <returns> List(clsOrder) orderList representing the list of orders from the DB</returns>
        public static List<clsOrder> getOrdersListDAL()
        {
            List<clsOrder> ordersList = new List<clsOrder>();
            clsOrder order ;
            openConection();
            MyReader = executeSelect("SELECT ID, Total, OrderDate, LimitDate, Notes, SuppliersID FROM Orders");
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    order = new clsOrder((int)MyReader["ID"], 
                                        (int)MyReader["Total"], 
                                        (DateTime)MyReader["OrderDate"], 
                                        (DateTime)MyReader["LimitDate"], 
                                        (string)MyReader["Notes"], 
                                        (int)MyReader["SupplierID"]);
                    ordersList.Add(order);
                }
            }
            closeFlow();
            return ordersList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsOrder getOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order from the DB given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the Order table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrder order representing the specific order from the DB or null if it doesn't exists or ie isn't found</returns>
        public static clsOrder getOrderDAL(int id)
        {
            clsOrder order = null;
            openConection();
            MyReader = executeSelectCondition("SELECT Total, OrderDate, LimitDate, Notes, SuppliersID FROM Orders", id);
            if (MyReader.HasRows)
            {
                order = new clsOrder(id, 
                                    (int)MyReader["Total"], 
                                    (DateTime)MyReader["OrderDate"], 
                                    (DateTime)MyReader["LimitDate"], 
                                    (string)MyReader["Notes"], 
                                    (int)MyReader["SupplierID"]);
            }
            closeFlow();
            return order;
        }
        #endregion
    }
}
