using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taskkk.Models;

namespace Taskkk.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeRestController : Controller
    {
        private OrdersTestContext db = new OrdersTestContext();

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = db.TblPoints.Where(p => p.PntName1.StartsWith(term)).Select(p => p.PntName1).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
