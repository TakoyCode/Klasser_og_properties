namespace Klasser_og_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oppgave

            // Constructor med arguments
            var pikachu = new Pokemon(21, 50, "Pikachu");
            pikachu.showInfo();

            // Constructor uten arguments
            Pokemon eevee = new Pokemon
            {
                Health = 11,
                Level = 4,
                Name = "Eevee"
            };
            eevee.showInfo();

        }
    }
}
