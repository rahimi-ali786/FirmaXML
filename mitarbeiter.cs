using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaXML
{
    public class mitarbeiter
    {
        private string vname; 
        private string nname;
        private string telefonnr;

        public mitarbeiter(string vname, string nname, string telefonnr)
        {
            this.vname = vname;
            this.nname = nname;
            this.telefonnr = telefonnr;
        }

        public string Vname { get => vname; set => vname = value; }
        public string Nname { get => nname; set => nname = value; }
        public string Telefonnr { get => telefonnr; set => telefonnr = value; }


        public string mitarbeiterInfo()
        {
            return "Vorname: " + vname + ", Nachname: " + nname + ", Telefonnummer: " + telefonnr;
        }



    }
}
