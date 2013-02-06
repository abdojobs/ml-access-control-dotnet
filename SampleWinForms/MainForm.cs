using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;
using System.Data.Common;
using System.IO;
using SampleWinForms.Properties;
using ML.AccessControl.BUS.Common;
using System.Threading;

namespace SampleWinForms
{
    public partial class MainForm : Form
    {
        BusManager _BLL = null;

        public MainForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            InitializeComponent();
            ddlDataProvider.SelectedIndex = 0;
            ddlDataProvider_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages[] arrErrors;
            if(_BLL.Registration.CreateAccount(
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(20, 20),
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(5, 20),
                Utils.GenerateRandomChars(5,20) + "@" + Utils.GenerateRandomChars(4,8) + ".com",
                out arrErrors))
            {
                tbResult.Text = "OK";
            }
            else
            {
                tbResult.Text = "";
                foreach (MLAC_Error_Messages err in arrErrors)
                {
                    tbResult.Text += "Error: " + err + ": " + _BLL.GetErrorMessage((int)err) + "\n\r";
                }
            }
        }

        private void IsLoginNameAvailableAndValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (_BLL.Registration.IsLoginNameAvailableAndValid(tbIsLoginNameAvailableAndValid1.Text, out err))
                tbResult.Text = "OK";
            else
                tbResult.Text = "Error: " + err + "\r\n" + _BLL.GetErrorMessage((int)err);
        }

        private void IsEmailAvailableAndValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (_BLL.Registration.IsEmailAvailableAndValid(tbIsEmailAvailableAndValid1.Text, out err))
                tbResult.Text = "OK";
            else
                tbResult.Text = "Error: " + err + "\r\n" + _BLL.GetErrorMessage((int)err);
        }

        private void IsPersonNameValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (_BLL.Registration.IsPersonNameValid(tbIsPersonNameValid1.Text, out err))
                tbResult.Text = "OK";
            else
                tbResult.Text = "Error: " + err + "\r\n" + _BLL.GetErrorMessage((int)err);
        }

        private void IsPasswordValid_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages err;
            if (_BLL.Registration.IsPasswordValid(tbIsPasswordValid1.Text, out err))
                tbResult.Text = "OK";
            else
                tbResult.Text = "Error: " + err + "\r\n" + _BLL.GetErrorMessage((int)err);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MLAC_Error_Messages[] arrErrors;
            if (_BLL.Registration.CreateAccount(
                tbLoginName.Text,
                tbPassword.Text,
                tbFirstName.Text,
                tbLastName.Text,
                tbEmail.Text,
                out arrErrors))
            {
                tbResult.Text = "OK";
            }
            else
            {
                tbResult.Text = "";
                foreach (MLAC_Error_Messages err in arrErrors)
                {
                    tbResult.Text += "Error: " + err + ": " + _BLL.GetErrorMessage((int)err) + "\r\n";
                }
            }
        }

        private void ddlDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            //don't cache the DAL assembly as we need to switch it at runtime
            if (ddlDataProvider.SelectedIndex == 0)
            {
                _BLL = new BusManager(
                   Type.GetType(Settings.Default.SQLiteDALType, true),
                   Settings.Default.SQLiteConnectionString,
                   false);
            }
            else if (ddlDataProvider.SelectedIndex == 1)
            {
                _BLL = new BusManager(
                   Type.GetType(Settings.Default.SQLServerDALType, true),
                   Settings.Default.SQLServerConnectionString,
                   false);
            }
        }
    }
}
