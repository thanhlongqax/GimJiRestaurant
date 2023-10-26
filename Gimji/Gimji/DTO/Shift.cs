using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
	internal class Shift
	{
		public int shiftID { get; set; }
		public string shiftName { get; set; }
		public DateTime dateTimeIn { get; set; }
		public DateTime dateTimeOut { get; set; }

	}
	
}
