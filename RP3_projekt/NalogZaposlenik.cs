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
    public partial class NalogZaposlenik : Form
    {
        Vozilo voz = new Vozilo();
        Zaposlenik radnik;
        private SqlConnection con = BazaPodataka.veza;

        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        #region Load

        public NalogZaposlenik(Vozilo v)
        {
            voz = v;
            InitializeComponent();
        }        

        private void NalogZaposlenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.bazaPodatakaDataSet.Zaposlenici);
            this.CenterToScreen();
            this.Top = this.Location.Y - 100;
            this.zaposleniciDataGridView.ReadOnly = true;

            // Očisti textBox-ove
            this.imeTextBox.Text = "";
            this.prezimeTextBox.Text = "";

            Osvjezi();
        }

        #endregion

        #region Buttoni

        //button Dalje
        //salje dosadasnje vozilo i zaposenika u formu NalogRadov
        private void button2_Click(object sender, EventArgs e)
        {
            if(this.imeTextBox.Text == "" || this.prezimeTextBox.Text == "") {
                MessageBox.Show("Molimo upišite ime i prezime zaposlenika.");
                return;
            }           

            this.Hide();
            NalogRadov rad = new NalogRadov(voz,radnik);
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

        //button back, vraca na fromu NalogVozilo
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region DataGrid eventi

        private void zaposleniciDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.zaposleniciDataGridView.Rows[e.RowIndex];

                this.imeTextBox.Text = row.Cells[1].Value.ToString();
                this.prezimeTextBox.Text = row.Cells[2].Value.ToString();

                radnik = new Zaposlenik(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                Console.WriteLine(radnik.ToString());
            }
        }

        #endregion

        #region Pomoćne funkcije

        private void Osvjezi()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM Zaposlenici;";
            // Provjeravamo u consoli kako glasi sql upit
            Console.WriteLine(cmd.CommandText);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.zaposleniciDataGridView.DataSource = dtbl;
            con.Close();
        }

        #endregion

        private void zaposleniciBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.zaposleniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaPodatakaDataSet);
        }
    }
}
