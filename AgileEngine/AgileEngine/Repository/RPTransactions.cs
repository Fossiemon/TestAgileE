using AgileEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileEngine.Repository
{
    public class RPTransactions
    {
        public static List<Transactions> _lstTransactions = new List<Transactions>() {
            new Transactions(){IdTransaction=0, IdUser= 0, Type = "Credit", Amount = 1000.00F , TransactionDate = DateTime.Today },
            new Transactions(){IdTransaction=1, IdUser= 0, Type = "Debit", Amount = 1000.00F , TransactionDate = DateTime.Today },
            new Transactions(){IdTransaction=0, IdUser= 0, Type = "Credit", Amount = -5000.00F , TransactionDate = DateTime.Today },
        };


        public IEnumerable<Transactions> getTranHistory()
        {
            return _lstTransactions;
        }

        public void AddNewTransaction(Transactions newT)
        {
            _lstTransactions.Add(newT);
        }

        public bool CheckMoney(string newT)
        {
            var response = true;
            switch (newT)
            {
                case "Credit":
                    var result = _lstTransactions.Where(c => c.Type.Equals("Credit")).ToList();
                    double total = result.Sum(c => c.Amount);
                    if (total < 0)
                        response = false;
                        
                    break;
                case "Debit":
                    var result2 = _lstTransactions.Where(c => c.Type.Equals("Debit")).ToList();
                    double total2 = result2.Sum(c => c.Amount);
                    if (total2 < 0)
                        response = false;
                    break;
            }
            return response;
        }

    }
}
