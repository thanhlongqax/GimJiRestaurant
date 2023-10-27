using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
    internal class Voucher
    {
        public int voucherId { get; set; }
        public string voucherName { get; set; }
        public string voucherDescription { get; set;}
        public string voucherCondition { get; set;}
        public string voucherDateTimeIn { get; set;}
        public string voucherDateTimeOut { get; set;}
    }
}
