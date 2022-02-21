using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsOrderLinesListDAL : clsUtilitySelectDAL
    {
        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public List(clsOrderLine) getOrderLineListDAL()<br/>
        /// <b>Commentaries:</b>Returns a list of order line list from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the order line list from the OrderLine table
        /// </summary>
        /// <returns> List(clsOrderLine) orderLineList representing the list of order line from the DB</returns>
        public List<clsOrderLine> getOrderLineListDAL()
        {
            clsOrderLine orderLine;
            List<clsOrderLine> orderLineList = new List<clsOrderLine>();
            openConection();
            MyReader = executeSelect("SELECT ID, Quantity, UnitPriceAtTime, OrderID, ProductID, Subtotal FROM OrderLines");

            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    orderLine = new clsOrderLine((int)MyReader["ID"], 
                                                    (int)MyReader["Quantity"],
                                                    Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                                    Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                                    (int)MyReader["OrderID"], 
                                                    (int)MyReader["ProductID"]);
                    orderLineList.Add(orderLine);
                }
            }
            closeFlow();
            return orderLineList;
        }

        /// <summary>
        /// <b>Prototype:</b> public clsOrderLine getOrderLineDAL()<br/>
        /// <b>Commentaries:</b>Returns a specific order line from the DB<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific order from the OrderLine table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsOrderLine orderLine representing the specific order line from the DB</returns>
        public clsOrderLine getOrderLineDAL(int id)
        {
            clsOrderLine orderLine = new clsOrderLine();
            openConection();
            MyReader = executeSelectCondition("SELECT Quantity, UnitPriceAtTime, OrderID, ProductID, Subtotal FROM OrderLines WHERE ID = @id", id);
            if (MyReader.HasRows)
            {
                MyReader.Read();
                orderLine = new clsOrderLine(id,
                                            (int)MyReader["Quantity"],
                                            Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                            Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                            (int)MyReader["OrderID"],
                                            (int)MyReader["ProductID"]);
            }
            closeFlow();
            return orderLine;
        }
        #endregion
    }
}
