using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Models
{
    internal class Exercise
    {
        private string name;
        private string description;
        public Exercise(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
