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
    public partial class FormaZaposlenici : Form
    {
        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        private SqlConnection con = BazaPodataka.veza;
        Zaposlenik radnik = new Zaposlenik();

        #region Load

        public FormaZaposlenici()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet2.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter2.Fill(this.bazaPodatakaDataSet2.Zaposlenici);
            this.CenterToScreen();
            this.Top = this.Location.Y - 100;

            // Počisti text box-ove
            obrisiTextBox();

            // Ako ovdje dodamo poziv Osvjezi(), tada se klikom na redak u tablici ne osvježe podaci u textbox-ovima na lijevoj strani
            // Ako ne dodamo poziv Osvjezi(), tada ne radi kako treba
            Osvjezi();
        }

        #endregion

        #region Buttoni

        // Button 'Spremi'
        private void button3_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;           

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Zaposlenici VALUES('" + this.imeTextBox2.Text + "','" + this.prezimeTextBox2.Text + "','" + this.adresaTextBox.Text + "','" + this.broj_mobitelaTextBox.Text + "');";        
            try {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Upisani podaci su spremljeni.");
            } catch(Exception ec) {
                Console.WriteLine(ec.Message);
            }
            con.Close();
            Osvjezi();
        }

        // Button 'Izbriši'
        private void button2_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from Zaposlenici WHERE Ime='" + this.imeTextBox2.Text + "' and Prezime='" + this.prezimeTextBox2.Text + "';";
            try {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Odabrani podatak je izbrisan.");
                // TODO: Cancel button (možda)
            } catch(Exception ec) {
                Console.WriteLine(ec.Message);
            }
            con.Close();
            Osvjezi();
        }

        // Button 'Radni nalozi'
        // Pretraži tablicu Servis, i ispiši sve poslove koje odabrani zaposlenik treba obaviti
        private void button4_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT Id FROM Zaposlenici WHERE Ime='" + this.imeTextBox2.Text + "' AND Prezime='" + this.prezimeTextBox2.Text + "';";
            // Provjeravamo u consoli kako glasi sql upit
            Console.WriteLine(cmd.CommandText);
            
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // Output upita stavi u StringBuilder izlaz 
            // Samo je jedan redak kao output, i sadrži samo Id_Zaposlenika
            StringBuilder izlaz = new StringBuilder();
            foreach (DataRow rows in dtbl.Rows)
                foreach (DataColumn col in dtbl.Columns)
                    izlaz.AppendFormat("{0}", rows[col]);

            // Testiramo ID
            Console.WriteLine(izlaz);

            con.Close();

            // ----------------Drugi dio----------------

            con.Open();
            int ID = 0;

            // Prebaci ID u int (varijabla izlaz iz StringBuilder u String, pa zatim u int)
            // Ako ne možeš, izađi iz funkcije
            try {
                ID = Int32.Parse(izlaz.ToString());
            } catch(Exception ec) {
                Console.WriteLine(ec.Message);
                MessageBox.Show("Ne postoji traženi zaposlenik.");
                con.Close();
                return;
            }

            // Dohvati sve još neobavljene poslove
            cmd.CommandText = "SELECT [Opis posla] FROM Servis WHERE [Id_zaposlenika]=" + ID + " AND [Obavljeno]=0;";

            // Provjeravamo u consoli kako glasi sql upit
            Console.WriteLine(cmd.CommandText);

            sqlDa = new SqlDataAdapter(cmd);
            dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // Output upita stavi u StringBuilder izlaz
            // Varijabla koja šaljemo konstruktoru forme RadniNalog
            izlaz = new StringBuilder();

            string prvaLinija = "RADNI NALOG ZA ZAPOSLENIKA '" + this.imeTextBox2.Text.ToUpper() + " " + this.prezimeTextBox2.Text.ToUpper() + "'\n";
            prvaLinija += "------------------------------------------------------------------------------------";
            izlaz.AppendFormat("{0}\n", prvaLinija);

            foreach (DataRow rows in dtbl.Rows)
                foreach (DataColumn col in dtbl.Columns)
                    izlaz.AppendFormat("{0}\n", rows[col]);

            Console.WriteLine(izlaz);

            con.Close();

            // Otvori Radni nalog
            FormaRadniNalog form4 = new FormaRadniNalog(izlaz.ToString());
            form4.ShowDialog();
        }

        // Button 'Osvježi'
        private void button5_Click(object sender, EventArgs e) {
            Osvjezi();
        }

        // Button 'Odradi nalog'
        private void button6_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;
            Console.WriteLine(radnik.ToString());
            Nalozi nal = new Nalozi(radnik);
            nal.Show();
        }

        #endregion

        #region DataGrid Eventi

        private void zaposleniciDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.zaposleniciDataGridView1.Rows[e.RowIndex];

                this.imeTextBox2.Text = row.Cells[1].Value.ToString();
                this.prezimeTextBox2.Text = row.Cells[2].Value.ToString();
                this.adresaTextBox.Text = row.Cells[3].Value.ToString();
                this.broj_mobitelaTextBox.Text = row.Cells[4].Value.ToString();
                radnik = new Zaposlenik(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
            }
        }

        private void zaposleniciDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            Console.WriteLine("Click");
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.zaposleniciDataGridView1.Rows[e.RowIndex];

                this.imeTextBox2.Text = row.Cells[1].Value.ToString();
                this.prezimeTextBox2.Text = row.Cells[2].Value.ToString();
                this.adresaTextBox.Text = row.Cells[3].Value.ToString();
                this.broj_mobitelaTextBox.Text = row.Cells[4].Value.ToString();
                radnik = new Zaposlenik(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
            }
        }

        #endregion

        #region Pomoćne funkcije

        // Refresha tablicu - ispisuje sve
        private void Osvjezi() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM Zaposlenici;";
            // Provjeravamo u consoli kako glasi sql upit
            Console.WriteLine(cmd.CommandText);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.zaposleniciDataGridView1.DataSource = dtbl;
            this.zaposleniciDataGridView1.ReadOnly = true;
            obrisiTextBox();
            con.Close();
        }
                
        private void obrisiTextBox() {
            this.imeTextBox2.Text = "";
            this.prezimeTextBox2.Text = "";
            this.adresaTextBox.Text = "";
            this.broj_mobitelaTextBox.Text = "";
        }

        // Provjeri je li upisano ime i prezime zaposlenika
        private bool provjera() {
            if (this.imeTextBox2.Text == "" || this.prezimeTextBox2.Text == "") {
                MessageBox.Show("Molimo upišite ime i prezime zaposlenika.");
                return false;
            }
            return true;
        }

        #endregion

        #region TextBox

        private void imeTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                prezimeTextBox2.Focus();
            }
            
        }

        private void prezimeTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adresaTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }                
        }

        private void adresaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                broj_mobitelaTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
                
        }

        #endregion
    }
}
