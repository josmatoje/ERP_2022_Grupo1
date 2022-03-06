using ERP_2021_2022_Grupo_1_DAL.Lists;
using ERP_2021_2022_Grupo_1_Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_BL.Lists
{
    public class clsOrderLinesWithProductNameListBL
    {
        public clsOrderLineWithProductName getOrderLineWithProductNameBL(int id)
        {
            return new clsOrderLinesWithProductNameListDAL().getOrderLineWithProductNameDAL(id);
        }
    }
}
