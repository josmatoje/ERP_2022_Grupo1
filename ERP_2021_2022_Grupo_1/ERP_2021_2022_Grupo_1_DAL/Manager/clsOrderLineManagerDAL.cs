using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Manager
{
    public class clsOrderLineManagerDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static bool createOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to create an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully created
        /// </summary>
        /// <returns> bool succesful
        public static bool createOrderLineDAL(clsOrderLine orderLine)
        {
            return true;
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool updateOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully updated
        /// </summary>
        /// <returns> bool succesful
        public static bool updateOrderLineDAL(clsOrderLine orderLine)
        {
            return true;
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool deleteOrderLineDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully deleted
        /// </summary>
        /// <returns> bool succesful
        public static bool deleteOrderLineDAL(int id)
        {
            return true;
        }

    }
}
