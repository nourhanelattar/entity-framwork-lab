using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   
   public class country
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("country")]
        public List<city> cities { get; set; }
    }
}
