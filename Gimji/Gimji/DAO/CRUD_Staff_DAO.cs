using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gimji.DTO;
using Microsoft.Data.SqlClient;
namespace Gimji.DAO
{
    internal class CRUD_Staff_DAO : DatabaseAccess
    {
        // lay tat ca nhan vien _____________________________________________________________________________________________
        public List<Staff> getAllStaff_DAO()
        {
            List<Staff> staffList = new List<Staff>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from Nhan_vien ;";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff
                {
                    Id = row["id_nhan_vien"].ToString(),
                    userName = row["ten_dang_nhap"].ToString(),
                    userPassword = row["mat_khau"].ToString(),
                    fullName = row["ten_nhan_vien"].ToString(),
                    DateOfBirth = row["ngay_sinh"].ToString(),
                    Gender = row["gioi_tinh"].ToString(),
                    contactAddress = row["dia_chi"].ToString(),
                    phoneNumber = row["so_dien_thoai"].ToString(),
                    Email = row["email"].ToString(),
                    dateStart = row["ngay_bat_dau"].ToString(),
                    Salary = row.Field<double?>("muc_luong").HasValue ? row.Field<double>("muc_luong").ToString() : null ,
                    position = row["viTri"].ToString()
                };
                staffList.Add(staff);
            };

            return staffList;
        }
        // _____________________________________________________________________________________________
        // lay tat ca nhan vien _____________________________________________________________________________________________
        public Staff getStaffById_DAO(String StaffId)
        {
            Staff Staff = null; // Khởi tạo staff là null.
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Nhan_vien WHERE id_nhan_vien = '" + StaffId + "';";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                Staff = new Staff
                {
                    Id = row["id_nhan_vien"].ToString(),
                    userName = row["ten_dang_nhap"].ToString(),
                    userPassword = row["mat_khau"].ToString(),
                    fullName = row["ten_nhan_vien"].ToString(),
                    DateOfBirth = row["ngay_sinh"].ToString(),
                    Gender = row["gioi_tinh"].ToString(),
                    contactAddress = row["dia_chi"].ToString(),
                    phoneNumber = row["so_dien_thoai"].ToString(),
                    Email = row["email"].ToString(),
                    dateStart = row["ngay_bat_dau"].ToString(),
                    Salary = row.Field<double?>("muc_luong").HasValue ? row.Field<double>("muc_luong").ToString() : null,
                    position = row["viTri"].ToString()
                };
            };

            return Staff;
        }
        // _____________________________________________________________________________________________
        //Thêm 1 user _____________________________________________________________________________________________
        public void addStaff_DAO(Staff newStaff)
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
        //________________________________________________________________________________________________________________
        //Sua 1 user _____________________________________________________________________________________________

        public void UpdateStaff_DAO(Staff newStaff)
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
                String anotherSQL = "exec @proc @fullName,@emailAddress,@contactAddress,@userName,@userPassword ,@DateOfBirth , @phoneNumber , @position , @gender";
                SqlCommand anotherCmd = new SqlCommand(anotherSQL, conn);
                anotherCmd.Parameters.AddWithValue("@fullName", newStaff.fullName);
                anotherCmd.Parameters.AddWithValue("@emailAddress", newStaff.Email);
                anotherCmd.Parameters.AddWithValue("@contactAddress", newStaff.contactAddress);
                anotherCmd.Parameters.AddWithValue("@phoneNumber", newStaff.phoneNumber);
                anotherCmd.Parameters.AddWithValue("@userName", newStaff.userName);
                anotherCmd.Parameters.AddWithValue("@userPassword", newStaff.userPassword);
                anotherCmd.Parameters.AddWithValue("@gender" , newStaff.Gender);
                anotherCmd.Parameters.AddWithValue("@position", newStaff.position);
                anotherCmd.Parameters.AddWithValue("@DateOfBirth", newStaff.DateOfBirth);
                anotherCmd.Parameters.AddWithValue("@proc", "InsertStaffLoginData");
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
        //________________________________________________________________________________________________________________

        //Xóa 1 user _______________________________________________________________________________________________

        public void deleteStaff_DAO(String id)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM Nhan_vien WHERE id_nhan_vien = @id";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        //________________________________________________________________________________________________________________
        public DataTable search_DAO(String key, String cn)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (cn.Equals("null") || key.Equals("null"))
            {
                String sSQL = "select * from LoginData";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                String sSQL = "select distinct LoginData.*,UserAddress.storeID from LoginData,UserAddress  Where (fullName like '%" + key + "%' or fullName like '" + key + "%') and UserAddress.storeID = '" + cn + "'and LoginData.userID= UserAddress.userID  ";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
    }
}
