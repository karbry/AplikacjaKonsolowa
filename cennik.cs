using System;
using System.Collections.Generic;
using System.Text;

namespace cennik
{
    
        public class Cennik
        { 
            public string nazwaCennika;
            public double stawkakWh; 
            public double oplataStala; 
        }

        public class Taryfowy : Cennik
        {
            public Taryfowy()
            {
                base.nazwaCennika = "Taryfowy";
                base.stawkakWh = 0.6; 
                base.oplataStala = 20;
            }
        }

        public class Standardowy : Cennik
        {
            public Standardowy()
            {
                base.nazwaCennika = "Standardowy";
                base.stawkakWh = 0.66;
                base.oplataStala = 25;
            }
        }

        public class EnergiaPremium : Cennik
        {
            public EnergiaPremium()
            {
                base.nazwaCennika = "Energia Premium";
                base.stawkakWh = 0.69;
                base.oplataStala = 28;
            }
        }

        public class PradDlaBiznesu : Cennik
        {
        public PradDlaBiznesu()
        {
            base.nazwaCennika = "Prad dla biznesu";
            base.stawkakWh = 2.64;
            base.oplataStala = 129;
        }
    }
}


