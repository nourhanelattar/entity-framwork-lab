using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<uservisit> uservisit { get; set; }
    }
}
 