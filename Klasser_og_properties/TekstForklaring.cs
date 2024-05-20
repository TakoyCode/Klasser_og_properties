using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_og_properties
{
    internal class TekstForklaring
    {
        /*
            En Klasse (Class) er som en oppskrift for å lage noe.
            Si at du vil lage et objekt som representerer en bok.
            Klassen er da oppskriften, og boken du lager er objektet.
            Oppskriften (klassen) sier hva boken skal ha, som for eksempel tittel og forfatter.
            Eksempel:
        */
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public void ShowInfo()
            {
                Console.WriteLine($"Tittel: {Title}, Forfatter: {Author}.");
            }
        }
        /* 
            Egenskaper (properties) er som spesifikasjoner i oppskriften som forteller hvordan du kan lese og endre ting.
            Hvis du vil endre tittelen på boken, bruker du oppskriften (property) til å gjøre det på riktig måte.
        
            I dette eksemplet er Title en egenskap som representerer tittelen på en bok.
            Den har både lesetilgang ('get') og skrivetilgang ('set'), slik at du kan hente eller endre den.
         
         */
        public void Eksample()
        {
            Book minBok = new Book();

            minBok.Title = "Eventyret om Bokstopp";
            minBok.Author = "Leslie Forfatter";
            minBok.ShowInfo();
        }
        // Her bruker du egenskapene "Title" og "Author" for å sette informasjonen om boken når du oppretter en instans av "Book"-klassen.
        // Deretter bruker du metoden "ShowInfo" for å vise informasjonen om boken
    }
}
