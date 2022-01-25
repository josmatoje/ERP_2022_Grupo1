using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsOrdersListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List(clsOrder) getOrdersListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of orders from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with all the orders from the Order table
        /// </summary>
        /// <returns> List(clsOrder) orderList representing the list of orders from the DAL</returns>
        public static List<clsOrder> getOrdersListBL()
        {
            return clsOrdersListDAL.getOrdersListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsOrder getOrderBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order from the DAL given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the Order table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrder order representing the specific order from the DAL</returns>
        public static clsOrder getOrderBL(int id)
        {
            return clsOrdersListDAL.getOrderDAL(id);
        }
    }
}
