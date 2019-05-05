using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   public class city
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int countryId { get; set; }
        public country country { get; set; }
        public List<uservisit> uservisit { get; set; }
        public Book Book { get; set; }



    }
}
