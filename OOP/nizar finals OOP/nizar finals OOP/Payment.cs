using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int No { get; set; }


        public Payment(decimal amount,DateTime date,string description,int no)
        {
            Amount = amount;
            Date = date;
            Description = description;
            No = no;
        }
        public override string ToString()
        {
            return $"amount: {Amount}\t Date: {Date}\t Description: {Description} No: {No}";
        }

    }
}
