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
        /// <b>Prototype:</b> public List(clsOrder) getOrdersListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of orders from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with all the orders from the Order table
        /// </summary>
        /// <returns> List(clsOrder) orderList representing the list of orders from the DAL</returns>
        public List<clsOrder> getOrdersListBL()
        {
            return new clsOrdersListDAL().getOrdersListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public clsOrder getOrderBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order from the DAL given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the Order table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrder order representing the specific order from the DAL</returns>
        public clsOrder getOrderBL(int id)
        {
            return new clsOrdersListDAL().getOrderDAL(id);
        }

        /// <summary>
        /// <b>Prototype:</b> public List<clsOrder> getLastOrderIDBL()<br/>
        /// <b>Commentaries:</b>Returns an order's id from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns an order id which is the last inserted one's at the database
        /// </summary>
        /// <returns> clsOrder order representing the last inserted order's id at the database from the DAL</returns>
        public int getLastOrderIDBL()
        {
            return new clsOrdersListDAL().getLastOrderIDDAL();
        }
    }
}
