using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileEngine.Models;
using AgileEngine.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgileEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            RPClient rpC = new RPClient();
            return Ok(rpC.getClients());
        }

        [HttpPost("agregar")]
        public IActionResult AddClient (Client newClient)
        {
            RPClient rpC = new RPClient();
            rpC.AddNewClient(newClient);
            return CreatedAtAction(nameof(AddClient), newClient);
        }



    }
}