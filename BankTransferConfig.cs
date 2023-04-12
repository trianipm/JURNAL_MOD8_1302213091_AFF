using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newston.Js;

namespace JURNAL_MOD8_1302213091_AFF
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public string[] methods { get; set; }
        public string confirmation { get; set; }
        public string konfirmasi { get; set; }
        public static BankTransferConfig LoadConfig()
        {
            var file = "C:\\Users\\Asus\\Documents\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\JURNAL_MOD8_1302213091_AFF\\JURNAL_MOD8_1302213091_AFF\\bank_transfer_config.json";
            if (!File.Exists(file))
            {
                return new BankTransferConfig
                {
                    lang = "en",
                    threshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000,
                    methods = new string[] { "RTO", "SKN", "RTGS", "BI FAST" },
                    confirmation = "yes",
                    konfirmasi = "ya"
                };
            }
            var json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<BankTransferConfig>(json);
        }
    }
}
