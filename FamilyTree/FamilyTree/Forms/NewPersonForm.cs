using FamilyTree.Models;
using System;

namespace FamilyTree.Forms
{
    public partial class NewPersonForm : Form
    {
        public Person Person { get; private set; }
        private readonly string _personType;
        private readonly DateTime? _selectedPersonBirthDate;

        public NewPersonForm(string personType, DateTime? selectedPersonBirthDate = null)
        {
            InitializeComponent();
            _personType = personType;
            _selectedPersonBirthDate = selectedPersonBirthDate;
            SexCBox.Items.AddRange(["Male", "Female"]);
            KeyPreview = true;
            AcceptButton = OKButton;
            CancelButton = CancelButton1;
        }

        private bool ValidateForm(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(FNBox.Text))
            {
                errorMessage = "First name must not be empty.";
                FNBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(LNBox.Text))
            {
                errorMessage = "Last name must not be empty.";
                LNBox.Focus();
                return false;
            }

            if (SexCBox.SelectedItem == null)
            {
                errorMessage = "Please select a gender.";
                SexCBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                errorMessage = "Address must not be empty.";
                AddressBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(POBBox.Text))
            {
                errorMessage = "Place of birth must not be empty.";
                POBBox.Focus();
                return false;
            }

            if (dateTimePicker.Value > DateTime.Now)
            {
                errorMessage = "Date of birth cannot be in the future.";
                dateTimePicker.Focus();
                return false;
            }

            if (_selectedPersonBirthDate.HasValue)
            {
                var newPersonBirthDate = dateTimePicker.Value;
                var ageDifferenceYears = (newPersonBirthDate - _selectedPersonBirthDate.Value).TotalDays / 365.25;

                if (_personType == "Parent" && ageDifferenceYears > -16)
                {
                    errorMessage = "Parent must be at least 16 years older than the child.";
                    dateTimePicker.Focus();
                    return false;
                }

                if (_personType == "Child" && ageDifferenceYears < 16)
                {
                    errorMessage = "Child must be at least 16 years younger than the parent.";
                    dateTimePicker.Focus();
                    return false;
                }
            }

            return true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Person = new Person
            {
                FirstName = FNBox.Text.Trim(),
                LastName = LNBox.Text.Trim(),
                MiddleName = MNBox.Text.Trim(),
                Gender = SexCBox.SelectedIndex == 0 ? Gender.Male : Gender.Female,
                DateOfBirth = dateTimePicker.Value,
                PlaceOfBirth = POBBox.Text.Trim(),
                Address = AddressBox.Text.Trim(),
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult == DialogResult.OK && Person == null)
            {
                e.Cancel = true;
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}