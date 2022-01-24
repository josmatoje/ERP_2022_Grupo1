using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Manager
{
    public class clsOrderManagerDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static bool createOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to create an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully created
        /// </summary>
        /// <returns> bool succesful
        public static bool createOrderDAL(clsOrder order)
        {
            return true;
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool updateOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully updated
        /// </summary>
        /// <returns> bool succesful
        public static bool updateOrderDAL(clsOrder order)
        {
            return true;
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool deleteOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully deleted
        /// </summary>
        /// <returns> bool succesful
        public static bool deleteOrderDAL(int id)
        {
            return true;
        }
    }
}
