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
        /// <b>Prototype:</b> public static bool createOrderLineBL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Applies the business logic to create an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully created
        /// </summary>
        /// <returns> bool succesful
        public static bool createOrderLineBL(clsOrderLine orderLine)
        {
            return clsOrderLineManagerDAL.createOrderLineDAL(orderLine);
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool updateOrderLineBL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Applies the business logic to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully updated
        /// </summary>
        /// <returns> bool succesful
        public static bool updateOrderLineBL(clsOrderLine orderLine)
        {
            return clsOrderLineManagerDAL.updateOrderLineDAL(orderLine);
        }
        /// <summary>
        /// <b>Prototype:</b> public static bool deleteOrderLineBL(int id)<br/>
        /// <b>Commentaries:</b>Applies the business logic to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns boolean indicating if the order line was succesfully deleted
        /// </summary>
        /// <returns> bool succesful
        public static bool deleteOrderLineBL(int id)
        {
            return clsOrderLineManagerDAL.deleteOrderLineDAL(id);
        }
    }
}
