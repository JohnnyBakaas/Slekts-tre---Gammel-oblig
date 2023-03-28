namespace Slekts_tre___Gammel_oblig.Model
{
    internal class UserInterface
    {
        public void GetUserInput(List<Person> persons, bool dysleksi)
        {
            Console.WriteLine("Hjelp");
            Console.WriteLine("List");
            Console.WriteLine("Skriv ID for brukere");
            string userInput = Console.ReadLine();

            if (userInput == "Bare tall") { }
            else if (userInput == "Hjelp") { }
            else if (userInput == "List") { }
            else
            {
                GetUserInput(persons, true);
            }
        }
    }
}
