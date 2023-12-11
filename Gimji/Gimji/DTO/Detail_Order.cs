using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
    internal class Detail_Order
    {
        public int Id { get; set; }
        public int HoaDonId { get; set; }
        public int MonAnId { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public int PhuongThucThanhToanId { get; set; }
    }
}
