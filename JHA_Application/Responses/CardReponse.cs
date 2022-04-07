using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Application.Responses
{

    public class CardResponse
    {
        public int CardId { get; set; }

        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public int CVV { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}