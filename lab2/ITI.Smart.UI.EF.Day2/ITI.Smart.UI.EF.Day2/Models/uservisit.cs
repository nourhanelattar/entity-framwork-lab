using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Day2.Models
{
    [Table("uservisits")]
   public class uservisit
    {
        public DateTime when { get; set; }
        [Key]
        [ForeignKey("user")]
        [Column(Order =1)]
        public int Fk_userId { get; set; }

        [Key]
        [ForeignKey("city")]
        [Column(Order = 2)]
        public int Fk_cityId { get; set; }
        public city city { get; set; }
        public user user { get; set; }
    }
}
