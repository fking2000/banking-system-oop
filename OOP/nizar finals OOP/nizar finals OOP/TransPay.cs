using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class TransPay:Payment
    {
        public string BankNo { get; set; }
        public string BranchNo { get; set; }
        public string Reference { get; set; }
       
        public TransPay(string bankNo, string branchNo, string reference, decimal amount, DateTime date, string description, int no)
            : base(amount, date, description, no)
        {
            BankNo = bankNo;
            BranchNo = branchNo;
            Reference = reference;
        }
        public override string ToString()
        {
            return $"BankNo: {BankNo}\t BranchNo:{BranchNo}\t Reference: {Reference} {base.ToString()}";
        }
    }
}
