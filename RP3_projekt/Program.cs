using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RP3_projekt
{
    public static class BazaPodataka {

        // OVDJE PROMIJENITI DIREKTORIJ!
        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        public static SqlConnection veza = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marko\Documents\GitHub\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

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
            Application.Run(new PocetnaForma());
        }
    }
}
