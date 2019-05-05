using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
   public class Cover
    {
        public int Id { get; set; }
        public string code { get; set; }
        public Book Book { get; set; }
    }
}
