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
    public partial class PersonEditForm : Form
    {
        Person formPerson;
        public PersonEditForm(Person person, Form parentForm)
        {
            //////////////////////////////////////////////////////////////////
            /// THIS MUST BE THE FIRST LINE OF YOUR FORM CLASS CONSTRUCTOR ///
            ////////////////////////////////////////////////////////////////// 
            InitializeComponent();

            // this is the constructor of our PersonEditForm class derived from the Form parent class
            // our class has the following objects added to it:
            //    this.typeLabel : Label control
            //    this.typeComboBox : ComboBox control

            //    this.nameLabel : Label control
            //    this.nameText : TextBox control

            //    this.emailLabel : Label control
            //    this.emailText : TextBox control

            //    this.ageLabel : Label control
            //    this.ageText : TextBox control

            //    this.licLabel : Label control
            //    this.licText : TextBox control

            //    this.gpaLabel : Label control
            //    this.gpaText : TextBox control

            //    this.specialtyLabel : Label control
            //    this.specText : TextBox control

            //    this.cancelButton : Button control
            //    this.okButton : Button control

            //    this.errorProvider : ErrorProvider control


            this.formPerson = person;

            // if a parent form created this form
            if (parentForm != null)
            {
                // set the owner
                this.Owner = parentForm;

                // center to the owner
                this.CenterToParent();
            }

            // default the OK button to be disabled
            // and only enable it if all text fields are valid
            this.okButton.Enabled = false;

            // most Form controls have a Tag field which is a System.Object type
            // and can be used to store any property
            // loop through all of the controls on the form
            foreach (Control control in this.Controls)
            {
                // we will use the Tag field to indicate if the field is valid or not
                // initialize Tag to false to indicate invalid
                control.Tag = false;
            }

            // the following excerpts are from "Windows Forms Controls" on myCourses 
            // to add Validating and TextChanged event handlers to the TextBox Controls

            /*********************************************************************************** 
            Validating Event
            Occurs when the object is leaving scope (ie. tabbing out of the field or the user clicked another field or button)
            Accepts the event handler CancelEventHandler() because the primary purpose of Validating is to determine whether 
            this event should cause the focus to leave the current control and enter the next control 
            (if CausesValidation == True for the next control).  If the validation fails, then the navigation event is 
            cancelled and the current control stays in focus.

            Example for adding the delegate method:
                this.objectName.Validating += new CancelEventHandler(this.ObjectName__Validating);

            The CancelEventHandler() delegate method must accept the following parameters:
                private void ObjectName__Validating(object sender, CancelEventArgs e)
            By convention, the delegate methods are named:
                ObjectName_EventName()

            Important Fields in sender (TextBox)
                TextBox tb = (TextBox)sender;
                tb.Text: validate for certain contents before allowing user to exit the field

            Important Fields in CancelEventArgs
                e.Cancel: a boolean to indicate whether the event should be cancelled or not.  If set to true, then the current TextBox will stay in focus.
            ************************************************************************************/

            // we want the same delegate function to be called for the following 6 fields
            // TxtBoxEmpty__Validating() is defined below
            this.nameText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.emailText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);
            this.ageText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);
            this.gpaText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating); ;
            this.specText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);

            /*********************************************************************************** 
            TextChanged
            Occurs when the contents of Text changes (ie. TextBox.Text)
            Accepts the empty EventHandler() delegate because the event is limited to only the current control.
            
            Example for adding the delegate method:
                    this.objectName.TextChanged += new EventHandler(this.ObjectName__TextChanged);
            
            The EventHandler delegate method must have the following signature:
                private void ObjectName__TextChanged(object sender, EventArgs e)
            
            Important Fields in sender
                TextBox tb = (TextBox)sender;
                tb.Text: the current text in the TextBox
            
            Important Fields in EventArgs
                None.
            ************************************************************************************/

            // we want the same delegate function to be called for the following 6 fields
            this.nameText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.emailText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.ageText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.licText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.gpaText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.specText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);

            /*
            KeyPress Event for TextBox fields
            Occurs when the user presses a key sequence which generates a character(shift + A for example) within the control
                     Accepts the KeyPressEventHandler() delegate, whose method must have the following signature:
                        private void ObjectName__KeyPress(object sender, KeyPressEventArgs e)
            
            Example for adding the delegate method:
                    this.objectName.KeyPress += new KeyPressEventHandler(this.ObjectName__KeyPress);
            
            Important Fields in sender:
                TextBox tb = (TextBox)sender;
                tb.Text: the current text in the TextBox
            
            Important Fields in KeyPressEventArgs
                e.KeyChar: gets or sets the character just pressed allowing you to change, suppress or pass - through each character
                e.Handled: a boolean to indicate whether the delegate's method "handled" the keypress.  If it is set to true, then .NET will not process the keypress (ie. the keyboard buffer will be cleared).
            */

            // finish coding the TxtNum__KeyPress function below, which enforces digits-only in the Age, License and GPA fields,
            // and allows 1 decimal point in the GPA field.
            this.ageText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);
            this.licText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);
            this.gpaText.KeyPress += new KeyPressEventHandler(TxtNum__KeyPress);

            /*
            SelectedIndexChanged Event for ComboBox Controls
            Occurs when the user changes the ComboBox value
            Accepts the empty EventHandler() delegate because the event is limited to only the current control.
            
            Example for adding the delegate method:
                    this.objectName.SelectedIndexChanged += new EventHandler(this.ObjectName__SelectedIndexChanged);
            
            The EventHandler delegate method must have the following signature:
                private void ObjectName__SelectedIndexChanged(object sender, EventArgs e)
            
            Important Fields in sender
                ComboBox cb = (ComboBox) sender;
                    cb.SelectedIndex: the 0-based index of the selected item
                    cb.SelectedItem: the string of the display value of the selected item
            
            Important Fields in EventArgs
                None.
            */
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

        private void TxtNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            // A key was pressed in the associated number field
            // only allow digits or a single '.' for the gpa field

            TextBox tb = (TextBox)sender;

            // e.KeyChar contains the character that was pressed
            // if a numeric character was entered or backspace was entered  
            // Char.IsDigit(char) checks if a char is a digit
            // '\b' is the character code for backspace
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // .NET should continue to handle the keystroke (ie. add it to the textbox)
                // set e.Handled to indicate that we did not handle it
                e.Handled = false;
            }
            else
            {
                // assume that the keystroke can be flagged as being handled by us
                // (ie. drop the keystroke from the .NET buffer and don't show it in the textbox)
                e.Handled = true;

                // if the active control is the GPA field gpaText
                // then allow one '.'
                if (tb == this.gpaText)
                {
                    // if they entered '.' and it is not already in gpaText.Text
                    if (e.KeyChar == '.' && !tb.Text.Contains("."))
                    {
                        // .NET should continue to handle the keystroke (ie. show it in the text box)
                        e.Handled = false;
                    }
                }
            }

            // recalculate enabled status of the okButton
            ValidateAll();
        }

        // don't allow associated fields to be empty while the user is editing it
        private void TxtBoxEmpty__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // if the field has just become empty
            if (tb.Text.Length == 0)
            {
                // show error
                this.errorProvider.SetError(tb, "This field cannot be empty.");

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                this.errorProvider.SetError(tb, null);

                // set the control to being valid
                tb.Tag = true;
            }

            // recalculate enabled status of the okButton
            ValidateAll();
        }

        // don't allow associated fields to be empty while the user is leaving the field
        private void TxtBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // if the field is empty
            if (tb.Text.Length == 0)
            {
                // show error
                this.errorProvider.SetError(tb, "This field cannot be empty.");

                // cancel moving to the next field
                e.Cancel = true;

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;

                // set the control to being valid
                tb.Tag = true;
            }

            // recalculate enabled status of the okButton
            ValidateAll();
        }

        private void ValidateAll()
        {
            // enable or disable the OK button based on the valid state of the fields that cannot be blank
            this.okButton.Enabled =
                (bool)this.nameText.Tag &&
                (bool)this.emailText.Tag &&
                (bool)this.ageText.Tag &&
                (bool)this.specText.Tag &&
                (bool)this.gpaText.Tag;
        }
    }
}
