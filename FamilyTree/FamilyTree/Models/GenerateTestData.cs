namespace FamilyTree.Models
{
    public class GenerateTestData
    {
        private static string[] MaleFirstNames = { "Ivan", "Olexandr", "Petro", "Mikhailo", "Andriy", "Serhiy" };
        private static string[] FemaleFirstNames = { "Maria", "Olga", "Anna", "Yulia", "Natalia", "Olena" };
        private static string[] LastNames = { "Petrenko", "Kovalenko", "Melnyk", "Tkachenko", "Shevchenko" };
        private static string[] MaleMiddleNames = { "Aleksiyovych", "Ivanovich", "Petrovych", "Mykhaylovych" };
        private static string[] FemaleMiddleNames = { "Aleksiyivna", "Ivanivna", "Petrivna", "Mykhaylivna" };
        private static string[] Cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro" };
        private static string[] Streets = { "Shevchenka", "Kyivska", "Tsentralna", "Kurbasa", "Kadenyka" };

        private static Random random = new Random();

        public static Person GeneratePerson()
        {
            Gender gender = random.Next(2) == 1 ? Gender.Male : Gender.Female;

            var person = new Person
            {
                Id = random.Next(99999),
                Sex = gender,
                FirstName = gender == Gender.Male ? MaleFirstNames[random.Next(MaleFirstNames.Length)] : FemaleFirstNames[random.Next(FemaleFirstNames.Length)],
                LastName = LastNames[random.Next(LastNames.Length)],
                MiddleName = gender == Gender.Male ? MaleMiddleNames[random.Next(MaleMiddleNames.Length)] : FemaleMiddleNames[random.Next(FemaleMiddleNames.Length)],
                DateOfBirth = GenerateRandomDate(1900, 2010),
                PlaceOfBirth = Cities[random.Next(Cities.Length)],
                Address = $"{Streets[random.Next(Streets.Length)]} str, {random.Next(1, 123)}"
            };

            return person;
        }

        public static FamilyTree GenerateFamilyTree(int personCount)
        {
            var tree = new FamilyTree();
            var persons = new List<Person>();

            for (int i = 1; i <= personCount; i++)
            {
                var person = GeneratePerson();
                persons.Add(person);
                tree.AddMember(person);
            }

            for (int i = 0; i < persons.Count; i++)
            {
                var child = persons[i];

                var potentialParents = persons
                    .Where(pp => pp.DateOfBirth.Year <= child.DateOfBirth.Year - 18 && pp.DateOfBirth.Year >= child.DateOfBirth.Year - 37)
                    .ToList();

                if (potentialParents.Any())
                {
                    var father = potentialParents.Where(pp => pp.Sex == Gender.Male).FirstOrDefault();
                    if (father != null)
                    {
                        child.AddParent(father);
                    }

                    var mother = potentialParents.Where(pp => pp.Sex == Gender.Female).FirstOrDefault();
                    if (mother != null)
                    {
                        child.AddParent(mother);
                    }
                }

            }

            return tree;
        }

        private static DateTime GenerateRandomDate(int startYear, int endYear)
        {
            int year = random.Next(startYear, endYear + 1);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }
    }
}
