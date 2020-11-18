using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Presidents : Form
    {
        public Presidents()
        {
            InitializeComponent();
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            /*
             * ~~CONTROLS~~
             * this.harrisonButton : RadioButton control
             * this.fdRooseveltButton : RadioButton control
             * this.clintonButton : RadioButton control
             * this.buchananButton : RadioButton control
             * this.pierceButton : RadioButton control
             * this.bushButton : RadioButton control
             * this.obamaButton : RadioButton control
             * this.kennedyButton : RadioButton control
             * this.mckinleyButton : RadioButton control
             * this.reaganButton : RadioButton control
             * this.eisenhowerButton : RadioButton control
             * this.vanburenButton : RadioButton control
             * this.washingtonButton : RadioButton control
             * this.adamsButton : RadioButton control
             * this.tRooseveltButton : RadioButton control
             * this.jeffersonButton : RadioButton control
             * 
             * this.harrisonTextBox : TextBox control
             * this.fdRooseveltTextBox : TextBox control
             * this.clintonTextBox : TextBox control
             * this.buchananTextBox : TextBox control
             * this.pierceTextBox : TextBox control
             * this.bushTextBox : TextBox control
             * this.obamaTextBox : TextBox control
             * this.kennedyTextBox : TextBox control
             * this.mckinleyTextBox : TextBox control
             * this.reaganTextBox : TextBox control
             * this.eisenhowerTextBox : TextBox control
             * this.vanburenTextBox : TextBox control
             * this.washingtonTextBox : TextBox control
             * this.adamsTextBox : TextBox control
             * this.tRooseveltTextBox : TextBox control
             * this.jeffersonTextBox : TextBox control
             * 
             * this.filterGroupBox : GroupBox control
             * this.allButton : RadioButton control
             * this.democratButton : RadioButton control
             * this.republicanButton : RadioButton control
             * this.democraticRepublicanButton : RadioButton control
             * this.federalistButton : RadioButton control
             * 
             * this.presidentPictureBox : PictureBox control
             * 
             * this.wikiPageGroupBox : GroupBox control
             * this.webBrowser : WebBrowser control
             *               
             * this.progressBar : ProgressBar control
             * 
             * this.exitButton : Button control
             * 
             * this.toolTip : ToolTip control
             * this.errorProvider : ErrorProvider control
             * 
             * this.statusStrip : StatusStrip control
             * this.toolStripProgressBar : ToolStripProgressBar control
             * this.timer : Timer control
             */

            //default exit button to be disabled
            this.exitButton.Enabled = false;

            //set event handlers for president radio buttons being pressed
            this.harrisonButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.harrisonButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.fdRooseveltButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.clintonButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.buchananButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.pierceButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.bushButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.obamaButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.kennedyButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.mckinleyButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.reaganButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.eisenhowerButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.vanburenButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.washingtonButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.adamsButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.tRooseveltButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);
            this.jeffersonButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            //set event handlers for president textbox keypress to enforce typing of numbers or backspace
            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.fdRooseveltTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.vanburenTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.tRooseveltTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(this.TextBoxNum__KeyPress);

            //set event handlers for president textbox text being left
            this.harrisonTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.fdRooseveltTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.clintonTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.buchananTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.pierceTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.bushTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.obamaTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.kennedyTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.mckinleyTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.reaganTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.eisenhowerTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.vanburenTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.washingtonTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.adamsTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.tRooseveltTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);
            this.jeffersonTextBox.Validating += new CancelEventHandler(this.PresidentTextBox__Validating);

            //set event handlers for president textbox being hovered over (tooltip)
            this.harrisonTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.fdRooseveltTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.clintonTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.buchananTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.pierceTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.bushTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.obamaTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.kennedyTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.mckinleyTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.reaganTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.eisenhowerTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.vanburenTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.washingtonTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.adamsTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.tRooseveltTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);
            this.jeffersonTextBox.MouseHover += new EventHandler(this.PresidentTextBox__MouseHover);

            //set event handler for picture box being hovered over(enter & exit)
            this.presidentPictureBox.MouseEnter += new EventHandler(this.PresidentPictureBox__MouseEnter);
            this.presidentPictureBox.MouseLeave += new EventHandler(this.PresidentPictureBox__MouseLeave);

            //set event handler for filter group box radio items changing
            this.allButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
            this.democratButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
            this.republicanButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
            this.democraticRepublicanButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
            this.federalistButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);

            //set event handler for exit button clicked
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            //set event handler for timer tick
            this.timer.Tick += new EventHandler(Timer__Tick);

            //Initial loading of form
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            toolStripProgressBar.Value = 120;
        }

        private void PresidentRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                if (rb == this.harrisonButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                }
                else if (rb == this.fdRooseveltButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
                }
                else if (rb == this.clintonButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Bill_Clinton");
                }
                else if (rb == this.buchananButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
                }
                else if (rb == this.pierceButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                }
                else if (rb == this.bushButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_W._Bush");
                }
                else if (rb == this.obamaButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
                }
                else if (rb == this.kennedyButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F._Kennedy");
                }
                else if (rb == this.mckinleyButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
                }
                else if (rb == this.reaganButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                }
                else if (rb == this.eisenhowerButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
                }
                else if (rb == this.vanburenButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_Van_Buren";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");
                }
                else if (rb == this.washingtonButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
                }
                else if (rb == this.adamsButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
                }
                else if (rb == this.tRooseveltButton)
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                }
                else
                {
                    wikiPageGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
                    presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
                    webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                }
            }
        }

        private void TextBoxNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PresidentTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string errorMsg = "";
            
            if (tb == this.harrisonTextBox)
            {
                if (tb.Text != "23" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.fdRooseveltTextBox)
            {
                if (tb.Text != "32" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.clintonTextBox)
            {
                if (tb.Text != "42" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.buchananTextBox)
            {
                if (tb.Text != "15" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.pierceTextBox)
            {
                if (tb.Text != "14" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.bushTextBox)
            {
                if (tb.Text != "43" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.obamaTextBox)
            {
                if (tb.Text != "44" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.kennedyTextBox)
            {
                if (tb.Text != "35" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.mckinleyTextBox)
            {
                if (tb.Text != "25" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.reaganTextBox)
            {
                if (tb.Text != "40" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.eisenhowerTextBox)
            {
                if (tb.Text != "34" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.vanburenTextBox)
            {
                if (tb.Text != "8" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.washingtonTextBox)
            {
                if (tb.Text != "1" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.adamsTextBox)
            {
                if (tb.Text != "2" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else if (tb == this.tRooseveltTextBox)
            {
                if (tb.Text != "26" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }
            else
            {
                if (tb.Text != "3" && tb.Text != "0" && tb.Text != "")
                {
                    e.Cancel = true;
                    errorMsg = "That is the wrong answer";
                    errorProvider.SetError(tb, errorMsg);
                }
                else if (tb.Text == "")
                {
                    tb.Text = "0";
                    this.timer.Start();
                }
                else if (tb.Text != "0" && tb.Text != "")
                {
                    errorMsg = "";
                    errorProvider.SetError(tb, errorMsg);
                }
            }

            this.timer.Interval = 500;

            if (tb.Text != "0")
            {
                this.timer.Start();
            }
            ValidateAll();
        }

        private void PresidentTextBox__MouseHover(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            toolTip.Show("Which # president?", tb);
        }

        private void PresidentPictureBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            
            pb.Width = 280;
            pb.Height = 300;
        }

        private void PresidentPictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Width = 138;
            pb.Height = 185;
        }

        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                if (rb == this.allButton)
                {
                    this.harrisonButton.Visible = true;
                    this.fdRooseveltButton.Visible = true;
                    this.clintonButton.Visible = true;
                    this.buchananButton.Visible = true;
                    this.pierceButton.Visible = true;
                    this.bushButton.Visible = true;
                    this.obamaButton.Visible = true;
                    this.kennedyButton.Visible = true;
                    this.mckinleyButton.Visible = true;
                    this.reaganButton.Visible = true;
                    this.eisenhowerButton.Visible = true;
                    this.vanburenButton.Visible = true;
                    this.washingtonButton.Visible = true;
                    this.adamsButton.Visible = true;
                    this.tRooseveltButton.Visible = true;
                    this.jeffersonButton.Visible = true;

                    this.harrisonButton.Checked = true;
                }
                else if (rb == this.democratButton)
                {
                    this.harrisonButton.Visible = false;
                    this.fdRooseveltButton.Visible = true;
                    this.clintonButton.Visible = true;
                    this.buchananButton.Visible = true;
                    this.pierceButton.Visible = true;
                    this.bushButton.Visible = false;
                    this.obamaButton.Visible = true;
                    this.kennedyButton.Visible = true;
                    this.mckinleyButton.Visible = false;
                    this.reaganButton.Visible = false;
                    this.eisenhowerButton.Visible = false;
                    this.vanburenButton.Visible = true;
                    this.washingtonButton.Visible = false;
                    this.adamsButton.Visible = false;
                    this.tRooseveltButton.Visible = false;
                    this.jeffersonButton.Visible = false;

                    this.fdRooseveltButton.Checked = true;
                }
                else if (rb == this.republicanButton)
                {
                    this.harrisonButton.Visible = true;
                    this.fdRooseveltButton.Visible = false;
                    this.clintonButton.Visible = false;
                    this.buchananButton.Visible = false;
                    this.pierceButton.Visible = false;
                    this.bushButton.Visible = true;
                    this.obamaButton.Visible = false;
                    this.kennedyButton.Visible = false;
                    this.mckinleyButton.Visible = true;
                    this.reaganButton.Visible = true;
                    this.eisenhowerButton.Visible = true;
                    this.vanburenButton.Visible = false;
                    this.washingtonButton.Visible = false;
                    this.adamsButton.Visible = false;
                    this.tRooseveltButton.Visible = true;
                    this.jeffersonButton.Visible = false;

                    this.harrisonButton.Checked = true;
                }
                else if (rb == this.democraticRepublicanButton)
                {
                    this.harrisonButton.Visible = false;
                    this.fdRooseveltButton.Visible = false;
                    this.clintonButton.Visible = false;
                    this.buchananButton.Visible = false;
                    this.pierceButton.Visible = false;
                    this.bushButton.Visible = false;
                    this.obamaButton.Visible = false;
                    this.kennedyButton.Visible = false;
                    this.mckinleyButton.Visible = false;
                    this.reaganButton.Visible = false;
                    this.eisenhowerButton.Visible = false;
                    this.vanburenButton.Visible = false;
                    this.washingtonButton.Visible = false;
                    this.adamsButton.Visible = false;
                    this.tRooseveltButton.Visible = false;
                    this.jeffersonButton.Visible = true;

                    this.jeffersonButton.Checked = true;
                }
                else
                {
                    this.harrisonButton.Visible = false;
                    this.fdRooseveltButton.Visible = false;
                    this.clintonButton.Visible = false;
                    this.buchananButton.Visible = false;
                    this.pierceButton.Visible = false;
                    this.bushButton.Visible = false;
                    this.obamaButton.Visible = false;
                    this.kennedyButton.Visible = true;
                    this.mckinleyButton.Visible = false;
                    this.reaganButton.Visible = false;
                    this.eisenhowerButton.Visible = false;
                    this.vanburenButton.Visible = false;
                    this.washingtonButton.Visible = true;
                    this.adamsButton.Visible = true;
                    this.tRooseveltButton.Visible = false;
                    this.jeffersonButton.Visible = false;

                    this.washingtonButton.Checked = true;
                }
            }
        }   
        
        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateAll()
        {
            if(this.harrisonTextBox.Text == "23" && fdRooseveltTextBox.Text == "32" && clintonTextBox.Text == "42" && buchananTextBox.Text == "15" && pierceTextBox.Text == "14" && bushTextBox.Text == "43"
                && obamaTextBox.Text == "44" && kennedyTextBox.Text == "35" && mckinleyTextBox.Text == "25" && reaganTextBox.Text == "40" && eisenhowerTextBox.Text == "34" && vanburenTextBox.Text == "8"
                && washingtonTextBox.Text == "1" && adamsTextBox.Text == "2" && tRooseveltTextBox.Text == "26" && jeffersonTextBox.Text == "3")
            {
                exitButton.Enabled = true;
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();

                this.harrisonTextBox.Text = "0";
                this.fdRooseveltTextBox.Text = "0";
                this.clintonTextBox.Text = "0";
                this.buchananTextBox.Text = "0";
                this.pierceTextBox.Text = "0";
                this.bushTextBox.Text = "0";
                this.obamaTextBox.Text = "0";
                this.kennedyTextBox.Text = "0";
                this.mckinleyTextBox.Text = "0";
                this.reaganTextBox.Text = "0";
                this.eisenhowerTextBox.Text = "0";
                this.vanburenTextBox.Text = "0";
                this.washingtonTextBox.Text = "0";
                this.adamsTextBox.Text = "0";
                this.tRooseveltTextBox.Text = "0";
                this.jeffersonTextBox.Text = "0";

                toolStripProgressBar.Value = 120;
            }
        }
    }
}
