using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayForm_UnitTest3
{
    public partial class Form2 : Form
    {
        public Form2(Form parentForm)
        {
            InitializeComponent();
            this.Owner = parentForm;
            this.CenterToParent();

            this.radioButton.Checked = false;
            this.radioButton.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                this.Close();
            }
        }
    }
}
