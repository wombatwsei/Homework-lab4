using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
{
    public partial class appTitle : Form
    {
        public appTitle()
        {
            InitializeComponent();
        }

        private void Aplikacja_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelMsg1.Text = "Witaj " + textBoxFName.Text + " " + textBoxLName.Text;

            int age = 0;

            try
            {
                age = Convert.ToInt32(textBoxAge.Text);
            }
            catch (FormatException)
            {
                labelMsg2.Text = "BLEDNY WIEK!";
            }
            catch (OverflowException)
            {
                labelMsg2.Text = "BLEDNY WIEK";
            }
            if(age < 0)
            {
                labelMsg2.Text = "BLEDNY WIEK!";
            }
            else if (age > 0 && age < 67)
            {
                labelMsg2.Text = string.Format(" do emerytury zostalo Ci {0} lat", 67 - age);
            }
            else if (age == 0)
            {
                labelMsg2.Text = "BLEDNY WIEK";
            }
            else
            {
                labelMsg2.Text = " jestes emerytem.";
            }
        }
    }
}
