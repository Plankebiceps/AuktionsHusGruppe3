using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Windows_Presentation_Foundation_Test1
{
    class Employee
    {
        public Employee()
        {
            Name = "Planke" +
                   "Madsen";
        }
        public Employee(String name)
        {
            Name = name;
        }
        public String Name;
    }
}
