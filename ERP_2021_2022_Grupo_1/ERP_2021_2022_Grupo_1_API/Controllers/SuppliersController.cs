using ERP_2021_2022_Grupo_1_BL.Lists;
using ERP_2021_2022_Grupo_1_BL.Manager;
using ERP_2021_2022_Grupo_1_Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP_2021_2022_Grupo_1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        /// <summary>
        /// <b>GET: api/*SuppliersController*</b><br/>
        /// <b>Prototype:</b> public IEnumerable(clsSupplier) Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of suppliers and 
        /// returning it<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of suppliers,
        /// if an error occurs during the execution, it throws a Exception
        /// </summary>
        /// <returns>IEnumerable(clsSupplier) list of suppliers or null</returns>
        [HttpGet]
        public IEnumerable<clsSupplier> Get()
        {
            List<clsSupplier> suppliersList = null;
            try
            {
                suppliersList = new clsSuppliersListBL().getSuppliersListBL();
            }
            catch (Exception)
            {
                throw;
            }

            return suppliersList;
        }

        /// <summary>
        /// <b>GET api/*SuppliersController*/5</b><br/>
        /// <b>Prototype:</b> public clsSupplier Get(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for a supplier with id and returning it<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a supplier with the id parameter,
        /// if an error occurs during the execution, it throws a Exception
        /// </summary>
        /// <param name="id"></param>
        /// <returns>clsSupplier the supplier of the DB or null</returns>
        [HttpGet("{id}")]
        public clsSupplier Get(int id)
        {
            clsSupplier supplier = null;
            try
            {
               
                supplier = new clsSuppliersListBL().getSupplierBL(id);
            }
            catch (Exception) 
            {
                throw;
            }
            return supplier;
        }
    }
}
