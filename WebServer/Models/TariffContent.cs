using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class TariffContent
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public string Text { get; set; }

        public string Jurisdiction { get; set; }

        public string Tariff { get; set; }
        public string PaymentType { get; set; }
        public string MeterType { get; set; }

    }
}
