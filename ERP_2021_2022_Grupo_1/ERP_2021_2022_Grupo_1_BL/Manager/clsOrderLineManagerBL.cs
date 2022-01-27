using ERP_2021_2022_Grupo_1_DAL.Manager;
using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_BL.Manager
{
    public class clsOrderLineManagerBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static int createOrderLineBL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Applies the business logic to store an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (created)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static int createOrderLineBL(clsOrderLine orderLine)
        {
            return clsOrderLineManagerDAL.createOrderLineDAL(orderLine);
        }
        /// <summary>
        /// <b>Prototype:</b> public static int updateOrderLineBL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Applies the business logic to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns  int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static int updateOrderLineBL(clsOrderLine orderLine)
        {
            return clsOrderLineManagerDAL.updateOrderLineDAL(orderLine);
        }
        /// <summary>
        /// <b>Prototype:</b> public static int deleteOrderLineBL(int id)<br/>
        /// <b>Commentaries:</b>Applies the business logic to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public static int deleteOrderLineBL(int id)
        {
            return clsOrderLineManagerDAL.deleteOrderLineDAL(id);
        }
    }
}
