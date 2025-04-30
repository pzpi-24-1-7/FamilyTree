using FamilyTree.Models;

namespace FamilyTree.Forms
{
    public partial class EditPersonForm : Form
    {
        public Person Person;

        public EditPersonForm(Person person)
        {
            InitializeComponent();
            SexCBox.Items.AddRange(Enum.GetValues(typeof(Gender)).Cast<object>().ToArray());
            FNBox.Text = person.FirstName;
            LNBox.Text = person.LastName;
            MNBox.Text = person.MiddleName;
            SexCBox.SelectedItem = person.Sex;
            dateTimePicker.Value = person.DateOfBirth;
            POBBox.Text = person.PlaceOfBirth;
            AddressBox.Text = person.Address;
            //authorBox.Text = (unit as Book)?.Author;
            //technologyBox.Text = (unit as TechBook)?.Technologies;
            Person = person;
        }

        private void EditPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            Person.FirstName = FNBox.Text;
            Person.LastName = LNBox.Text;
            Person.MiddleName = MNBox.Text;
            Person.Sex = (Gender)SexCBox.SelectedItem;
            Person.DateOfBirth = dateTimePicker.Value;
            Person.PlaceOfBirth = POBBox.Text;
            Person.Address = AddressBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FNBox_Validated(object sender, EventArgs e)
        {
            if (FNBox.Text.Trim() == "")
            {
                MessageBox.Show("Input must not be empty.");
                //e.Cancel = true;
            }
        }
    }
}
