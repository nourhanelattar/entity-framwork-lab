using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
        public int FK_DepartmentId { get; set; }
        public List<Book> Books { get; set; }

    }
}
