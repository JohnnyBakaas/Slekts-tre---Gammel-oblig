namespace Slekts_tre___Gammel_oblig.Model
{
    internal class unitTestNo1
    {
        public void TestAllFields()
        {
            var p = new Person
            {
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { FirstName = "Per" },
                Mother = new Person() { FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=0) Født: 2000 Død: 3000 Far: Per (Id=1) Mor: Lise (Id=2)";

            Console.WriteLine(actualDescription);
            Console.WriteLine(expectedDescription);
        }
    }
}
