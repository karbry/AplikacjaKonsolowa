using System;
using System.Collections.Generic;
using System.Text;
using cennik;
namespace klient
{
    class Klient
    {
        public string imie;
        public string nazwisko;
        public string PPE;
        public Cennik cennik;
        public string typ = "Indywidualny";


        public Klient(string imie, string nazwisko, string PPE, Cennik cennik)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.PPE = PPE;
            this.zmienCennik(cennik);
          
        }

        public void zmienCennik(Cennik cennik)
        {
            this.cennik = cennik;
        }

      

    }


}
