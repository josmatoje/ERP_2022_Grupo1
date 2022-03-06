using ERP_2021_2022_Grupo_1_API.Models;
using ERP_2021_2022_Grupo_1_BL.Lists;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP_2021_2022_Grupo_1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesWithProductNameController : ControllerBase
    {
        // GET api/<OrderLinesWithProductNameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            clsOrderLineWithProductName orderLineWithProductName = null;
            try
            {
                orderLineWithProductName = new clsOrderLinesWithProductNameListBL().getOrderLineWithProductNameBL(id);
            }
            catch (Exception)
            {
                throw;
            }

            return orderLineWithProductName;
        }
    }
}
