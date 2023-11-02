using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gimji.DAO;
using Gimji.DTO;

namespace Gimji.BLL
{
    internal class CRUD_Dish_BLL
    {
        CRUD_Dish_DAO CRUD_Dish_DAO = new CRUD_Dish_DAO();  
        public Dish getAllDish() {
            return CRUD_Dish_DAO.Dish_Data();
        }
    }
}
