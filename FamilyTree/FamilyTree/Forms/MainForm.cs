using FamilyTree.Forms;
using FamilyTree.Models;

namespace FamilyTree
{
    public partial class MainForm : Form
    {
        private FamilyTree.Models.FamilyTree familyTree = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string date = DateTextBox.Text.Trim();
            string id = IdTextBox.Text.Trim();
            string name = NameTextBox.Text.Trim();

            if (familyTree == null)
            {
                MessageBox.Show("Please load/generate the family tree first.");
                return;
            }

            List<Person> result = familyTree.Find(date, id, name);

            NothingLabel.Visible = result.Count == 0;

            personBindingSource.DataSource = result;
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

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                familyTree = new FamilyTree.Models.FamilyTree();
                familyTree.DeserializeData("familytree.json");
                MessageBox.Show("Family tree loaded successfully!");
                familyTree.PrintFullTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading family tree: {ex.Message}");
            }
        }

        private void GetTree_Click(object sender, EventArgs e)
        {
            Person selectedPerson = SearchResults.SelectedItem as Person;

            if (selectedPerson == null)
            {
                MessageBox.Show("Please select a person from the list.");
                return;
            }

            TreeNode treeNode = familyTree.BuildAncestorTree(selectedPerson);

            FamilyTreeView.Nodes.Clear();
            if (treeNode != null)
                FamilyTreeView.Nodes.Add(treeNode);

            FamilyTreeView.ExpandAll();
        }


        private void GenerateTestData_Click(object sender, EventArgs e)
        {
            familyTree = Models.GenerateTestData.GenerateFamilyTreeWithAncestors();
            Person rootPerson = familyTree.GetMemberById(1);
            if (rootPerson == null)
            {
                MessageBox.Show("Root person with ID 1 not found.");
                return;
            }

            TreeNode treeNode = familyTree.BuildAncestorTree(rootPerson);

            FamilyTreeView.Nodes.Clear();
            if (treeNode != null)
                FamilyTreeView.Nodes.Add(treeNode);

            FamilyTreeView.ExpandAll();
            familyTree.PrintFullTree();
        }
    }
}
