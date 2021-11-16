using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodniProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicijalizacija i deklaracija

            int ocjena, zbrojOcjena = 0;
            double prosjek=0, brojPredmeta = 0;
            //zaglavlje aplikacije
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("# Izračunavanje prosjeka ocjena #");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Za kraj i ispis prosjeka unesi 0.");
            do
            {
          
                //unos ocjene
                Console.WriteLine("Unesi ocjenu:");
                ocjena = Convert.ToInt32(Console.ReadLine());
                //provjera ispravnosti unosa ocjene
                if (ocjena <= 5 && ocjena > 1)
                {
                    //dodavanje ocjene u zbroj ocjena
                    zbrojOcjena += ocjena;

                    //brojanje predmeta
                        brojPredmeta++;
                    
                    //izračunavanje prosjeka
                    prosjek = zbrojOcjena / brojPredmeta;
                }
                else if(ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Molim upišite ispravnu ocjenu");
                }
                //debug
                Console.WriteLine("Ocjena: " + ocjena);
                Console.WriteLine("Zbroj ocjena:" + zbrojOcjena);
                Console.WriteLine("Broj predmeta:" + brojPredmeta);

            }
            while (ocjena != 0);
            //ispis prosjeka
            Console.WriteLine("Prosjek ocjena je:" + prosjek);
            Console.ReadKey();
            }

    }
}
