using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsOrderLineListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public static List<clsOrderLine> getOrderLineListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of order line list from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table
        /// </summary>
        /// <returns> List<clsOrderLine> orderLineList representing the list of order line from the DAL</returns>
        public static List<clsOrderLine> getOrderLineListBL()
        {
            return clsOrderLineListDAL.getOrderLineListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public static clsOrderLine getOrderLineBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order line from the DAL given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order line from the Order table
        /// </summary>
        /// <returns> clsOrder order representing the specific order line from the DAL</returns>
        public static clsOrderLine getOrderLineBL(int id)
        {
            return clsOrderLineListDAL.getOrderLineDAL(id);
        }
    }
}
