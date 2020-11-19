using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BirthdayForm_UnitTest3
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public int x = 0;
        public int y = 0;
        public int buttonMvmts = 0;
        public Form1()
        {
            InitializeComponent();

            /*
             * ~~CONTROLS~~
             * ageTextBox : TextBox control
             * birthYearNumericUpDown : NumericUpDown control
             * colorComboBox : ComboBox control
             * pictureBox : PictureBox control
             * submitButton : Button control
             */

            //Set event handler for keyPress of ageTextBox (only binary allowed)
            this.ageTextBox.KeyPress += new KeyPressEventHandler(AgeTextBox__KeyPress);

            //Set keyPress and valueChanged event handlers of birthYearNumericUpDown
            this.birthYearNumericUpDown.KeyPress += new KeyPressEventHandler(BirthYearNumericUpDown__KeyPress);
            this.birthYearNumericUpDown.ValueChanged += new EventHandler(BirthYearNumericUpDown__ValueChanged);

            //Set combobox index changed event handler
            this.colorComboBox.SelectedIndexChanged += new EventHandler(ColorComboBox__SelectedIndexChanged);

            //Set mouse hover and click event handlers for submit button
            this.submitButton.MouseHover += new EventHandler(SubmitButton__MouseHover);
            this.submitButton.Click += new EventHandler(SubmitButton__Click);

            x = rand.Next(0, 750);
            y = rand.Next(0, 500);
        }

        private void AgeTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || e.KeyChar == '1' || e.KeyChar == '0')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BirthYearNumericUpDown__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BirthYearNumericUpDown__ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;

            int j = 0;

            int i = (int)nud.Value;

            if (i % 2 == 0)
            {
                nud.RightToLeft = RightToLeft.Yes;

                while (j < 10)
                {
                    x += rand.Next(0, 15);
                    y += rand.Next(0, 10);

                    if (x > 750 || x < 180)
                    {
                        x = 190;
                    }
                    if (y > 500 || y < 85)
                    {
                        y = 90;
                    }
                    pictureBox.Location = new Point(x, y);
                    j++;
                    Thread.Sleep(100);
                }
            }
            else
            {
                nud.RightToLeft = RightToLeft.No;

                while (j < 10)
                {
                    x -= rand.Next(0, 30);
                    y -= rand.Next(0, 15);

                    if (x > 750 || x < 180)
                    {
                        x = 190;
                    }
                    if (y > 500 || y < 85)
                    {
                        y = 90;
                    }
                    pictureBox.Location = new Point(x, y);
                    j++;
                    Thread.Sleep(100);
                }
            }
        }

        private void ColorComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void SubmitButton__MouseHover(object sender, EventArgs e)
        {
            buttonMvmts++;

            if (buttonMvmts < 10)
            {
                submitButton.Location = new Point(rand.Next(0, 750), rand.Next(0, 500));
            }
        }

        private void SubmitButton__Click(object sender, EventArgs e)
        {
            string ageS = this.ageTextBox.Text;
            int age = 0;
            try
            {
                age = Int32.Parse(ageS);
            }
            catch
            {
                age = 0;
            }
            if (age >= 10101 && this.birthYearNumericUpDown.Value >= 10)
            {
                Form3 form3 = new Form3();
                form3.Activate();
                form3.Focus();
                form3.Show();
            }
            else
            {
                Form2 form2 = new Form2(this);
                form2.Activate();
                form2.Focus();
                form2.Show();
            }
        }
    }
}
