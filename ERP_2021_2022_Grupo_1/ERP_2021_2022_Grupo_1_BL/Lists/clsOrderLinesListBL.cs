using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsOrderLinesListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public List(clsOrderLine) getOrderLineListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of order line list from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table
        /// </summary>
        /// <returns>List(clsOrderLine) orderLineList representing the list of order line from the DAL</returns>
        public List<clsOrderLine> getOrderLineListBL()
        {
            return new clsOrderLinesListDAL().getOrderLineListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public clsOrderLine getOrderLineBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific order line from the DAL given its id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order line from the Order table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrder order representing the specific order line from the DAL</returns>
        public clsOrderLine getOrderLineBL(int id)
        {
            return new clsOrderLinesListDAL().getOrderLineDAL(id);
        }

        /// <summary>
        /// <b>Prototype:</b> public List<clsOrderLine> getOrderLinesByOrderBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a list of order lines from the DAL given an OrderID<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table with the OrderID given
        /// </summary>
        /// <returns>List(clsOrderLine) orderLineList representing the list of order line from the DAL</returns>
        public List<clsOrderLine> getOrderLinesByOrderBL(int id)
        {
            return new clsOrderLinesListDAL().getOrderLinesByOrderDAL(id);
        }
    }
}
