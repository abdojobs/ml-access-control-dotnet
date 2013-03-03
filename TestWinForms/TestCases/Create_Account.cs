using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS.Common;
using ML.AccessControl.BUS;
using ML.AccessControl.Common.Enums;

namespace TestWinForms.TestCases
{
    public partial class Create_Account : TestCase
    {
        public Create_Account(TextBox pResultTextBox, BusManager pBLL)
            : base(pResultTextBox, pBLL)
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages[] arrErrors;
            if (BLL.Registration.CreateAccount(
                tbLoginName.Text,
                tbPassword.Text,
                tbFirstName.Text,
                tbLastName.Text,
                tbEmail.Text,
                out arrErrors))
            {
                Result.Text = "OK";
            }
            else
            {
                Result.Text = "";
                foreach (MLAC_Error_Messages err in arrErrors)
                {
                    Result.Text += "Error: " + err + ": " + BLL.GetErrorMessage((int)err) + "\r\n";
                }
            }
        }

        private void btnRandomAccount_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages[] arrErrors;
            if (BLL.Registration.CreateAccount(
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(20, 20),
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(5, 20) + "@" + Utils.GenerateRandomChars(4, 8) + ".com",
                out arrErrors))
            {
                Result.Text = "OK";
            }
            else
            {
                Result.Text = "";
                foreach (MLAC_Error_Messages err in arrErrors)
                {
                    Result.Text += "Error: " + err + ": " + BLL.GetErrorMessage((int)err) + "\n\r";
                }
            }
        }
    }
}
