using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    public class RadniNalog
    {
        int id, id_vozila, id_zaposlenika,cijena,obavljeno;
        string opis,datum;

        public RadniNalog(int Id, int Id_v,int Id_z,String Opis,int Cijena, int Obavljeno, String Datum)
        {
            id = Id;
            id_vozila = Id_v;
            id_zaposlenika = Id_z;
            opis = Opis.Trim();
            cijena = Cijena;
            obavljeno = Obavljeno;
            datum = Datum.Trim();
        }

        public override string ToString()
        {
            return id + " " + id_vozila + " " + " " + id_zaposlenika + " " + opis + " " + cijena + " " + obavljeno + " " + datum;
        }
    }
}
