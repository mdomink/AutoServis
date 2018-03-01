using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RP3_projekt
{
    public partial class Nalozi : Form
    {
        Zaposlenik radnik = new Zaposlenik();
        int id_nalog;
        private SqlConnection con = BazaPodataka.veza;

        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        #region Load

        public Nalozi(Zaposlenik zap)
        {
            InitializeComponent();
            radnik = zap;
        }

        private void Nalozi_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        #endregion

        #region Buttoni

        // Button 'Izvrši'
        private void button1_Click(object sender, EventArgs e)
        {

           /* var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\marko\Documents\GitHub\AutoServis\Nalozi.png");
            }*/

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Servis SET Obavljeno=1 WHERE Id='" + id_nalog + "';";
            try
            {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Odabrani nalog je promijenjen.");
                // TODO: Cancel button (možda)
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            con.Close();
            Osvjezi();
        }

        #endregion

        #region DataGrid eventi

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id_nalog = 0;
                try {
                    id_nalog = Int32.Parse(row.Cells[0].Value.ToString());
                }catch(Exception ec) {
                    Console.WriteLine(ec.Message);
                }
                Console.WriteLine("Id=" + id_nalog);
            }
        }

        #endregion

        #region Pomoćne funkcije

        private void Osvjezi()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;   // Servis tablica se sastoji od 
            cmd.CommandText = "SELECT Servis.Id, [Ime vlasnika]+' '+[Prezime vlasnika] as Vlasnik, kontakt as Kontakt , [Opis posla], Cijena, Obavljeno, CONVERT(char(10), Datum,126) as Datum" +
                               " FROM Servis, Vozila " +
                               " WHERE  Id_vozila=Vozila.Id And Id_zaposlenika=" + radnik.id + " And Obavljeno=0 ;";

            Console.WriteLine(cmd.CommandText);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.dataGridView1.DataSource = dtbl;
            this.dataGridView1.ReadOnly = true;
            con.Close();
        }

        #endregion
    }
}
