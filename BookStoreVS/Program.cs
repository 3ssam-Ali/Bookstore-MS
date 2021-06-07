using System;
using System.Windows.Forms;

namespace BookStoreVS
{
    public static class Preload
    {
        //will contain most-used and global variables
        public static bool isAdmin = false;
        public static string User;
    }
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
    }
}
