using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Gimji.DTO;

namespace Gimji.DAO
{
    internal class LoginDAO :DatabaseAccess
    {


        public  string LoginDAO_checkLoginData(User tk)
        {
            Dictionary<int, string> result = checkLoginData_Database(tk);
            String userName = null;
            if (result.Count == 0)
            {
                MessageBox.Show("Mật khẩu không chính xác hoặc tài khoản không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Trả về giá trị null hoặc giá trị phù hợp tùy vào logic của bạn.
            }
            // Xử lý các trường hợp khác ở đây.
            foreach (KeyValuePair<int, string> item in result)
            {
                  userName = item.Value;
            }
            return userName;
        }
        public string signUp_Login_DAO(User newUser)
        {
            return signUp_DAO(newUser);
        }
        /*public DataTable populateInformationUser_Login_DAL(string userID)
        {
            if (populateInformationUser_DA_DAL(userID) == null)
            {
                return null;
            }
            else
            {
                return populateInformationUser_DA_DAL(userID);
            }
        }
        public DataTable populateProvince_Login_DAL()
        {
            if (populateProvince_DA_DAL() == null)
            {
                return null;
            }
            else
            {
                return populateProvince_DA_DAL();
            }
        }*/
    }
}
