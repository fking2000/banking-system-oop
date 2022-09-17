using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {/*Firas Khory id:314814096*/
            Client client = new Client("haifa", "firas", "314814096", "khory");
            
            Project project = new Project(10000, "hard projs", "king", 10);
            client.AddProject(project);
            project.CheckPay(10, "for health", 100, DateTime.Now, "01", "600", "1",DateTime.Parse("10/10/2121"));
            project.TransPay(10, "for life", 400, DateTime.Now, "firas khory", "600", "10");
            project.AddTask(new Task("for class",false,1));  
           Console.WriteLine( client.Report());
            project.MarkTaskDone(1,true);
            project.MarkTaskDone(5, true);
            
            Console.WriteLine( client.Report());
           // Console.Read();
        }
    }
}
