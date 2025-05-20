using System.Text.Json;
using System.Text.Json.Serialization;

namespace FamilyTree.Models
{
    public class FamilyTree
    {
        private List<Person> members;

        public FamilyTree()
        {
            members = [];
        }

        public void SerializeData(string path)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(members, options);
            File.WriteAllText(path, json);
        }


        public void DeserializeData(string path)
        {
            if (!File.Exists(path)) return;

            string json = File.ReadAllText(path);
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            var deserializedMembers = JsonSerializer.Deserialize<List<Person>>(json, options);

            members.Clear();
            if (deserializedMembers != null)
            {
                members.AddRange(deserializedMembers);
            }
        }
        public List<Person> Find(string date, string id, string name)
        {
            return members.Where(person =>
                person.ToString().ToLower().Contains(date.ToLower()) &&
                person.ToString().ToLower().Contains(id.ToLower()) &&
                person.ToString().ToLower().Contains(name.ToLower())
            ).ToList();
        }

        public void AddMember(Person person)
        {
            person.Id = GenerateId();
            members.Add(person);
        }

        private int GenerateId()
        {
            return members.Count == 0 ? 1 : members.Max(m => m.Id) + 1;
        }

        public Person? GetMemberById(int id)
        {
            return members.FirstOrDefault(p => p.Id == id);
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
                PrintFamily(root, 0);
            }
        }

        private void PrintFamily(Person person, int level)
        {
            if (person == null) return;

            string indent = new string(' ', level * 4);
            Console.WriteLine($"{indent}- {person.FirstName} {person.LastName} ({person.DateOfBirth.Year})");

            var spouses = members.Where(p =>
                p != person &&
                p.Children.Intersect(person.Children).Any() &&
                p.Sex != person.Sex).ToList();

            foreach (var spouse in spouses)
            {
                Console.WriteLine($"{indent}  (Spouse: {spouse.FirstName} {spouse.LastName})");
            }

            foreach (var child in person.Children.OrderBy(c => c.DateOfBirth))
            {
                PrintFamily(child, level + 1);
            }
        }

        public TreeNode BuildAncestorTree(Person person)
        {
            if (person == null) return null;

            TreeNode rootNode = new($"{person.FirstName} {person.LastName} ({person.DateOfBirth:yyyy})");

            AddAncestorsRecursive(person, rootNode);

            return rootNode;
        }

        private void AddAncestorsRecursive(Person person, TreeNode node)
        {
            if (person.Father != null)
            {
                TreeNode fatherNode = new($"Father: {person.Father.FirstName} {person.Father.LastName} ({person.Father.DateOfBirth:yyyy})");
                node.Nodes.Add(fatherNode);
                AddAncestorsRecursive(person.Father, fatherNode);
            }

            if (person.Mother != null)
            {
                TreeNode motherNode = new($"Mother: {person.Mother.FirstName} {person.Mother.LastName} ({person.Mother.DateOfBirth:yyyy})");
                node.Nodes.Add(motherNode);
                AddAncestorsRecursive(person.Mother, motherNode);
            }
        }
    }
}
