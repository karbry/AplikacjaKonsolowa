using System;
using System.Collections.Generic;
using System.Text;
using cennik;

namespace biz
{
    class Biznesowy
    {
        public string nazwafirmy;
        public string PPE;
        public string typ = "Biznesowy";
        public Cennik cennik = new PradDlaBiznesu();

        public Biznesowy(string nazwafirmy, string PPE)
        {
            this.nazwafirmy = nazwafirmy;
            this.PPE = PPE;
        }
    }
}
