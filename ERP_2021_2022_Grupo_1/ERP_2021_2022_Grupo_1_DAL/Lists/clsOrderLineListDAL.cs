using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsOrderLineListDAL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List(clsOrderLine) getOrderLineListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of order line list from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table
        /// </summary>
        /// <returns> List(clsOrderLine) orderLineList representing the list of order line from the DB</returns>
        public static List<clsOrderLine> getOrderLineListDAL()
        {
            List<clsOrderLine> orderLineList = new List<clsOrderLine>();
            return orderLineList;
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsOrderLine getOrderLineDAL()<br/>
        /// <b>Commentaries:</b>Returns a specific order line from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the OrderLine table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrderLine orderLine representing the specific order line from the DB</returns>
        public static clsOrderLine getOrderLineDAL(int id)
        {
            clsOrderLine orderLine = new clsOrderLine();
            return orderLine;
        }
    }
}
