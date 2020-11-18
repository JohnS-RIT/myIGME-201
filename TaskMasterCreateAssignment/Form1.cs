using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMasterCreateAssignment
{
    public partial class CreateAssignment : Form
    {
        //When we create an assignment .dll
        //Assignment myAssignment;
        public CreateAssignment()
        {
            InitializeComponent();

            /* COMPONENTS:
             * classTextBox
             * assignmentTextBox
             * dateTimePicker
             * hourTextBox (numbers only 1-12)
             * minuteTextBox (numbers only 0-60)
             * meridiemComboBox (AM/PM)
             * positiveRadioButton
             * negativeRadioButton
             * createButton
             * cancelButton
             */

            this.createButton.Enabled = false;

            this.classTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.assignmentTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.hourTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.minuteTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);

            this.classTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.assignmentTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.hourTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.minuteTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
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

        

        private void ValidateAll()
        {
            // enable or disable the OK button based on the valid state of the fields that cannot be blank
            this.createButton.Enabled =
                (bool)this.classTextBox.Tag &&
                (bool)this.assignmentTextBox.Tag &&
                (bool)this.hourTextBox.Tag &&
                (bool)this.minuteTextBox.Tag;
        }
    }
}
