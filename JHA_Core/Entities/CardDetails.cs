using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Core.Entities
{
    public class CardDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }
        
        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public int  CVV { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
