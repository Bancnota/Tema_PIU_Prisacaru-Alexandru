using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            int x, y,z;
            string Nume, Autor, NrPag, Pret;
            Carte[] carti=new Carte[10];
            int nrCarti=0;
            do
            {
                Console.Clear();
                Console.WriteLine("G.Genul cartii");
                Console.WriteLine("C.Adaugare carte ");
                Console.WriteLine("A.Afisare biblioteca ");
                Console.WriteLine("S.Salvare date in fisier");
                Console.WriteLine("I.Schimbare date carte");
                Console.WriteLine("M.Comparare Carti");
                Console.WriteLine("E.Iesire program");
                Console.WriteLine("Alegeti o optiune: ");
                opt = Console.ReadLine();
            switch (opt)
                    {
                    case "G":
                        Console.WriteLine("Alegeti genul cartii: Roman=1, Nuvela=2,Pastel=3,Basm=4");
                        carti[0]._gen = (Carte.gen)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Genul de carte ales este : {0}", carti[0]._gen);
                        break;
                    case "C":
                        Console.WriteLine("Doriti sa introduceti o carte?");
                        string raspuns = Console.ReadLine();
                        while (raspuns == "Da" || raspuns=="da"||raspuns=="DA" || raspuns=="dA")
                        {
                            Console.WriteLine("Introduceti numele cartii noi: ");
                             Nume = Console.ReadLine();
                            Console.WriteLine("Introduceti numele autorului: ");
                             Autor = Console.ReadLine();
                            Console.WriteLine("Introduceti numarul de pagini: ");
                             NrPag = Console.ReadLine();
                            Int32.TryParse(NrPag, out y);
                            Console.WriteLine("Introduceti pretul cartii: ");
                             Pret = Console.ReadLine();
                            Int32.TryParse(Pret, out x);
                          Carte s1 = new Carte(Nume, Autor, x, y);
                            carti[nrCarti] = s1;
                            nrCarti++;
                            Console.WriteLine("Doriti sa mai introduceti o carte ?");
                            string rsp=Console.ReadLine();
                            if (rsp == "DA" || rsp == "Da" || rsp == "dA" || rsp == "da")
                            {
                                continue;
                            }
                            else
                                break;
                        }break;

                    case "A":
                        for (int i = 0; i < nrCarti; i++)
                        {
                            Console.WriteLine(carti[i].Afisare());
                            Console.ReadKey();
                        }
                        break;
                    case "S":
                        using (StreamWriter sr = new StreamWriter("Fisierul meu", true))
                        {
                            for (int i = 0; i < nrCarti; i++)
                            {
                                
                                sr.WriteLine(carti[i].Afisare());
                                
                            }

                        }
                        break;
                    case "M":
                        if (nrCarti >= 2)
                        {
                            carti[0].comparare(carti[1]);
                        }
                        else
                            Console.WriteLine("Pentru comparare trebuiesc cel putin 2 carti");
                        break;
                  //  case "E":
                    //    O(0);
                   //     break;
                    
                        }
                
            } while (true);
               
           
        }
    }
}
