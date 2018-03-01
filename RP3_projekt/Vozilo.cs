using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    public class Vozilo
    {
        public String ime, prezime, naziv_vozila, registracija, kontakt;
        public int id;

        public Vozilo(){}

        public Vozilo(int Id,String Ime, String Prezime,String Kontakt,String Naziv,String Registracija)
        {
            ime = Ime.Trim();
            id = Id;
            prezime = Prezime.Trim();
            kontakt = Kontakt.Trim();
            naziv_vozila = Naziv.Trim();
            registracija = Registracija.Trim();
        }

        public override string ToString()
        {
            return id + " " + ime + " " + prezime + " " + kontakt + " " + naziv_vozila + " " + registracija;
        }
    }
}
