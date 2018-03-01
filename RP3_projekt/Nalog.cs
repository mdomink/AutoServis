using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    public class Nalog
    {      
        public String Opis;
        public int Cijena;

        public Nalog(String opis, int cijena)
        {
            Opis = opis;
            Cijena = cijena;
        }

        public override string ToString()
        {
            return Opis + " " + Cijena;
        }
    }
}
