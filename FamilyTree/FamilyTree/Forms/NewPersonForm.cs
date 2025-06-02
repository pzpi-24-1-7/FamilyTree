using FamilyTree.Models;

namespace FamilyTree.Forms
{
    public partial class NewPersonForm : Form
    {
        public Person Person;
        public NewPersonForm()
        {
            InitializeComponent();
            SexCBox.Items.AddRange(["Male", "Female"]);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FNBox.Text))
            {
                MessageBox.Show("First name must not be empty.");
                FNBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(LNBox.Text))
            {
                MessageBox.Show("Last name must not be empty.");
                LNBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(MNBox.Text))
            {
                MessageBox.Show("Middle name must not be empty.");
                MNBox.Focus();
                return;
            }

            if (SexCBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                SexCBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                MessageBox.Show("Address must not be empty.");
                AddressBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(POBBox.Text))
            {
                MessageBox.Show("Place of birth must not be empty.");
                POBBox.Focus();
                return;
            }

            if (dateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot be in the future.");
                dateTimePicker.Focus();
                return;
            }

            DateTime newBirthDate = dateTimePicker.Value;

            if (Person.Father != null)
            {
                TimeSpan diffWithFather = newBirthDate - Person.Father.DateOfBirth;
                if (diffWithFather.TotalDays < 16 * 365.25)
                {
                    MessageBox.Show("The parent must be at least 16 years older than the child");
                    return;
                }
            }

            if (Person.Mother != null)
            {
                TimeSpan diffWithMother = newBirthDate - Person.Mother.DateOfBirth;
                if (diffWithMother.TotalDays < 16 * 365.25)
                {
                    MessageBox.Show("The parent must be at least 16 years older than the child");
                    return;
                }
            }

            Person = new Person
            {
                FirstName = FNBox.Text,
                LastName = LNBox.Text,
                MiddleName = MNBox.Text,
                Gender = SexCBox.SelectedIndex == 0 ? Gender.Male : Gender.Female,
                DateOfBirth = dateTimePicker.Value,
                PlaceOfBirth = POBBox.Text,
                Address = AddressBox.Text,
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FNBox_Validated(object sender, EventArgs e)
        {
            if (FNBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
            }
        }

        private void LNBox_Validated(object sender, EventArgs e)
        {
            if (LNBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
            }
        }
        private void MNBox_Validated(object sender, EventArgs e)
        {
            if (MNBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
            }
        }
        private void AddressBox_Validated(object sender, EventArgs e)
        {
            if (AddressBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
            }
        }
        private void POBBox_Validated(object sender, EventArgs e)
        {
            if (POBBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
            }
        }
    }
}
