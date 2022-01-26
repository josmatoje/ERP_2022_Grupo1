using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Manager
{
    public class clsOrderLineManagerDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static int createOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to store an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (stored)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static int createOrderLineDAL(clsOrderLine orderLine)
        {
            return 0;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int updateOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static int updateOrderLineDAL(clsOrderLine orderLine)
        {
            return 0;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int deleteOrderLineDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public static int deleteOrderLineDAL(int id)
        {
            return 0;
        }

    }
}
