namespace Slekts_tre___Gammel_oblig.Model
{
    internal class Person
    {
        private static int _lastId = 0;

        private int _id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;


        public Person(string firstName, string lastName, int birthYear, int deathYear)
        {
            _id = _lastId++;

            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            DeathYear = deathYear;
        }

        public Person() { _id = _lastId++; }

        public string GetDescription()
        {
            string outText = "";
            if (FirstName != null) { outText += $"{FirstName}"; }
            if (LastName != null) { outText += $" {LastName}"; }
            outText += $" (Id={_id})";
            if (BirthYear != 0) { outText += $" Født: {BirthYear}"; }
            if (DeathYear != 0) { outText += $" Død: {DeathYear}"; }
            if (Father != null) { outText += $" Far: {Father.GetDescription()}"; }
            if (Mother != null) { outText += $" Far: {Mother.GetDescription()}"; }

            return outText;
        }
    }


}
