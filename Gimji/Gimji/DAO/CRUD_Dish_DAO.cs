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

        // Lấy Tất Cả Các Món Ăn ra________________________________________________________________________
        public List<Dish> GetAllDish()
        {
            List<Dish> listDish = new List<Dish>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Mon_an;";
            SqlDataAdapter da = new SqlDataAdapter(sSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Dish dish = new Dish
                    {
                        DishId = Convert.ToInt32(row["id_mon_an"]),
                        DishName = row["ten_mon_an"].ToString(),
                        DishPrice = Convert.ToDouble(row["don_gia"]),
                        DishPicture = row["hinh_anh"].ToString(),
                        Dish_Availible = row["tinh_trang"].ToString(),
                        Catergory_Id = Convert.ToInt32(row["id_danh_muc"])
                    };
                    listDish.Add(dish);
                }
            }

            return listDish;
        }
        // _______________________________________________________________________________________________________
        public void addDish_DAO(Dish newDish) {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sSQL = @"
                SELECT ten_mon_an, don_gia, hinh_anh , tinh_trang , id_danh_muc,  FROM Mon_an
            ";
            SqlDataAdapter da = new SqlDataAdapter(sSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0)
            {
                string insertSql = @"
                INSERT INTO Mon_an (ten_mon_an, don_gia, hinh_anh, tinh_trang, id_danh_muc)
                VALUES (@TenMonAn, @DonGia, @HinhAnh, @TinhTrang, @IdDanhMuc)
                ";
                SqlCommand cmd = new SqlCommand(insertSql, conn);
                cmd.Parameters.AddWithValue("@TenMonAn", newDish.DishName);
                cmd.Parameters.AddWithValue("@DonGia", newDish.DishPrice);
                cmd.Parameters.AddWithValue("@HinhAnh", newDish.DishPicture);
                cmd.Parameters.AddWithValue("@TinhTrang", newDish.Dish_Availible);
                cmd.Parameters.AddWithValue("@IdDanhMuc", newDish.Catergory_Id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("   Thêm Thực Đơn Thành Công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("   Thêm Thực Đơn không Thành Công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
