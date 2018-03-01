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
    public partial class FormaServisa : Form
    {
        Vozilo voz;  //pamtimo vozilo za koje radimo radni nalog
        Zaposlenik zap;
        private SqlConnection con = BazaPodataka.veza;

        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        #region Load

        public FormaServisa()
        {
            InitializeComponent();
        }

        private void FormaServisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet.Servis' table. You can move, or remove it, as needed.
            //this.servisTableAdapter.Fill(this.bazaPodatakaDataSet.Servis
            this.CenterToScreen();
            this.Top = this.Location.Y - 100;
            Osvjezi();
        }

        #endregion

        #region Buttoni

        //novi servis
        private void button2_Click(object sender, EventArgs e) {           
            this.Hide();
            NalogVozilo NV = new NalogVozilo();
            NV.ShowDialog();
            Osvjezi();
        }

        #endregion

        #region Pomoćne funkcije

        public void Osvjezi()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;   // Servis tablica se sastoji od 
            cmd.CommandText = "SELECT Servis.Id, [Ime vlasnika]+' '+[Prezime vlasnika] as Vlasnik, kontakt as Kontakt ,Ime+' '+Prezime as Radnik, [Opis posla], Cijena, Obavljeno, CONVERT(char(10), Datum,126) as Datum" +
                               " FROM Servis, Vozila, Zaposlenici " +
                               " WHERE Servis.Id_vozila=Vozila.Id And Id_zaposlenika=Zaposlenici.Id ;";

            Console.WriteLine(cmd.CommandText);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.dataGridView2.DataSource = dtbl;
            this.dataGridView2.ReadOnly = true;
            con.Close();
        }

        #endregion

        private void vozilaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vozilaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaPodatakaDataSet);
        }

        private void vozilaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vozilaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaPodatakaDataSet);
        }        
    }
}
