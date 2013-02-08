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

namespace SampleWinForms.TestCases
{
    public partial class Validations_1 : TestCase
    {
        public Validations_1(TextBox pResultTextBox, BusManager pBLL)
            : base(pResultTextBox, pBLL)
        {
            InitializeComponent();
        }

        private void IsLoginNameAvailableAndValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (BLL.Registration.IsLoginNameAvailableAndValid(tbIsLoginNameAvailableAndValid1.Text, out err))
                Result.Text = "OK";
            else
                Result.Text = "Error: " + err + "\r\n" + BLL.GetErrorMessage((int)err);
        }

        private void IsEmailAvailableAndValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (BLL.Registration.IsEmailAvailableAndValid(tbIsEmailAvailableAndValid1.Text, out err))
                Result.Text = "OK";
            else
                Result.Text = "Error: " + err + "\r\n" + BLL.GetErrorMessage((int)err);
        }

        private void IsPersonNameValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (BLL.Registration.IsPersonNameValid(tbIsPersonNameValid1.Text, out err))
                Result.Text = "OK";
            else
                Result.Text = "Error: " + err + "\r\n" + BLL.GetErrorMessage((int)err);
        }

        private void IsPasswordValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (BLL.Registration.IsPasswordValid(tbIsPasswordValid1.Text, out err))
                Result.Text = "OK";
            else
                Result.Text = "Error: " + err + "\r\n" + BLL.GetErrorMessage((int)err);
        }

    }
}
