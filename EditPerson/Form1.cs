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
