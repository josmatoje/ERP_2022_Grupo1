using ERP_2021_2022_Grupo_1_DAL.Managers;
using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_BL.Manager
{
    public class clsOrderManagerBL
    {
        /// <summary>
        /// <b>Prototype:</b> public int updateOrderBL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Applies the business logic to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public int updateOrderBL(clsOrder order)
        {
            return new clsOrderManagerDAL().updateOrderDAL(order);
        }
        /// <summary>
        /// <b>Prototype:</b> public int deleteOrderBL(int id)<br/>
        /// <b>Commentaries:</b>Applies the business logic to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public int deleteOrderBL(int id)
        {
            return new clsOrderManagerDAL().deleteOrderDAL(id);
        }
    }
}
