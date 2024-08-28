using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay3CSharpAdvanced
{
    internal class Company
    {
        public string? Name { get; private set; }
        public float Budget { get; private set; }
        private  List<Employee> employees { get; set; }

        public Company(string name , float  budget , List<Employee> employees)
        {
            Name = name;
            Budget = budget;
            this.employees = employees;

        }

    }
}
