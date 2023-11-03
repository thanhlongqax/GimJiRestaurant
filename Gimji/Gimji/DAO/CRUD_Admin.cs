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
    internal class CRUD_Admin : DatabaseAccess
    {
        public void UpdateAdmin_DAO(Staff newStaff)
        {


            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from Nhan_vien where ten_dang_nhap = @userName";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userName", newStaff.userName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("add Staff :" + newStaff.fullName);
                String anotherSQL = "exec @proc @fullName,@emailAddress,@contactAddress,@userName,@userPassword ,@DateOfBirth , @phoneNumber";
                SqlCommand anotherCmd = new SqlCommand(anotherSQL, conn);
                anotherCmd.Parameters.AddWithValue("@fullName", newStaff.fullName);
                anotherCmd.Parameters.AddWithValue("@emailAddress", newStaff.Email);
                anotherCmd.Parameters.AddWithValue("@contactAddress", newStaff.contactAddress);
                anotherCmd.Parameters.AddWithValue("@phoneNumber", newStaff.phoneNumber);
                anotherCmd.Parameters.AddWithValue("@userName", newStaff.userName);
                anotherCmd.Parameters.AddWithValue("@userPassword", newStaff.userPassword);
                cmd.Parameters.AddWithValue("@proc", "InsertStaffLoginData");
                anotherCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("    Thêm Tài Khoản Nhân Viên Thành Công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                conn.Close();
                MessageBox.Show("Tài khoản đã được đăng ký trước đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
