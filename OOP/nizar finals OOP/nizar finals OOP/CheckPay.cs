using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class CheckPay:Payment
    {
        public string BankNo { get; set; }
        public string BranchNo { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckNo { get; set; }


        public CheckPay(string bankNo, string branchNo, DateTime checkDate, string checkNo,decimal amount, DateTime date, string description, int no) 
            :base( amount, date, description, no)
        {
            BankNo = bankNo;
            BranchNo = branchNo;
            CheckDate = checkDate;
            CheckNo = checkNo;
          
        }
        public override string ToString()
        {
            return $"BankNo: {BankNo}\t BranchNo:{BranchNo}\t CheckDate:{CheckDate} CheckNo: {CheckNo} {base.ToString()}";
        }
    }
}
