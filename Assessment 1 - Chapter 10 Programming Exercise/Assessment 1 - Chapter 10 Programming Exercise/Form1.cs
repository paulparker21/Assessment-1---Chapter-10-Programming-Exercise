using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_1___Chapter_10_Programming_Exercise
{
    public partial class Form1 : Form
    {
        private bool isUpdated;
        public Form1()
        {
            InitializeComponent();
            enterName.Visible = false;
            enterNumber.Visible = false;
            enterEmail.Visible = false;
            enterAddress.Visible = false;
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (textInfoIsValid())
            {
                isUpdated = true;
                MessageBox.Show("Successfully updated!");
                enterName.Visible = false;
                enterEmail.Visible = false;
                enterNumber.Visible = false;
                enterAddress.Visible = false;
            }
            else //given info is invalid
            {
                askForValidInfo();
                //pop up "Enter a valid name/email/address/number" accordingly
            }
        }

        private bool textInfoIsValid()
        {
            if (nameTxt.Text == null || numberTxt.Text == null || emailTxt.Text == null || addTxt.Text == null)
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(nameTxt.Text) || String.IsNullOrWhiteSpace(numberTxt.Text) || String.IsNullOrWhiteSpace(emailTxt.Text) || String.IsNullOrWhiteSpace(addTxt.Text))
            {
                return false;
            }
            else if (numberTxt.TextLength != 10) //if the number isn't as long as phone numbers should be
            {
                return false;
            }
            return true; //all the values are valid and non-null
        }


        private void askForValidInfo()
        {
            if (String.IsNullOrWhiteSpace(nameTxt.Text))
            {
                enterName.Visible = true;
            }
            else
            {
                enterName.Visible = false;
            }

            if (String.IsNullOrWhiteSpace(numberTxt.Text) || numberTxt.TextLength != 10)
            {
                enterNumber.Visible = true;
            }
            else
            {
                enterNumber.Visible = false;
            }

            if (String.IsNullOrWhiteSpace(emailTxt.Text))
            {
                enterEmail.Visible = true;
            }
            else
            {
                enterEmail.Visible = false;
            }

            if (String.IsNullOrWhiteSpace(addTxt.Text))
            {
                enterAddress.Visible = true;
            }
            else
            {
                enterAddress.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is developed by Paul Parker. The version of this software is 1.0.0.");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            numberTxt.Text = "";
            emailTxt.Text = "";
            addTxt.Text = "";
            isUpdated = false;
            enterName.Visible = false;
            enterNumber.Visible = false;
            enterEmail.Visible = false;
            enterAddress.Visible = false;
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUpdated) //if the system hasn't been properly updated
            {
                MessageBox.Show("Error: Must update the system first");
            }
            else //the system is properly updated
            {
                MessageBox.Show($@"The following enter has been entered:
                                Name: {nameTxt.Text}
                                Phone Number: {numberTxt.Text}
                                Email: {emailTxt.Text}
                                Address: {addTxt.Text}");
            }
        }
    }
}
