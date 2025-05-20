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
        public int Id { get; set; }
        public string FirstName { get; set; } = "No data yet";
        public string LastName { get; set; } = "No data yet";
        public string MiddleName { get; set; } = "No data yet";
        public Gender Sex { get; set; }
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

        public override string ToString()
        {
            return $"ID: {Id}, {FirstName} {MiddleName} {LastName}, Born: {DateOfBirth.Year}, Sex: {Sex}, Place: {PlaceOfBirth}, Address: {Address}";
        }

        public void GetPassportData()
        {
            Console.WriteLine($"ID: {Id};" +
                $"\nFirst name: {FirstName};" +
                $"\nLast name: {LastName};" +
                $"\nMiddle name: {MiddleName};" +
                $"\nSex: {Sex};" +
                $"\nDate of birth: {DateOfBirth};" +
                $"\nPlace of birth: {PlaceOfBirth};" +
                $"\nAddress: {Address};");
        }

        public void AddChild(Person child)
        {
            if (child == null || child == this || Children.Contains(child))
                return;

            Children.Add(child);

            if (Sex == Gender.Male && child.Father != this)
                child.Father = this;

            if (Sex == Gender.Female && child.Mother != this)
                child.Mother = this;
        }

        public void AddParent(Person parent)
        {
            if (parent == null || parent == this)
                return;

            if (parent.Sex == Gender.Male && Father != parent)
                Father = parent;

            if (parent.Sex == Gender.Female && Mother != parent)
                Mother = parent;

            if (!parent.Children.Contains(this))
                parent.Children.Add(this);
        }
    }
}
