using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
	internal class Customer
	{
		public int	Id { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string fullName { get; set; }
		public string DateOfBirth { get; set; }
		public string Gender { get; set; }

		public string phoneNumsber { get; set; }
		public string contactAddress { get; set; }
		public string Email { get; set; }
		public string Point { get; set; }

		public string Type { get; set; }




	}
}
