using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizar_finals_OOP
{
    public class Task
    {
        public string Description { get; set; }
        public bool Done { get; set; }
        public int No { get; set; }
        public Task(string description, bool done, int no)
        {
            Description = description;
            Done = done;
            No = no;
        }

        public override string ToString()
        {
            return $"Description:{Description}\t Done:{Done}\t No: {No}";
        }
    }
}
