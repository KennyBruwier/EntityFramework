using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningDataModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ExperimentalEntities xtc = new ExperimentalEntities())
            {
                // Print elke persoon zijn id, voornaam, achternaam en leeftijd.

                //var Oefening1 = xtc.Persoons.Select(p => new
                //{
                //    p.id,
                //    p.Voornaam,
                //    p.Achternaam,
                //    p.Leeftijd
                //});

                //foreach (var persoon in Oefening1)
                //{
                //    Console.WriteLine("id: "+persoon.id + " " + persoon.Voornaam.Trim() + " " + persoon.Achternaam.Trim() + " leeftijd: " + persoon.Leeftijd);
                //}

                // Maak een query waarmee je alleen de personen hun voornamen ophaalt – niet het hele Persoon object.

                //var Oefening2 = xtc.Persoons.Select(p => p.Voornaam);
                //foreach (var voornaam in Oefening2)
                //{
                //    Console.WriteLine(voornaam.Trim());
                //}

                //Maak een query waarmee je elke persoon object ophaalt en sorteert op hun leeftijd, maar print op hun voornaam.

                //var Oefening3 = xtc.Persoons.OrderByDescending(p => p.Leeftijd);

                //foreach (Persoon persoon in Oefening3)
                //{
                //    Console.WriteLine(persoon.Voornaam.Trim() + " leeftijd: " + persoon.Leeftijd);
                //}

                // Maak een query waarmee je elke persoon hun achternaam ophaalt, en je sorteert deze aflopend - niet op de eerste letter, maar op de laatste letter. (Field, Vercauteren, Janssens)

                //var reverse = xtc.Persoons.Select(p => p.Achternaam).ToArray().OrderBy(a => new string(a.Reverse().ToArray()));
                //var Oefening4 = xtc.Persoons.Select(p => new
                //{
                //    p.Achternaam,
                //    sorteerOp = p.Achternaam.Trim().Substring(p.Achternaam.Trim().Length - 1),
                //})
                //                               .OrderByDescending(p => p.sorteerOp);

                //foreach (var achternaam in Oefening4)
                //{
                //    Console.WriteLine(achternaam.Achternaam);
                //}

                // Maak een query waarmee je personen groepeert onder leeftijd (geef enkele personen dezelfde leeftijd voor de groeperingen goed te zien).

                //var Oefening5 = xtc.Persoons.GroupBy(p => p.Leeftijd);

                //foreach (var group in Oefening5)
                //{
                //    Console.WriteLine("leeftijdsgroep: "+group.Key);
                //    foreach (var persoon in group)
                //    {
                //        Console.WriteLine(persoon.Voornaam.Trim() + " " + persoon.Achternaam.Trim() + " leeftijd: " + persoon.Leeftijd);
                //    }
                //}

                // Maak een query waarmee je aflopend sorteerd op de lengte van de achternaam, gevolgd door de lengte van de voornaam. (geef enkele personen dezelfde achternaamlengte voor te testen)
                //var Oefening6 = xtc.Persoons    .OrderByDescending(p => p.Achternaam.Trim().Length)
                //                                .ThenByDescending(p => p.Voornaam.Trim().Length);

                //foreach (var persoon in Oefening6)
                //{
                //    Console.WriteLine(persoon.Voornaam.Trim() + " l:" + persoon.Voornaam.Trim().Length + " " +persoon.Achternaam.Trim() + " l:" + persoon.Achternaam.Trim().Length);
                //}

                //Maak een query om een persoon toe te voegen.

                //xtc.Persoons.Add(new Persoon()
                //{
                //    Voornaam = "Nieuwe",
                //    Achternaam = "Persoon",
                //    Leeftijd = 50,
                //});
                //xtc.SaveChanges();

                //Maak een query om een persoon te verwijderen, door zijn Id in te geven.

                //xtc.Persoons.Remove(xtc.Persoons.FirstOrDefault(p => p.id == 6));
                //xtc.SaveChanges();


                //Maak een query om een persoon zijn leeftijd te veranderen, op basis van zowel zijn voornaam als achternaam (niet zijn Id, niet logisch maar voor het doel van de oefening).

                //xtc.Persoons.FirstOrDefault(p => p.Achternaam == "Persoon" && p.Voornaam == "Nieuwe").Leeftijd = 15;
                //xtc.SaveChanges();

                //foreach (var persoon in xtc.Persoons)
                //{
                //    Console.WriteLine("id: " + persoon.id + " " + persoon.Voornaam.Trim() + " " + persoon.Achternaam.Trim() + " " + persoon.Leeftijd + " jaar oud");
                //}

                //Maak een query waarmee je personen groepeert op “Ouder dan 40” en “Jonger dan 40”.
                //(Dit wilt zeggen dat je .GroupBy moet gebruiken om de groepen te vormen. 
                //Na de query if (persoon.Age >= 40) is verboden 😉

                //var Oefening10 = xtc.Persoons.Select(p => new
                //                {
                //                    p = p,
                //                    LeeftijdsCategory = (p.Leeftijd >= 40)?"Ouder dan 40":"Jonger dan 40"
                //                })
                //                .GroupBy(p => p.LeeftijdsCategory);

                //foreach (var group in Oefening10)
                //{
                //    Console.WriteLine(group.Key);
                //    foreach (var persoon in group)
                //    {
                //        Console.WriteLine("id: " + persoon.p.id + " " + persoon.p.Voornaam.Trim() + " " + persoon.p.Achternaam.Trim() + " " + persoon.p.Leeftijd + " jaar oud");
                //    }
                //}

            }
            Form form = new Form1();
            Application.Run(form);
            Console.ReadLine();
        }
    }
}
