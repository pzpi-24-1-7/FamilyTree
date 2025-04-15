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

        public Person? Father { get; set; }
        public Person? Mother { get; set; }
        public List<Person> Children { get; set; }

        public Person()
        {
            Children = [];
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
            if (child == null || this == child || Children.Contains(child))
                return;

            Children.Add(child);

            if (Sex == Gender.Male)
                child.Father = this;
            else if (Sex == Gender.Female)
                child.Mother = this;
        }

        public void AddParent(Person parent)
        {
            if (parent == null || this == parent || parent.Children.Contains(this))
                return;

            if (parent.Sex == Gender.Male)
                Father = parent;
            else if (parent.Sex == Gender.Female)
                Mother = parent;

            parent.Children.Add(this);
        }
    }
}
