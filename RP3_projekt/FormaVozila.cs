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
    public partial class FormaVozila : Form
    {
        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\Servis\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");

        private SqlConnection con = BazaPodataka.veza;
        StringBuilder izlaz = new StringBuilder();
        Vozilo v = new Vozilo();
        String format = "yyyy-MM-dd";

        #region Load

        public FormaVozila()
        {
            InitializeComponent();
        }

        private void FormaVozila_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet1.Vozila' table. You can move, or remove it, as needed.
            this.vozilaTableAdapter.Fill(this.bazaPodatakaDataSet.Vozila);
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;           

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Vozila VALUES('" + this.ime_vlasnikaTextBox.Text + "','" + this.prezime_vlasnikaTextBox.Text + "'," +
                                                         "'" + this.kontaktTextBox.Text + "','" + this.voziloTextBox.Text + "','" + this.registracijaTextBox.Text + "');";

            try
            {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Upisani podaci su spremljeni.");
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            con.Close();
            Osvjezi();
        }

        // Button 'Pretraži' (slično možemo ubaciti i za tablicu Zaposlenici)
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            bool ubacenUvjet = false;

            cmd.CommandText = "SELECT * FROM Vozila";

            #region Upisani uvjeti

            if (this.ime_vlasnikaTextBox.Text != "")
            {
                if (ubacenUvjet == false)
                    cmd.CommandText += " WHERE ";
                else
                    cmd.CommandText += " AND ";
                // u uglate zagrade stavljati razdvojena imena naziva stupaca npr. [Ime vlasnika]
                cmd.CommandText = cmd.CommandText + "[Ime vlasnika]='" + this.ime_vlasnikaTextBox.Text + "'";
                ubacenUvjet = true;
            }

            if (this.prezime_vlasnikaTextBox.Text != "")
            {
                Console.WriteLine("prezime_vlasnikaTextBox = {0}", this.prezime_vlasnikaTextBox.Text);
                if (ubacenUvjet == false)
                    cmd.CommandText += " WHERE ";
                else
                    cmd.CommandText += " AND ";

                cmd.CommandText = cmd.CommandText + "[Prezime vlasnika]='" + this.prezime_vlasnikaTextBox.Text + "'";
                ubacenUvjet = true;
            }

            if (this.kontaktTextBox.Text != "")
            {
                Console.WriteLine("kontaktTextBox = {0}", this.kontaktTextBox.Text);
                if (ubacenUvjet == false)
                    cmd.CommandText += " WHERE ";
                else
                    cmd.CommandText += " AND ";

                cmd.CommandText = cmd.CommandText + "Kontakt='" + this.kontaktTextBox.Text + "'";
                ubacenUvjet = true;
            }

            if (this.voziloTextBox.Text != "")
            {
                if (ubacenUvjet == false)
                    cmd.CommandText += " WHERE ";
                else
                    cmd.CommandText += " AND ";

                cmd.CommandText = cmd.CommandText + "Vozilo='" + this.voziloTextBox.Text + "'";
                ubacenUvjet = true;
            }

            if (this.registracijaTextBox.Text != "")
            {
                if (ubacenUvjet == false)
                    cmd.CommandText += " WHERE ";
                else
                    cmd.CommandText += " AND ";

                cmd.CommandText = cmd.CommandText + "Registracija='" + this.registracijaTextBox.Text + "'";
                ubacenUvjet = true;
            }

            // Nije bitno više
            ubacenUvjet = true;

            #endregion

            // Završi naredbu
            cmd.CommandText += ";";

            con.Close();
            Osvjezi(cmd);         
          
        }

        // Button 'Osvježi'
        private void button3_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        // Button 'Izbriši'
        private void button4_Click(object sender, EventArgs e) {
            if (provjera() == false) return;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from Vozila WHERE [Ime vlasnika]='" + this.ime_vlasnikaTextBox.Text + "' and [Prezime vlasnika]='"
                            + this.prezime_vlasnikaTextBox.Text + "' and [Kontakt]='" + this.kontaktTextBox.Text + "' and [Vozilo]='" + this.voziloTextBox.Text +"';";
            try {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Odabrani podatak je izbrisan.");
                // TODO: Cancel button (možda)
            } catch (Exception ec) {
                Console.WriteLine(ec.Message);
            }
            con.Close();
            Osvjezi();
        }

        // Button 'Ispiši račun'
        private void button5_Click(object sender, EventArgs e)
        {
            if (provjera() == false) return;

            DateTime dan = DateTime.Today;
            // DateTime.TryParse(format,out dan);
            String datum = dan.ToString(format);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Servis.Id, [Ime vlasnika]+' '+[Prezime vlasnika] as Vlasnik, Vozilo, Registracija ,kontakt as Kontakt ,Ime+' '+Prezime as Radnik, [Opis posla], Cijena, Obavljeno, CONVERT(char(10), Datum,126)" +
                            " FROM Servis, Vozila, Zaposlenici " +
                            " WHERE Servis.Id_vozila=" + v.id + " And Vozila.Id=" + v.id + " And Id_zaposlenika=Zaposlenici.Id And Obavljeno=1;";
            try
            {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();            
            sqlDa.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
                MessageBox.Show("Trenutno nema gotovih servisa za traženo vozilo.");

            else
            {
                int ukupno = 0;

                izlaz = new StringBuilder();

                string prvaLinija = "Datum: " + datum;
                izlaz.AppendFormat("{0}\n", prvaLinija);
                DataRow row = dtbl.Rows[0];
                izlaz.AppendFormat("Vozilo: {0}\t Registarska oznaka: {1}\n", row["Vozilo"].ToString(), row["Registracija"].ToString());
                izlaz.AppendFormat("Vlasnik: {0}\t Kontakt: {1}\n", row["Vlasnik"].ToString(), row["Kontakt"].ToString());

                izlaz.AppendFormat("\n");

                izlaz.AppendFormat("{0,15}{1,50}{2,25}\n", "Radnik ", "Opis posla", "Cijena");
                izlaz.AppendFormat("{0,0}\n", "-------------------------------------------------------------------------------------------------------");
                foreach (DataRow rows in dtbl.Rows)
                {
                    brisi_servis(Int32.Parse(rows["Id"].ToString()));
                    izlaz.AppendFormat("{0,15}{1,50}{2,25}\n", rows["Radnik"], rows["Opis posla"], rows["Cijena"]);
                    ukupno += Int32.Parse(rows["Cijena"].ToString());
                }
                izlaz.AppendFormat("{0,0}\n", "------------------------------------------------------------------------------------------------------");
                izlaz.AppendFormat("{0,15}{1,50}{2,25}\n", "Ukupno ", " ", ukupno);

                Console.WriteLine(izlaz);

                FormaRadniNalog fr = new FormaRadniNalog(izlaz.ToString());
                fr.Show();
            }

            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\marko\Documents\GitHub\AutoServis\FormaVozila.png");
            }
            con.Close();
        }

        #endregion

        #region DataGrid Eventi

        private void vozilaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.vozilaDataGridView.Rows[e.RowIndex];

                this.ime_vlasnikaTextBox.Text = row.Cells[1].Value.ToString();
                this.prezime_vlasnikaTextBox.Text = row.Cells[2].Value.ToString();
                this.kontaktTextBox.Text = row.Cells[3].Value.ToString();
                this.voziloTextBox.Text = row.Cells[4].Value.ToString();
                this.registracijaTextBox.Text = row.Cells[5].Value.ToString();
                v = new Vozilo(Int32.Parse(row.Cells[0].Value.ToString()), this.ime_vlasnikaTextBox.Text, this.prezime_vlasnikaTextBox.Text,
                             this.kontaktTextBox.Text, this.voziloTextBox.Text, this.registracijaTextBox.Text);
            }
        }
        

        private void vozilaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Console.WriteLine("Click");
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.vozilaDataGridView.Rows[e.RowIndex];

                this.ime_vlasnikaTextBox.Text = row.Cells[1].Value.ToString();
                this.prezime_vlasnikaTextBox.Text = row.Cells[2].Value.ToString();
                this.kontaktTextBox.Text = row.Cells[3].Value.ToString();
                this.voziloTextBox.Text = row.Cells[4].Value.ToString();
                this.registracijaTextBox.Text = row.Cells[5].Value.ToString();
                v = new Vozilo(Int32.Parse(row.Cells[0].Value.ToString()), this.ime_vlasnikaTextBox.Text, this.prezime_vlasnikaTextBox.Text,
                             this.kontaktTextBox.Text, this.voziloTextBox.Text, this.registracijaTextBox.Text);
            }
        }

        #endregion

        #region Pomoćne funkcije

        // Refresha tablicu - ispisuje sve
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
            this.vozilaDataGridView.ReadOnly = true;
            obrisiTextBox();
            con.Close();
        }

        // Overload metode Osvjezi s parametrom
        // Refresha tablicu s zadanom naredbom
        private void Osvjezi(SqlCommand naredba)
        {
            con.Open();
            try
            {
                Console.WriteLine(naredba.CommandText);
                naredba.ExecuteNonQuery();
                //MessageBox.Show("Pretraživanje...");
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter(naredba);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            this.vozilaDataGridView.DataSource = dtbl;
            this.vozilaDataGridView.ReadOnly = true;
            obrisiTextBox();
            con.Close();
        }

        private void obrisiTextBox()
        {
            this.ime_vlasnikaTextBox.Text = "";
            this.prezime_vlasnikaTextBox.Text = "";
            this.kontaktTextBox.Text = "";
            this.voziloTextBox.Text = "";
            this.registracijaTextBox.Text = "";
        }

        // Provjeri jesu li upisani obavezni podaci
        private bool provjera() {
            if (this.ime_vlasnikaTextBox.Text == "" || this.prezime_vlasnikaTextBox.Text == "" || this.kontaktTextBox.Text == "" || this.voziloTextBox.Text == "") {
                MessageBox.Show("Molimo upišite sve obavezne podatke.");
                return false;
            }
            return true;
        }


        //nako ispisa racuna, obavljeni servis vozila se brise iz evidencije ..... mogućnost punjenja baze podataka Povijest 
        private void brisi_servis(int id)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Servis WHERE Id='"+id+"';";
            try
            {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Odabrani podatak je izbrisan.");
                // TODO: Cancel button (možda)
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion

        #region TextBox

        private void ime_vlasnikaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                prezime_vlasnikaTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void prezime_vlasnikaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                kontaktTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void kontaktTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                voziloTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void voziloTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                registracijaTextBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion
    }
}