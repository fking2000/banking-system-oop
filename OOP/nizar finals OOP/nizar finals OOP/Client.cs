using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class Client
    {
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }


        private List<Project> Projects { get; set; }

        public Client(string address, string firstName, string id, string lastName)
        {
            Address = address;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            Projects = new List<Project>();
        }

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }
        public string Report()
        {
            string projects = "";
            foreach (var project in Projects)
            {
               projects += project.GetPrintString() + "\n";

            }

            return $"{FirstName}\t{LastName}\t{Id}\t{Address}\n{projects}\n";
        }

    }
}
    

