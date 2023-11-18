using Gimji.DAO;
using Gimji.DTO;
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
            Application.Run(new Main_Form_LoginRegister());
        }
    }
}