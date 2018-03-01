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
    public partial class NalogVozilo : Form
    {
        Vozilo voz = new Vozilo();
        private SqlConnection con = BazaPodataka.veza;

        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        #region Load

        public NalogVozilo()
        {
            InitializeComponent();
            this.ime_vlasnikaTextBox.Text = voz.ime;            //ako se vratimo iz sljedece forme, auto-filla sve podatke od zadnjeg izabranog voliza
            this.prezime_vlasnikaTextBox.Text = voz.prezime;
            this.kontaktTextBox.Text = voz.kontakt;
            this.voziloTextBox.Text = voz.naziv_vozila;
            this.registracijaTextBox.Text = voz.registracija;
        }

        private void NalogVozilo_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet.Vozila' table. You can move, or remove it, as needed.
            this.vozilaTableAdapter.Fill(this.bazaPodatakaDataSet.Vozila);
            this.ime_vlasnikaTextBox.Text = "";            //ako se vratimo iz sljedece forme, auto-filla sve podatke od zadnjeg izabranog voliza
            this.prezime_vlasnikaTextBox.Text = "";
            this.kontaktTextBox.Text = "";
            this.voziloTextBox.Text = "";
            this.registracijaTextBox.Text = "";
            this.CenterToScreen();
            this.Top = this.Location.Y - 100;
            this.vozilaDataGridView.ReadOnly = true;
            Osvjezi();
        }

        #endregion
                
        #region Buttoni

        // Button 'Dalje'
        private void button1_Click(object sender, EventArgs e) //gumb dalje, dodati 
        {
            if (provjera() == false) return;

            this.Hide();
            NalogZaposlenik rad = new NalogZaposlenik(voz);
            rad.ShowDialog();
            if (rad.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Dispose();
            }            
        }

        #endregion

        #region DataGrid eventi

        private void vozilaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.vozilaDataGridView.Rows[e.RowIndex];

                this.ime_vlasnikaTextBox.Text = row.Cells[1].Value.ToString();
                this.prezime_vlasnikaTextBox.Text = row.Cells[2].Value.ToString();
                this.kontaktTextBox.Text = row.Cells[3].Value.ToString();
                this.voziloTextBox.Text = row.Cells[4].Value.ToString();
                this.registracijaTextBox.Text = row.Cells[5].Value.ToString();

                voz = new Vozilo(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                Console.WriteLine(voz);
            }
        }

        private void vozilaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        #endregion

        #region Pomoćne funkcije

        private void Osvjezi()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM Vozila;";
            // Provjeravamo u consoli kako glasi sql upit
            Console.WriteLine(cmd.CommandText);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.vozilaDataGridView.DataSource = dtbl;
            con.Close();
        }

        private bool provjera() {
            if(this.registracijaTextBox.Text == "" && this.voziloTextBox.Text == "") {
                MessageBox.Show("Molimo upišite potrebne podatke\n(Vozilo ili Registraciju).");
                return false;
            }
            return true;
        }

        #endregion

        private void vozilaBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.vozilaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaPodatakaDataSet);
        }
    }
}
