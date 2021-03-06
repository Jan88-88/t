using System;
using System.Collections.Generic;
using System.Linq;

namespace Bloggen
{
    class Program

    {
        public string AskforString(string message)
        {
            Console.WriteLine(message);
            bool succes = false;
            string answer;
            do
            {
                Console.WriteLine();
                answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                   Console.WriteLine("You must enter somthing");
                }
                else
                {
                    succes = true;
                }
            } while (!succes);
            return answer;
        }
        static void Main(string[] args)
        {
            
            List<string[]> minBlogg = new List<string[]> {};
            string[] box = new string[2];
            box[0] = "Titel";
            box[1] = "Inlägg";
            string search = ""; 

            //DateTime dt = DateTime.Now;
            //Console.WriteLine("\t" + dt);
            Console.WriteLine(DateTime.Now.ToString());
            bool mybool = true;
            while (mybool)
            {
                Console.WriteLine("\nVälkommen till Bloggen!" + "\nVälj från menyn nedan");
                Console.WriteLine("\t[1] Skriv inlägg");
                Console.WriteLine("\t[2] Skriv ut alla inlägg");
                Console.WriteLine("\t[3] Sök ord");
                Console.WriteLine("\t[4] Ta bort inlägg i bloggen");
                Console.WriteLine("\t[5] Avsluta programmet");
                int menyVal;
                Int32.TryParse(Console.ReadLine(), out  menyVal);
                switch (menyVal)
            {
                  case 1:
                        Console.Clear();
                        Console.Write("Skriv titel: ");
                        box = new string[2];
                        box[0] = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Skriv in inlägg: ");
                        box[1] = Console.ReadLine();
                        Console.Clear();
                        minBlogg.Add(box);

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nDe inlägg finns i bloggen!");
                        foreach (string[] partOfBloggen in minBlogg)
                        {
                            Console.WriteLine("Titel:" + partOfBloggen[0] + "\nPost:" + partOfBloggen[1]);
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();

                            //Console.Write("Skriv in ett ord för att söka bland dina inlägg: ");
                            //search = Console.ReadLine();

                            Console.Write("Search word: ");
                            search = Console.ReadLine();
                            //foreach (string[] text in minBlogg)
                                for (int i = 0; i < box.Length; i++)
                                {
                                if (box[i].ToLower() == search.ToLower())
                                    {
                                        Console.Write("You find the searing word:" + " " + box[i]);
                                    }
                                else
                                {
                                    Console.Write("\n\tDitt inlägg hittades inte, försök igen");
                                }
                                break;
                            }

                            /*for (int i = 0; i < box.Length; i++) //Detta blir nu rödmarkerat. 


                            if (box[i].ToUpper() == search.ToUpper())
                            if (box.ToList().Contains(search))
                            {
                                Console.Write("Inlägget hittades! " + box[i]);

                            }
                            foreach (string[] sbox in minBlogg)
                            {
                                if (sbox.ToList().Contains(search))
                                {
                                    Console.WriteLine("Result => " + sbox[0] + "-" + sbox[1]);
                                }
                            }*/
                            break;    
                        }



                    /*
                    Console.Write("Skriv in en titel för att söka efter ett inlägg: ");

                    search = Console.ReadLine();

                    //linq?
                    var entries = minBlogg.Where(entry => entry.Contains(search));
                    foreach (var entry in entries)
                    {
                        foreach (string s in entry)
                            Console.WriteLine(s);
                    }
                    if (entries.Count() == 0)
                    {
                        Console.WriteLine("Inlägget du sökte kunde inte hittas");
                    }*/





                    /*
                   {
                       Console.WriteLine("\nTitel: " + text[0] + "\nInlägg" + text[1]);
                   }*/


                    /*
                    Console.Clear();
                    Console.Write("Sök efter titel på loggar: ");
                    string sök = Console.ReadLine();

                    foreach (string[] text in minBlogg) // foreach som söker efter arrayen i loggboken
                    {
                        if (text[0].Contains(sök)) //Om arrayen hittas i Console.Readline så skrivs den ut. Använder en if sats för det
                        {
                            Console.WriteLine("\n" + text[0] + "\n" + text[1] + "\n" + text[2]);
                        }
                        else //Om "sök" inte hittar något
                        {
                            Console.WriteLine("Sökning misslyckades");
                        }
                    }
                    /* int num = 2;
                    string[] test = new string[num];
                    test[0] = "jan";
                    test[1] = "jan";

                    Console.WriteLine("Skriv ett sökord");
                    String word = Console.ReadLine();
                    for (int i = 0; i < test.Length; i++)
                        if (test[i].ToLower() == word.ToLower()) 

                        {
                            Console.Write( test[i]);
                        }


                        else
                    {
                        Console.WriteLine("Fel sökande ord");
                    }
                        */

                    case 5:
                        minBlogg.Clear();
                        Console.WriteLine("\tDina inlägg är raderade, lägg till nya!");
                        break;


                    case 4:
                        mybool = false;
                        break;
                        
                    default:
                        Console.WriteLine("Du har skrivit fel, försök igen, vad god och vilja mellan 1-4!");
                        break;
                }
            }
        }
    }
}
