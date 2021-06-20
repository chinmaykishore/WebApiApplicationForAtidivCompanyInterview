using System;

namespace WebApplication1
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public double TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string PaymentStatus { get; set; } 

        public string TransactionDescription { get; set; }

        public DateTime InvoiceGenerationDate { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
