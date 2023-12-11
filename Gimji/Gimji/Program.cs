using Gimji.DAO;
using Gimji.DTO;
using Gimji.GUI.Login_Register;
using Microsoft.Data.SqlClient;

namespace Gimji
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());
        }
    }
}