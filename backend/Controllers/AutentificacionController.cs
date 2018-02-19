using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class AutentificacionController : Controller
    {
        [HttpPost]
        public async Task<JsonResult> Login([FromBody]ParamLogin value)
        {
            // return new string[] { value.UserName, value.Password };
            return await JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json";
        }

        [HttpGet]
        public async Task<JsonResult> Login()
        {
            // IActionResult
            // return Json(_authorRepository.List());
            return await Json("HttpGet login");
        }
    }


}