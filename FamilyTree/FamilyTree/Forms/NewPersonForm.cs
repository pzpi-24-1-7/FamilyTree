using FamilyTree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void NewPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {            
            Person = new Person
            {
                FirstName = FNBox.Text,
                LastName = LNBox.Text,
                MiddleName = MNBox.Text,
                Sex = SexCBox.SelectedIndex == 0 ? Gender.Male : Gender.Female,
                DateOfBirth = dateTimePicker.Value,
                PlaceOfBirth = POBBox.Text,
                Address = AdressBox.Text,
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
