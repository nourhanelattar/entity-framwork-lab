using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   public class Department
    {
        public int Dept_Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
