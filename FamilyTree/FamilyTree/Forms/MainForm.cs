using FamilyTree.Forms;
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            string date = DateTextBox.Text.Trim();
            string id = IdTextBox.Text.Trim();
            string name = NameTextBox.Text.Trim();

            List<Person> result = familyTree.Find(date, id, name);

            NothingLabel.Visible = result.Count == 0;

            personBindingSource.DataSource = result;
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save data?", "", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    familyTree.SerializeData("familytree.json");
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewPersonForm form = new();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                familyTree.AddMember(form.Person);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person person = SearchResults.SelectedItem as Person;
            if (person == null)
            {
                MessageBox.Show("Select a person");
            }
            else
            {
                using EditPersonForm form = new(person);
                form.ShowDialog();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                familyTree.DeserializeData("familytree.json");
                MessageBox.Show("Family tree loaded successfully!");
                familyTree.PrintFullTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading family tree: {ex.Message}");
            }
        }
    }
}
