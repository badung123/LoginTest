using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelCoTestLogin.Entities
{
    public class CardDetails
    {
        public string Company { get; set; }
        public string SerialNumber { get; set; }
        public int CardValue { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public int TransactionBefore { get; set; }
        public int Success { get; set; }
        public string Description { get; set; }
    }
}
