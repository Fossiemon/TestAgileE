using AgileEngine.Models;
using AgileEngine.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgileEngine.Controllers
{
    [Route("api/Transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPTransactions rpT = new RPTransactions();
            return Ok(rpT.getTranHistory());
        }

        [HttpPost("addT")]
        public IActionResult AddTransaction(Transactions newTransaction)
        {
            RPTransactions rpT = new RPTransactions();
            var res = rpT.CheckMoney(newTransaction.Type);
            if (res == true)
                rpT.AddNewTransaction(newTransaction);
            else
            {
                var nf = NotFound("Error");
                return nf;
            }
            return CreatedAtAction(nameof(AddTransaction), newTransaction);
        }
    }
}