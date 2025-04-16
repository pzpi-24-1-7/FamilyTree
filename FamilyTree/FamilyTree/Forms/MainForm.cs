using FamilyTree.Models;

namespace FamilyTree
{
    public partial class MainForm : Form
    {
        private FamilyTree.Models.FamilyTree familyTree;
        public MainForm()
        {
            InitializeComponent();
            familyTree = GenerateTestData.GenerateFamilyTree(10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PersonLabel_Click(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SearchResults.Items.Clear();

            string date = DateTextBox.Text.Trim();
            string id = IdTextBox.Text.Trim();
            string name = NameTextBox.Text.Trim();

            List<Person> result = familyTree.Find(date, id, name);

            NothingLabel.Visible = result.Count == 0;

            if (result.Any())
            {
                foreach (var person in result)
                {
                    string res = $"ID: {person.Id}, {person.FirstName} {person.LastName}, {person.DateOfBirth.Year}";
                    SearchResults.Items.Add(res);
                }
            }

            MessageBox.Show($"Found {result.Count} person(s)");
        }
    }
}
