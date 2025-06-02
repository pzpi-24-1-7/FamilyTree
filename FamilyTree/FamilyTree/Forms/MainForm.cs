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
            if (familyTree == null)
            {
                MessageBox.Show("Please load or generate the family tree first.");
                return;
            }

            string firstName = FNBox.Text.Trim();
            string lastName = LNBox.Text.Trim();

            DateTime? dateFrom = FromDP.Checked ? FromDP.Value.Date : (DateTime?)null;
            DateTime? dateTo = ToDP.Checked ? ToDP.Value.Date : (DateTime?)null;

            List<Person> result = familyTree.Find(dateFrom, dateTo, firstName, lastName);

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            familyTree.SerializeData("familytree.json");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                familyTree = new FamilyTree.Models.FamilyTree();
                familyTree.DeserializeData("familytree.json");
                DisplayTree(familyTree.GetRootMember());
                MessageBox.Show("Family tree loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading family tree: {ex.Message}");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage =
                "Програма: Сімейне дерево\n" +
                "Версія: 1.0.0\n" +
                "Автор: Зозуля Д. О.\n" +
                "Опис: Програма для створення, редагування та перегляду сімейного дерева.\n" +
                "Основні функції:\n" +
                "- Додавання нових членів сім’ї\n" +
                "- Редагування інформації про осіб\n" +
                "- Видалення осіб та їхніх предків\n" +
                "- Пошук членів сім’ї за різними параметрами\n" +
                "- Генерація тестових даних\n" +
                "- Збереження та завантаження даних\n" +
                "- Візуалізація сімейного дерева";

            MessageBox.Show(aboutMessage, "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FamilyTreeView.SelectedNode?.Tag is not Person selectedPerson)
            {
                MessageBox.Show("Please select a person in the tree to add a parent.");
                return;
            }

            using NewPersonForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Person newParent = form.Person;
                selectedPerson.AddParent(newParent);
                newParent.AddChild(selectedPerson);
                familyTree.AddMember(newParent);
                DisplayTree(familyTree.GetRootMember());
                newParent.GetPassportData();
            }
        }

        private void addChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FamilyTreeView.SelectedNode?.Tag is not Person selectedPerson)
            {
                MessageBox.Show("Please select a person in the tree to add a child.");
                return;
            }

            using NewPersonForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Person newChild = form.Person;
                selectedPerson.AddChild(newChild);
                newChild.AddParent(selectedPerson);
                familyTree.AddMember(newChild);
                DisplayTree(familyTree.GetRootMember());
                newChild.GetPassportData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person? person = null;

            if (SearchResults.SelectedItem is Person selectedFromList)
            {
                person = selectedFromList;
            }
            else if (FamilyTreeView.SelectedNode?.Tag is Person selectedFromTree)
            {
                person = selectedFromTree;
            }

            if (person == null)
            {
                MessageBox.Show("Please select a person from the list or tree.");
                return;
            }

            using EditPersonForm form = new(person);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (FamilyTreeView.SelectedNode != null)
                {
                    DisplayTree(familyTree.GetRootMember());
                }

                personBindingSource.ResetBindings(false);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FamilyTreeView.SelectedNode == null)
                {
                    MessageBox.Show("Please select a person in the tree to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Person selectedPerson = FamilyTreeView.SelectedNode.Tag as Person;

                if (selectedPerson == null)
                {
                    MessageBox.Show("Selected item does not contain valid person data.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show(
                    $"Are you sure you want to delete {selectedPerson.FirstName} {selectedPerson.LastName}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    familyTree.RemoveMemberAndAncestors(selectedPerson);
                    FamilyTreeView.Nodes.Remove(FamilyTreeView.SelectedNode);
                    DisplayTree(familyTree.GetRootMember());
                    personBindingSource.ResetBindings(false);
                    MessageBox.Show("Person removed successfully.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An unexpected error occurred while trying to delete the person. Please make sure a person is selected from the tree.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                familyTree = new FamilyTree.Models.FamilyTree();
                familyTree.DeserializeData("familytree.json");
                DisplayTree(familyTree.GetRootMember());
                MessageBox.Show("Family tree loaded successfully!");
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

            DisplayTree(selectedPerson);
        }

        private void GenerateTestData_Click(object sender, EventArgs e)
        {
            familyTree = Models.GenerateTestData.GenerateFamilyTreeWithAncestors();
            DisplayTree(familyTree.GetRootMember());
        }

        private void DisplayTree(Person rootPerson)
        {
            TreeNode treeNode = familyTree.BuildAncestorTree(rootPerson);

            FamilyTreeView.Nodes.Clear();
            if (treeNode != null)
                FamilyTreeView.Nodes.Add(treeNode);

            FamilyTreeView.ExpandAll();
        }
    }
}
