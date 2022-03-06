
using ERP_2021_2022_Grupo_1_BL.Lists;
using ERP_2021_2022_Grupo_1_Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP_2021_2022_Grupo_1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesWithProductNameController : ControllerBase
    {
        /// <summary>
        /// <b>GET api/*OrderLinesWithProductNameController*/5</b><br/>
        /// <b>Prototype:</b> public IEnumerable(clsOrderLine) Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of orderlines and 
        /// returning it<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of orderlines,
        /// if an error occurs during the execution, it throws a Exception and the return null
        /// </summary>
        /// <returns>IEnumerable(clsOrderLine) list of orderlines or null</returns>
        [HttpGet("{id}")]
        public IEnumerable<clsOrderLineWithProductName> Get(int id)
        {

            List<clsOrderLineWithProductName> clsOrderLineWithProductNamesList = null;
            try
            {
                clsOrderLineWithProductNamesList = new clsOrderLinesWithProductNameListBL().getOrderLineListWithProductNameByOrderIdBL(id);
            }
            catch (Exception)
            {
                throw;
            }

            return clsOrderLineWithProductNamesList;
        }
    }
}
