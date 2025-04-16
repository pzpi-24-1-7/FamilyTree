namespace FamilyTree.Models
{
    public class FamilyTree
    {
        private List<Person> members;

        public FamilyTree()
        {
            members = [];
        }

        public List<Person> Find(string date, string id, string name)
        {
            List<Person> finded = [];
            foreach (var person in members)
            {
                string str = person.ToString()!.ToLower();
                if (str.Contains(date.ToLower()) && str.Contains(id.ToLower()) && str.Contains(name.ToLower()))
                {
                    Console.WriteLine(person);
                    finded.Add(person);
                }
            }
            return finded;
        }

        public void AddMember(Person person)
        {
            if (person != null && !members.Contains(person))
            {
                members.Add(person);
            }
        }

        public Person GetMemberById(int id)
        {
            return members.FirstOrDefault(p => p.Id == id);
        }

        public void GetDescendants(Person person)
        {
            void PrintDescendants(Person p, int level = 0)
            {
                if (p == null) return;

                foreach (var child in p.Children)
                {
                    Console.WriteLine($"{new string(' ', level)}{child.FirstName} {child.LastName}");
                    PrintDescendants(child, level + 2);
                }
            }

            if (person != null)
            {
                Console.WriteLine($"\n{person.FirstName} {person.LastName} descedants:");
                PrintDescendants(person);
            }
        }

        public void GetAncestors(Person person)
        {
            void PrintAncestors(Person p, int level = 0)
            {
                if (p == null) return;

                if (p.Father != null)
                {
                    Console.WriteLine($"{new string(' ', level)}{p.Father.FirstName} {p.Father.LastName}");
                    PrintAncestors(p.Father, level + 2);
                }
                if (p.Mother != null)
                {
                    Console.WriteLine($"{new string(' ', level)}{p.Mother.FirstName} {p.Mother.LastName}");
                    PrintAncestors(p.Mother, level + 2);
                }
            }

            if (person != null)
            {
                Console.WriteLine($"\n{person.FirstName} {person.LastName} ancestors:");
                PrintAncestors(person);
            }
        }

        public void PrintFullTree()
        {
            var roots = members.Where(p => p.Father == null && p.Mother == null).ToList();

            if (!roots.Any())
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Console.WriteLine("Family tree:");
            foreach (var root in roots)
            {
                PrintSubTree(root, 0);
            }
        }

        private void PrintSubTree(Person person, int level = 0)
        {
            if (person == null) return;

            Console.WriteLine($"{new string(' ', level)}{person.FirstName} {person.LastName} ({person.DateOfBirth.Year})");

            foreach (var child in person.Children)
            {
                PrintSubTree(child, level + 2);
            }
        }
    }
}
