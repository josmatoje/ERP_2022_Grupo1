using ERP_2021_2022_Grupo_1_DAL.Manager;
using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_BL.Manager
{
    public class clsOrderManagerBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static bool createOrderBL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Applies the business logic to create an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully created
        /// </summary>
        /// <returns> bool succesful
        public static bool createOrderBL(clsOrder order)
        {
            return clsOrderManagerDAL.createOrderDAL(order);
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool updateOrderBL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Applies the business logic to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully updated
        /// </summary>
        /// <returns> bool succesful
        public static bool updateOrderBL(clsOrder order)
        {
            return clsOrderManagerDAL.updateOrderDAL(order);
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool deleteOrderBL(int id)<br/>
        /// <b>Commentaries:</b>Applies the business logic to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order was succesfully deleted
        /// </summary>
        /// <returns> bool succesful
        public static bool deleteOrderBL(int id)
        {
            return clsOrderManagerDAL.deleteOrderDAL(id);
        }
    }
}
