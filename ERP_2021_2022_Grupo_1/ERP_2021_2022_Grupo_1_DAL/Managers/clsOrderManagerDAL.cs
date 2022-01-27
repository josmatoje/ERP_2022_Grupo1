using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Managers
{
    public class clsOrderManagerDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static int createOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to store an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns  int indicating how many rows were changed (stored)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public static int createOrderDAL(clsOrder order)
        {
            return 0;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int updateOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public static int updateOrderDAL(clsOrder order)
        {
            return 0;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int deleteOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public static int deleteOrderDAL(int id)
        {
            return 0;
        }
    }
}
