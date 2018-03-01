using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    public class Zaposlenik
    {
        public String ime, prezime, adresa, brojMobitela;
        public int id;

        public Zaposlenik() {}

        // Adresa i BrojMobitela nisu nužni
        public Zaposlenik(int Id, string Ime, string Prezime, string Adresa="", string BrojMobitela="") {
            this.id = Id;
            this.ime = Ime;
            this.prezime = Prezime;
            this.adresa = Adresa;
            this.brojMobitela = BrojMobitela;
        }

        public override string ToString() {
            return id + " " + ime + " " + prezime;
        }

        public string ToStringFull() {
            return id + " " + ime + " " + prezime + " " + adresa + " " + brojMobitela;
        }
    }
}
