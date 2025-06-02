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

        public List<Person> Find(DateTime? dateFrom, DateTime? dateTo, string firstName, string lastName)
        {
            return members.Where(person =>
                (string.IsNullOrWhiteSpace(firstName) || person.FirstName.ToLower().Contains(firstName.ToLower())) &&
                (string.IsNullOrWhiteSpace(lastName) || person.LastName.ToLower().Contains(lastName.ToLower())) &&
                (!dateFrom.HasValue || person.DateOfBirth >= dateFrom.Value) &&
                (!dateTo.HasValue || person.DateOfBirth <= dateTo.Value)
            ).ToList();
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void RemoveMemberAndAncestors(Person person)
        {
            if (person == null) return;

            HashSet<Person> toRemove = new();
            CollectAncestors(person, toRemove);
            toRemove.Add(person);

            foreach (var member in members.ToList())
            {
                foreach (var rm in toRemove)
                {
                    if (member.Father == rm) member.Father = null;
                    if (member.Mother == rm) member.Mother = null;
                    member.Children.Remove(rm);
                }
            }

            foreach (var rm in toRemove)
            {
                members.Remove(rm);
            }
        }

        private void CollectAncestors(Person person, HashSet<Person> set)
        {
            if (person.Father != null && set.Add(person.Father))
                CollectAncestors(person.Father, set);

            if (person.Mother != null && set.Add(person.Mother))
                CollectAncestors(person.Mother, set);
        }

        public Person? GetRootMember()
        {
            return members.FirstOrDefault();
        }

        public TreeNode BuildAncestorTree(Person person)
        {
            if (person == null) return null;

            TreeNode rootNode = new($"{person.FirstName} {person.LastName} ({person.DateOfBirth:yyyy})")
            {
                Tag = person
            };

            AddAncestorsRecursive(person, rootNode);

            return rootNode;
        }

        private void AddAncestorsRecursive(Person person, TreeNode node)
        {
            if (person.Father != null)
            {
                TreeNode fatherNode = new($"Father: {person.Father.FirstName} {person.Father.LastName} ({person.Father.DateOfBirth:yyyy})")
                {
                    Tag = person.Father
                };
                node.Nodes.Add(fatherNode);
                AddAncestorsRecursive(person.Father, fatherNode);
            }

            if (person.Mother != null)
            {
                TreeNode motherNode = new($"Mother: {person.Mother.FirstName} {person.Mother.LastName} ({person.Mother.DateOfBirth:yyyy})")
                {
                    Tag = person.Mother
                };
                node.Nodes.Add(motherNode);
                AddAncestorsRecursive(person.Mother, motherNode);
            }
        }
    }
}
