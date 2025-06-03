using FamilyTree.Models;

namespace FamilyTree.Utils
{
    public static class GenerateTestData
    {
        private static string[] MaleFirstNames = { "Ivan", "Olexandr", "Petro", "Mikhailo", "Andriy", "Serhiy" };
        private static string[] FemaleFirstNames = { "Maria", "Olga", "Anna", "Yulia", "Natalia", "Olena" };
        private static string[] LastNames = { "Petrenko", "Kovalenko", "Melnyk", "Tkachenko", "Shevchenko" };
        private static string[] MaleMiddleNames = { "Aleksiyovych", "Ivanovich", "Petrovych", "Mykhaylovych" };
        private static string[] FemaleMiddleNames = { "Aleksiyivna", "Ivanivna", "Petrivna", "Mykhaylivna" };
        private static string[] Cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro" };
        private static string[] Streets = { "Shevchenka", "Kyivska", "Tsentralna", "Kurbasa", "Kadenyka" };

        private static Random random = new();

        public static Person GeneratePerson(Gender sex)
        {
            var person = new Person
            {
                Gender = sex,
                FirstName = sex == Gender.Male ? MaleFirstNames[random.Next(MaleFirstNames.Length)] : FemaleFirstNames[random.Next(FemaleFirstNames.Length)],
                LastName = LastNames[random.Next(LastNames.Length)],
                MiddleName = sex == Gender.Male ? MaleMiddleNames[random.Next(MaleMiddleNames.Length)] : FemaleMiddleNames[random.Next(FemaleMiddleNames.Length)],
                PlaceOfBirth = Cities[random.Next(Cities.Length)],
                Address = $"{Streets[random.Next(Streets.Length)]} str, {random.Next(1, 123)}"
            };

            return person;
        }

        public static FamilyTree.Models.FamilyTree GenerateFamilyTreeWithAncestors(int maxDepth = 4)
        {
            var tree = new FamilyTree.Models.FamilyTree();
            Gender gender = random.Next(2) == 1 ? Gender.Male : Gender.Female;

            Person root = GeneratePerson(gender);
            root.DateOfBirth = GenerateRandomDate(2000, 2020);

            tree.AddMember(root);

            GenerateAncestors(root, tree, 1, maxDepth);

            return tree;
        }

        private static void GenerateAncestors(Person child, FamilyTree.Models.FamilyTree tree, int currentDepth, int maxDepth)
        {
            if (currentDepth > maxDepth)
                return;

            Person father = GeneratePerson(Gender.Male);
            father.DateOfBirth = child.DateOfBirth.AddYears(-random.Next(20, 40));

            Person mother = GeneratePerson(Gender.Female);
            mother.DateOfBirth = child.DateOfBirth.AddYears(-random.Next(20, 35));

            child.AddParent(father);
            child.AddParent(mother);

            father.AddChild(child);
            mother.AddChild(child);

            tree.AddMember(father);
            tree.AddMember(mother);

            GenerateAncestors(father, tree, currentDepth + 1, maxDepth);
            GenerateAncestors(mother, tree, currentDepth + 1, maxDepth);
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
