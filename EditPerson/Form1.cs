using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;
using PeopleAppGlobals;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person formPerson;
        public EditPersonForm(Person person, Form parentForm)
        {
            InitializeComponent();

            this.formPerson = person;

            if (parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }

            this.okButton.Enabled = false;

            foreach(Control control in this.Controls)
            {
                control.Tag = false;
            }

            this.nameText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.emailText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.ageText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.gpaText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.specText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);

            this.nameText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.emailText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.ageText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.licText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.gpaText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.specText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);

            this.ageText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);
            this.licText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);
            this.gpaText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);

            this.typeComboBox.SelectedIndexChanged += new EventHandler(TypeComboBox__SelectedIndexChanged);

            // load all the common fields out of the person reference variable
            // and into our form fields
            this.nameText.Text = person.name;
            this.emailText.Text = person.email;
            this.ageText.Text = person.age.ToString();
            this.licText.Text = person.LicenseId.ToString();

            // if we are editing a Student
            if (person.GetType() == typeof(Student))
            {
                // set the combo box to the student index (0)
                // executing this line will trigger the SelectedIndexChanged event
                // and call our TypeComboBox__SelectedIndexChanged() method
                // which will display the appropriate fields for our Student
                this.typeComboBox.SelectedIndex = 0;

                // declare a Student reference variable so we can set the gpaText form field
                // from the student object
                Student student = (Student)person;
                this.gpaText.Text = student.gpa.ToString();
            }
            else
            {
                // set the combo box to the teacher index (1)
                // executing this line will trigger the SelectedIndexChanged event
                // and call our TypeComboBox__SelectedIndexChanged() method
                // which will display the appropriate fields for our Teacher
                this.typeComboBox.SelectedIndex = 1;

                // declare a Teacher reference variable so we can set the specText form field
                // from the teacher object
                Teacher teacher = (Teacher)person;
                this.specText.Text = teacher.specialty;
            }

            // associate the Click delegate methods for our 2 buttons to the Click event handler
            this.okButton.Click += new EventHandler(OkButton__Click);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void TxtBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty.");
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void TxtBoxEmpty__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();

        }

        private void TxtNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                if (tb == this.gpaText)
                {
                    if (e.KeyChar == '.' && !tb.Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                }
            }

            ValidateAll();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            // if a parent form called this form
            if (this.Owner != null)
            {
                // enable the parent form
                this.Owner.Enabled = true;

                // set Windows to focus back on it
                this.Owner.Focus();
            }

            // close our form window
            this.Close();

            // clean up all variables associated with this form
            this.Dispose();
        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            // declare our reference variables for accessing all possible person fields
            Student student = null;
            Teacher teacher = null;
            Person person = null;

            // remove the person associated with the original email
            Globals.people.Remove(this.formPerson.email);

            // if the current person type is set to Student
            if (this.typeComboBox.SelectedIndex == 0)
            {
                // create a new Student object
                student = new Student();
                person = student;
            }
            else
            {
                // else create a new Teacher object
                teacher = new Teacher();
                person = teacher;
            }

            // copy the common fields from the form fields using the person reference variable
            // to access the common fields of the parent Person class
            person.name = this.nameText.Text;
            person.email = this.emailText.Text;
            person.age = Convert.ToInt32(this.ageText.Text);
            person.LicenseId = Convert.ToInt32(this.licText.Text);

            if (person.GetType() == typeof(Student))
            {
                // if a student, then copy the gpa from the form field into our student object
                student.gpa = Convert.ToDouble(this.gpaText.Text);
            }
            else
            {
                // if a teacher, then copy the specText from the form field into our teacher object
                teacher.specialty = this.specText.Text;
            }

            // add the edited person back into our SortedList
            Globals.people[person.email] = person;

            formPerson = person;

            // if a parent form called this form
            if (this.Owner != null)
            {
                // enable the parent form
                this.Owner.Enabled = true;

                // set Windows to focus back on it
                this.Owner.Focus();
            }

            // close our form window
            this.Close();

            // clean up all variables associated with this form
            this.Dispose();
        }

        // the Event Handler for changing the typeComboBox value (Student or Teacher)
        // if it's set to Student, show the GPA label and field, but not the Specialty label and field
        // if it's set to Teacher, show the Specialty label and field, but not the GPA label and field
        private void TypeComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            // the ComboBox SelectedIndex = 0 (Student)
            if (cb.SelectedIndex == 0)
            {
                // set specText and specialtyLabel Visible field = false
                this.specialtyLabel.Visible = false;
                this.specText.Visible = false;

                // set the specText field as valid since that does not have to be validated for a student
                this.specText.Tag = true;

                // set gpaText and gpaLabel Visible field = true
                this.gpaLabel.Visible = true;
                this.gpaText.Visible = true;

                // gpaText is only valid if not blank
                this.gpaText.Tag = (this.gpaText.Text.Length > 0);
            }
            else
            {
                // else Teacher is selected

                // set specText and specialtyLabel Visible field = true
                this.specialtyLabel.Visible = true;
                this.specText.Visible = true;

                // specText is only valid if not blank
                this.specText.Tag = (this.specText.Text.Length > 0);

                // set gpaText and gpaLabel Visible field = false
                this.gpaLabel.Visible = false;
                this.gpaText.Visible = false;

                // validate gpaText since it's not required for teachers
                this.gpaText.Tag = true;
            }

            // recalculate enabled status of the okButton
            ValidateAll();
        }

        private void ValidateAll()
        {
            this.okButton.Enabled =
                (bool)this.nameText.Tag &&
                (bool)this.emailText.Tag &&
                (bool)this.ageText.Tag &&
                (bool)this.specText.Tag &&
                (bool)this.gpaText.Tag;
        }
    }
}
