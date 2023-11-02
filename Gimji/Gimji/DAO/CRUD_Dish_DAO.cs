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
    internal class CRUD_Dish : DatabaseAccess
    {

        public DataTable Dish_Data(Dish dish)
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
            return dt;
        }
    }
}
