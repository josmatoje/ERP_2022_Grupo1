﻿using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Utilities;

namespace ERP_2021_2022_Grupo_1_DAL.Managers
{
    public class clsOrderLineManagerDAL : clsUtilityDMLDAL
    {
        #region constants
        public const String UPDATE_INSTRUCTION_ORDER_LINE = "UPDATE OrderLines SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity, UnitPriceAtTime = @UnitPriceAtTime WHERE ID = @param";
        public const String INSERT_INSTRUCTION_ORDER_LINE = "INSERT INTO OrderLines VALUES (@OrderID, @ProductID, @Quantity, @UnitPriceAtTime)";
        public const String DELETE_INSTRUCTION_ORDER_LINE = "DELETE FROM OrderLines WHERE ID = @param";
        #endregion

        #region public methods
        

        /// <summary>
        /// <b>Prototype:</b> public int updateOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public int updateOrderLineDAL(clsOrderLine orderLine)
        {
            openConection();
            createCommand(orderLine);
            int resultado = orderLine.Id == 0 ? executeDMLSentence(INSERT_INSTRUCTION_ORDER_LINE) : executeDMLSentenceCondition(UPDATE_INSTRUCTION_ORDER_LINE, orderLine.Id);
            MyConnection.closeConnection();
            return resultado;
        }

        /// <summary>
        /// <b>Prototype:</b> public int deleteOrderLineDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public int deleteOrderLineDAL(int id)
        {
            openConection();
            int resultado = executeDMLSentenceCondition(DELETE_INSTRUCTION_ORDER_LINE, id);
            MyConnection.closeConnection();
            return resultado;
        }

        /// <summary>
        /// <b>Prototype:</b> private void createCommand(clsOrderLine orderLine) <br/>
        /// <b>Commentaries:</b>Create a command with orderLine atributes<br/>
        /// <b>Preconditions:</b> orderLine not null<br/>
        /// <b>Postconditions:</b> nothing
        /// </summary>
        /// <param name="orderLine"></param>

        private void createCommand(clsOrderLine orderLine) {
            MyCommand.Parameters.Add("@OrderID", System.Data.SqlDbType.Int).Value = orderLine.OrderId;
            MyCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = orderLine.ProductId;
            MyCommand.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = orderLine.Quantity;
            MyCommand.Parameters.Add("@UnitPriceAtTime", System.Data.SqlDbType.Money).Value = orderLine.CurrentUnitPrice;
        }
        #endregion

    }
}
