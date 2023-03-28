namespace Slekts_tre___Gammel_oblig.Model
{
    internal class FamilyApp
    {
        List<Person> persons = new List<Person>();
        FamilyApp()
        {

        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen");
        }

        public string CommandPrompt()
        {
            return "Ting du skal trykke på";
        }
    }
}
