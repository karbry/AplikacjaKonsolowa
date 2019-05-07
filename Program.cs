using System;
using cennik;
using klient;
using biz;
namespace zaliczeniePO
{

    class Program


    {
        
        public Klient[] klienci = new Klient[10];
        public Biznesowy[] biz = new Biznesowy[5];

        static void Main(string[] args)
        {
            Program program = new Program();

            string wybor2="";
            while (wybor2 != "X" || wybor2!="x") 
            {

                Console.WriteLine("Wybierz rodzaj klienta (1.Gospodarstwo domowe, 2.Dzialalnosc gospodarcza): ");
                int wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        program.Klt();
                        Console.WriteLine("Wpisz numer klienta: ");
                        int numerKlienta = Convert.ToInt32(Console.ReadLine());
                        program.WywolanieI(numerKlienta);
                        program.fakturaI(numerKlienta);
                        break;

                    case 2:
                        program.Biz();
                        Console.WriteLine("Wpisz numer klienta: ");
                        numerKlienta = Convert.ToInt32(Console.ReadLine());
                        program.WywolanieB(numerKlienta);
                        program.fakturaB(numerKlienta);
                        break;

                    default:
                        Console.WriteLine("Podaj 1 albo 2!");
                        break;
                }

                Console.WriteLine("Wpisz X, aby zakonczyc. Enter = kontynuacja. ");
                wybor2 = Console.ReadLine();
            } 
            Console.ReadKey();

        }

        private void Klt() {

            klienci[0] = new Klient("Janusz", "Pawlowski", "Wolnosci 2/3, 56-700 Siedlce", new Taryfowy());
            klienci[1] = new Klient("Anna", "Szulc", "Lesna 3, 56-700 Siedlce", new Standardowy());
            klienci[2] = new Klient("Marek", "Zuk", "Reja 89, 33-500 Brzeg", new EnergiaPremium());
            klienci[3] = new Klient("Celina", "Kozak", "Wolnosci 34/9, 56-720 Siedlce", new EnergiaPremium());
            klienci[4] = new Klient("Karina", "Cyn", "Zielinskiego 56, 50-400 Poznan", new Standardowy());
            klienci[5] = new Klient("Marta", "Szoner", "Wolnosci 67/89, 45-700 Gdansk", new Standardowy());
            
        }

        private void Biz()
        {
            biz[0] = new Biznesowy("Biuro rachunkowe", "Grunwaldzka 5/78, 43-222 Krakow");
            biz[1] = new Biznesowy("Salon kosmetyczny", "Piekna 2/9, 90-670 Siechnice");
            biz[2] = new Biznesowy("Salon fryzjerski", "Szablowa 4, 67-890 Katowice");
            biz[3] = new Biznesowy("Zaklad produkcyjny", "Ludowa 45, 56-720 Siedlce");
        }


        public void WywolanieI(int nk)
        {
            
            Console.WriteLine("Klient nazywa sie: {0} {1}, pobiera prad na adresie: {2}. Typ cennika: {3}."
                , klienci[nk].imie, klienci[nk].nazwisko, klienci[nk].PPE, klienci[nk].cennik.nazwaCennika);
        }

        public void WywolanieB(int nk)
        {
           
                Console.WriteLine("Nazwa firmy: {0}. Adres: {1}. Typ cennika: {2}."
                    , biz[nk].nazwafirmy, biz[nk].PPE, biz[nk].cennik.nazwaCennika);
          

        }

        public void fakturaI(int nk)
        {
            Console.WriteLine("Podaj zuzycie pradu: ");
            double zuzycie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Za ile miesiecy jest rozliczenie: ");
            double miesiace = Convert.ToInt32(Console.ReadLine());

            double result = zuzycie * klienci[nk].cennik.stawkakWh + klienci[nk].cennik.oplataStala * miesiace;
                

            Console.WriteLine("Faktura wynosi: " + result + "PLN");

        }

        public void fakturaB(int nk)
        {
            Console.WriteLine("Podaj zuzycie pradu: ");
            double zuzycie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Za ile miesiecy jest rozliczenie: ");
            double miesiace = Convert.ToInt32(Console.ReadLine());

            double result = zuzycie * biz[nk].cennik.stawkakWh + biz[nk].cennik.oplataStala * miesiace;


            Console.WriteLine("Faktura wynosi: " + result + "PLN");

        }

    }

}

