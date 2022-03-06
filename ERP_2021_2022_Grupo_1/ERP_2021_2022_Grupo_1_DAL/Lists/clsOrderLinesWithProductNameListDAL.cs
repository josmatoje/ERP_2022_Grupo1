using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Lists
{
    public class clsOrderLinesWithProductNameListDAL : clsUtilitySelectDAL
    {
        public List<clsOrderLineWithProductName> getOrderLineListWithProductNameByOrderIdDAL(int id)
        {
            clsOrderLineWithProductName orderLine;
            List<clsOrderLineWithProductName> orderLineList = new List<clsOrderLineWithProductName>();
            openConection();
            MyReader = executeSelectCondition("SELECT [OrderLines].ID, Quantity, UnitPriceAtTime, OrderID, ProductID, Subtotal, Name FROM OrderLines " +
                                        "INNER JOIN Products ON [OrderLines].ProductID = [Products].ID" +
                                        "WHERE OrderId = @id", id);


            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    orderLine = new clsOrderLineWithProductName((int)MyReader["ID"],
                                                    (int)MyReader["Quantity"],
                                                    Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                                    Decimal.ToDouble((decimal)MyReader["UnitPriceAtTime"]),
                                                    (int)MyReader["OrderID"],
                                                    (int)MyReader["ProductID"],
                                                    (string)MyReader["Name"]);
                    orderLineList.Add(orderLine);
                }
            }
            closeFlow();
            return orderLineList;
        }
    }
}
