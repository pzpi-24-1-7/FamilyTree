using FamilyTree.Models;

namespace FamilyTree.Forms
{
    public partial class EditPersonForm : Form
    {
        public Person Person;

        public EditPersonForm(Person person)
        {
            InitializeComponent();

            KeyPreview = true;
            AcceptButton = OKButton;
            CancelButton = CancelButton1;

            SexCBox.Items.AddRange(Enum.GetValues(typeof(Gender)).Cast<object>().ToArray());
            FNBox.Text = person.FirstName;
            LNBox.Text = person.LastName;
            MNBox.Text = person.MiddleName;
            SexCBox.SelectedItem = person.Gender;
            dateTimePicker.Value = person.DateOfBirth;
            POBBox.Text = person.PlaceOfBirth;
            AddressBox.Text = person.Address;
            Person = person;
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

            Person.FirstName = FNBox.Text;
            Person.LastName = LNBox.Text;
            Person.MiddleName = MNBox.Text;
            Person.Gender = (Gender)SexCBox.SelectedItem;
            Person.DateOfBirth = dateTimePicker.Value;
            Person.PlaceOfBirth = POBBox.Text;
            Person.Address = AddressBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
