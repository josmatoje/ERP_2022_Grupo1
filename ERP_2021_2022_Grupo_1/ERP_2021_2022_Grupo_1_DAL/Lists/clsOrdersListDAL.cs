using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_Entities;
namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsOrdersListDAL
    {
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
            return ordersList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsOrder getOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order from the DB given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the Order table
        /// </summary>
        /// <returns> clsOrder order representing the specific order from the DB</returns>
        public static clsOrder getOrderDAL(int id)
        {
            clsOrder order = new clsOrder();
            return order;
        }
    }
}
