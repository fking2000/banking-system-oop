using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class Project
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int No { get; set; }
       private List<Task> Tasks { set; get; }
       private List<Payment> Payments { set; get; }
       
        public Project(decimal amount, string description, string name, int no)
        {
            Amount = amount;
            Description = description;
            Name = name;
            No = no;
            Payments = new List<Payment>();
            Tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public void CheckPay(int no, string description,
        decimal amount, DateTime date, string checkNo,
        string bankNo, string branchNo, DateTime checkDate)
        {
if (amount > Debt())
            {
                Console.WriteLine("the payment was not successful");

            }
            else { 
         Payments.Add( new CheckPay(bankNo, branchNo, checkDate, checkNo, amount, date, description, no));
            }
        }
        public decimal Debt()   
        {
            decimal sum = 0;
            foreach(var pay in Payments)
            {
                sum+=pay.Amount;
            }
            return Amount - sum;
           
        }
        public string GetPrintString()
        {
            string stringtask = "Tasks:\n ";
            string stringpayment = "Payments:\n";
            foreach (var task in Tasks)
                stringtask += task.ToString() + "\n";
            foreach (var payment in Payments)
                stringpayment += payment.ToString() + "\n";

            return $"Project Name:{Name}\n{stringtask}" +
                   $"\n{stringpayment}\n" +
                   $"\n The Debt:{Debt()}\n___________________________________";
        }
        public void TransPay(int no, string description,
        decimal amount, DateTime date, string reference,
        string bankNo, string branchNo)
        {
            if (amount > Debt())
            {
                Console.WriteLine("the payment was not successful");

            }
            else
            {
               Payments.Add( new TransPay(bankNo, branchNo, reference, amount, date, description, no));
            }

            }
        public void MarkTaskDone(int no, bool done)
        { foreach (var task in Tasks)
            {
                if (task.No == no)
                {
                    task.Done = done;
                    Console.WriteLine("marked done!!\n");
                }
                else
                {
                    Console.WriteLine("could not find the task\n");
                }
            }
        

        
}
        }


    }

