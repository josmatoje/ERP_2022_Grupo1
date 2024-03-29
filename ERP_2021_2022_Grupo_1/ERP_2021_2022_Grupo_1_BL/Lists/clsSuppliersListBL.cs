﻿using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsSuppliersListBL
    {
        /// <summary>
        /// <b>Prototype:</b> public List(clsSupplier) getSuppliersListBL()<br/>
        /// <b>Commentaries:</b>Returns a list of suppliers from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a list with the suppliers from the Supplier table
        /// </summary>
        /// <returns> List(clsSupplier) supplierList representing the list of suppliers from the DAL</returns>
        public List<clsSupplier> getSuppliersListBL()
        {
            return new clsSuppliersListDAL().getSuppliersListDAL();
        }

        /// <summary>
        /// <b>Prototype:</b> public clsSupplier getSupplierBL(int id)<br/>
        /// <b>Commentaries:</b>Returns a specific supplier from the DAL<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Returns a specific supplier from the supplier table
        /// </summary>
        /// <param name="int id"></param>
        /// <returns> clsSupplier supplier representing the specific supplier from the DAL</returns>
        public clsSupplier getSupplierBL(int id)
        {
            return new clsSuppliersListDAL().getSupplierDAL(id);
        }
    }
}
