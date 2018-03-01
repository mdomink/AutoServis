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
    public partial class NalogRadov : Form
    {
        List<Nalog> lista_naloga = new List<Nalog>();
        Vozilo voz;
        Zaposlenik radnik;
        private SqlConnection con = BazaPodataka.veza;

        String format = "yyyy-MM-dd";

        //H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt
        //C:\Users\marko\Documents\GitHub\AutoServis\RP3_projekt\RP3_projekt
        //private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Faks\9. semestar\Računarski praktikum 3\Projekt\Servis\RP3_projekt\BazaPodataka.mdf;Integrated Security=True");
        
        #region Load

        public NalogRadov(Vozilo v, Zaposlenik z)
        {
            radnik = z;
            voz = v;
            InitializeComponent();
        }

        private void NalogRadov_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Top = this.Location.Y - 100;
        }

        #endregion

        #region Buttoni

        // Button 'Nazad'
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Button 'Dodaj'
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "" && this.textBox1.Text == "") {
                MessageBox.Show("Molimo upišite Opis posla / Cijenu.");
                return;
            }
           
            String str = this.richTextBox1.Text;
            int cijena = 0;

            try {
                cijena = Int32.Parse(this.textBox1.Text);       // bolja kontrola cijene i opisa            
            } catch(Exception ec){
                Console.WriteLine(ec.Message);
                //MessageBox.Show("Molimo upišite Cijenu u odgovarajućem formatu.");
            }
            Nalog n = new Nalog(str, cijena);
            lista_naloga.Add(n);

            try
            {
                ispisi_tablicu(lista_naloga);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button 'Izbaci'
        // izbaci opis posla iz naloga
        private void button3_Click(object sender, EventArgs e)
        {
            // Ako je lista naloga prazna, ne radi ništa
            if (!lista_naloga.Any()) {
                MessageBox.Show("Lista naloga je prazna.");
                return;
            }
            Console.WriteLine(dataGridView1.CurrentCell.RowIndex);
            if(dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < lista_naloga.Count)
            {
                lista_naloga.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                foreach (Nalog nal in lista_naloga) //zbog debagiranja
                {
                    Console.WriteLine(nal.Opis + " " + nal.Cijena);
                }
                ispisi_tablicu(lista_naloga);
            }
        }

        // Button 'Spremi'
        private void button4_Click(object sender, EventArgs e)
        {
            // Ako nije dodan niti jedan nalog
            if (!lista_naloga.Any()) {
                MessageBox.Show("Molimo dodajte barem jedan nalog.");
                return;
            }

            DateTime dan = DateTime.Today;
            // DateTime.TryParse(format,out dan);
            String datum = dan.ToString(format);
            Console.WriteLine(datum);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (lista_naloga.Count >= 0) { 
                foreach (Nalog n in lista_naloga)
                {
                    String str = n.Opis;
                    int cijena = n.Cijena;
                    cmd.CommandText = "INSERT INTO Servis VALUES('" + voz.id + "','" + radnik.id + "','" + str + "','" + 0 + "','" + cijena + "','" + datum + "');";
                    Console.WriteLine(cmd.CommandText);

                    cmd.ExecuteNonQuery();
                       
                }
                MessageBox.Show("Dodan novi servis.");
            }
            con.Close();
        }

        #endregion

        #region Pomoćne funkcije

        void ispisi_tablicu(List<Nalog> lista)
        {
            int ukupno = 0; //zbroj svih cijena 
            DataTable dt = new DataTable();
            

            if (lista_naloga.Count > 0)
            {
                dt.Columns.Add("Opis posla");
                dt.Columns.Add("Cijena");
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                foreach (Nalog nal in lista_naloga)
                {
                    dt.Rows.Add(nal.Opis, nal.Cijena);
                    ukupno += nal.Cijena;

                }
                dt.Rows.Add("", "+");
                dt.Rows.Add("Ukpuno", ukupno);
                dataGridView1.DataSource = dt;
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 400;
            }
            else
                dataGridView1.DataSource = dt;

        }

        #endregion

        private void NalogRadov_Load_1(object sender, EventArgs e)
        {

        }
    }
}
