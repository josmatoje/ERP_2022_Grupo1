using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsOrderLinesWithProductNameListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public List<clsOrderLineWithProductName> getOrderLineListWithProductNameByOrderIdBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a list of order line list from the DAL with the productNames<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table
        /// </summary>
        /// <returns>List(clsOrderLine) orderLineList representing the list of order line from the DAL</returns>
        public List<clsOrderLineWithProductName> getOrderLineListWithProductNameByOrderIdBL(int id)
        {
            return new clsOrderLinesWithProductNameListDAL().getOrderLineListWithProductNameByOrderIdDAL(id);
        }
    }
}
