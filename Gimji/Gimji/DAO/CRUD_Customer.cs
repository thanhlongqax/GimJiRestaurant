using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gimji.DTO;
using Microsoft.Data.SqlClient;
namespace Gimji.DAO
{
    internal class CRUD_Customer : DatabaseAccess
    {

        /*public DataTable getAllUser_DAO()
        {
            return getAllUser_DA_DAOL();
        }
        public DataTable searchUser_DAL(String key, String cn)
        {
            return searchUser_DA_BLL(key, cn);
        }
        public void deleteUser_DAL(String id)
        {
            deleteUser_DA_BLL(id);
        }
        public void updateUser_DAL(User user)
        {
            updateUser_DA_BLL(user);
        }
        public void addUser_DAL(User user, String cn)
        {
            addUser_DA_BLL(user, cn);
        }
        public String getIdByUsername_DAL(String name)
        {
            return getIdByUsername_DA_DAL(name);
        }
        public DataTable getUserByID(String id)
        {
            return getUserById_DA_DAL(id);
        }
        public DataTable getUserOfStore_DAL(String key)
        {
            return getAllUserOfStore_DA_DAL(key);
        }*/
        //Thêm 1 user _____________________________________________________________________________________________
        /*public void addUser_DA_DAO(Customer user, String cn)
        {
            MessageBox.Show("add user :" + user.fullName);
            SqlConnection conn = new SqlConnection(strConn);
            String sSQL = "exec @proc @fullName,@emailAddress,@contactAddress,@userName,@userPassword ,@DateOfBirth , @phoneNumber";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@fullName", user.fullName);
            cmd.Parameters.AddWithValue("@emailAddress", user.Email);
            cmd.Parameters.AddWithValue("@contactAddress", user.contactAddress);
            cmd.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
            cmd.Parameters.AddWithValue("@userName", user.CustomerName);
            cmd.Parameters.AddWithValue("@userPassword", user.CustomerPassword);
            conn.Open();
            if (cn[0] == 'M')
            {
                cmd.Parameters.AddWithValue("@proc", "InsertStaffLoginData");
                try
                {
                    cmd.ExecuteNonQuery();
                    String sSQL2 = "insert into UserAddress values(@userID,(Select UserAddress.storeID from UserAddress where UserAddress.userID=@managerID))";
                    SqlCommand cmd2 = new SqlCommand(sSQL2, conn);
                    cmd2.Parameters.AddWithValue("@userID", getIdByUsername_DAO(user.CustomerName));
                    cmd2.Parameters.AddWithValue("@managerID", cn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            }
            else
            {
                String sSQL2 = "Insert into UserAddress values(@userID,@storeID)";
                SqlCommand cmd2 = new SqlCommand(sSQL2, conn);
                cmd2.Parameters.AddWithValue("@storeID", cn);
                try
                {
                    if (user.typeOfAccount.Equals("user"))
                    {
                        cmd.Parameters.AddWithValue("@proc", "InsertUserLoginData");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfuly");
                    }
                    else if (user.typeOfAccount.Equals("admin"))
                    {
                        cmd.Parameters.AddWithValue("@proc", "InsertAdminLoginData");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfuly");
                    }
                    else if (user.typeOfAccount.Equals("staff"))
                    {
                        cmd.Parameters.AddWithValue("@proc", "InsertStaffLoginData");
                        cmd.ExecuteNonQuery();
                        cmd2.Parameters.AddWithValue("@userID", getIdByUsername_DAO(user.CustomerName));
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Successfuly");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@proc", "InsertManagerLoginData");
                        cmd.ExecuteNonQuery();
                        cmd2.Parameters.AddWithValue("@userID", getIdByUsername_DAO(user.CustomerName));
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Successfuly");
                    }
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            }
            conn.Close();
        }*/
        //________________________________________________________________________________________________________________
    }
}
