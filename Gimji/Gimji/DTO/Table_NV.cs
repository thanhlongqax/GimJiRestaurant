using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
    internal class Table_NV
    {
        public int TableId { get; set; }
        public string CustomerName { get; set; }
        public string StaffId { get; set; }
        public string Note { get; set; }
        public DateTime Date_Table_Set { get; set; }
    }
}
