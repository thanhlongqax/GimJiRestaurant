using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DTO
{
    internal class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public float DishPrice { get; set;}
        public string DishPicture { get; set;}
        public string DishNote { get; set; }

    }
}
