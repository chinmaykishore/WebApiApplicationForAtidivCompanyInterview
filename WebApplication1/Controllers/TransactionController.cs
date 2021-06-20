using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {

        IList<Transaction> Transactions = new List<Transaction>()
        {
            new Transaction()
                {
                    TransactionId = 1, TransactionDescription = "Bill for hotel", TransactionAmount = 1234, 
                    TransactionDate = new DateTime(2021, 06, 18), PaymentStatus = "Unbilled" , 
                    InvoiceGenerationDate = new DateTime(), PaymentDate = new DateTime()
                },
                new Transaction()
                {
                    TransactionId = 2, TransactionDescription = "Bill for book", TransactionAmount = 435, 
                    TransactionDate = new DateTime(2021, 06, 1), PaymentStatus = "Billed" ,
                    InvoiceGenerationDate = new DateTime(), PaymentDate = new DateTime()
                },
                new Transaction()
                {
                    TransactionId = 3, TransactionDescription = "bill for chocolate", TransactionAmount = 36, 
                    TransactionDate = new DateTime(2021, 06, 5), PaymentStatus = "Paid" ,
                    InvoiceGenerationDate = new DateTime(), PaymentDate = new DateTime()
                },
                new Transaction()
                {
                    TransactionId = 4, TransactionDescription = "Bill for copy", TransactionAmount = 78, 
                    TransactionDate = new DateTime(2021, 06, 8), PaymentStatus = "Billed" ,
                    InvoiceGenerationDate = new DateTime(), PaymentDate = new DateTime()
                },
                new Transaction()
                {
                    TransactionId = 5, TransactionDescription = "Bill for cold drink", TransactionAmount = 89, 
                    TransactionDate = new DateTime(2021, 06, 20), PaymentStatus = "Unbilled" ,
                    InvoiceGenerationDate = new DateTime(), PaymentDate = new DateTime()
                },
        };

        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<Transaction> GetAllTransactions()
        {
            //Return list of all Transactions  
            return Transactions;
        }

        [HttpGet]
        public Transaction GetTransactionDetails(int id)
        {
            //Return a single Transaction detail  
            var Transaction = Transactions.FirstOrDefault(e => e.TransactionId == id);
            if (Transaction == null)
            {
                return new Transaction();
            }
            return Transaction;
        }

        [HttpGet]
        public IActionResult GetTransactionDetails1(int id)
        {
            //Return a single Transaction detail  
            var Transaction = Transactions.FirstOrDefault(e => e.TransactionId == id);
            if (Transaction == null)
            {
                return NotFound();
            }
            return Ok(Transaction);
        }

        [HttpGet]
        public IActionResult GetAllTransactions1()
        {
            //Return list of all Transactions  
            return Ok(Transactions);
        }
    }
}
