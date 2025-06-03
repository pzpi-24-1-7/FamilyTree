using System.Text;
using System.Text.Json.Serialization;

namespace FamilyTree.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = "No data yet";
        public string LastName { get; set; } = "No data yet";
        public string? MiddleName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = "No data yet";
        public string Address { get; set; } = "No data yet";
        [JsonInclude]
        public Person? Father { get; set; }
        [JsonInclude]
        public Person? Mother { get; set; }
        [JsonInclude]
        public List<Person>? Children { get; set; }

        public Person()
        {
            Children = [];
        }

        public string GetPassportData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID: {Id}");
            sb.AppendLine($"First Name: {FirstName}");
            sb.AppendLine($"Last Name: {LastName}");
            sb.AppendLine($"Middle Name: {MiddleName ?? "Not specified"}");
            sb.AppendLine($"Gender: {Gender}");
            sb.AppendLine($"Date of Birth: {DateOfBirth:dd.MM.yyyy}");
            sb.AppendLine($"Place of Birth: {PlaceOfBirth}");
            sb.AppendLine($"Address: {Address}");
            sb.AppendLine($"Father: {(Father != null ? $"{Father.FirstName} {Father.LastName}" : "Not specified")}");
            sb.AppendLine($"Mother: {(Mother != null ? $"{Mother.FirstName} {Mother.LastName}" : "Not specified")}");

            if (Children == null || Children.Count == 0)
            {
                sb.AppendLine("Children: None");
            }
            else
            {
                sb.AppendLine($"Children ({Children.Count}):");
                foreach (var child in Children)
                {
                    sb.AppendLine($"  - {child.FirstName} {child.LastName}");
                }
            }

            return sb.ToString();
        }

        public void AddChild(Person child)
        {
            if (child == null || child == this || Children.Contains(child))
                return;

            Children.Add(child);

            if (Gender == Gender.Male && child.Father != this)
                child.Father = this;

            if (Gender == Gender.Female && child.Mother != this)
                child.Mother = this;
        }

        public void AddParent(Person parent)
        {
            if (parent == null || parent == this)
                return;

            if (parent.Gender == Gender.Male && Father != parent)
                Father = parent;

            if (parent.Gender == Gender.Female && Mother != parent)
                Mother = parent;

            if (!parent.Children.Contains(this))
                parent.Children.Add(this);
        }
    }
}
