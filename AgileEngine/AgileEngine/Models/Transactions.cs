using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileEngine.Models
{
    public class Transactions
    {
        public int IdTransaction { get; set; }
        public string Type { get; set; }
        public int IdUser { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
