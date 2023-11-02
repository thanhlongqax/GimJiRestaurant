using Gimji.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimji.DAO
{
    internal class CRUD_Dish_DAO : DatabaseAccess
    {

        public Dish Dish_Data()
        {

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sSQL = @"
                SELECT ten_mon_an, don_gia, hinh_anh , tinh_trang , id_danh_muc,  FROM Mon_an
            ";
            SqlDataAdapter da = new SqlDataAdapter(sSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            // Kiểm tra xem có dữ liệu trong DataTable không
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Dish dish = new Dish();
                {
                    dish.DishName = row["ten_mon_an"].ToString();

                    dish.DishPrice = Convert.ToSingle(row["don_gia"]);

                    dish.DishPicture = row["hinh_anh"].ToString();

                    dish.Dish_Availible = row["tinh_trang"].ToString();

                    dish.Catergory_Id = Convert.ToInt32(row["id_danh_muc"]);
                };

                return dish;
            }
            else
            {
                // Trả về null hoặc giá trị mặc định tùy theo trường hợp
                return null;
            }

        }
    }
}
