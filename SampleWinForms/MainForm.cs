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
            _BLL = new BusManager(
               Type.GetType("ML.AccessControl.DAL.SQLite.DBFactory, ML.AccessControl.DAL.SQLite", true),
                "Data Source=" + Settings.Default.SQLiteDBFile + ";Pooling=true;FailIfMissing=true");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _BLL.Users.CreateUser(
                Utils.GenerateRandomChars(5, 10),
                Utils.GenerateRandomChars(20, 20),
                Utils.GenerateRandomChars(5, 10),
                Utils.GenerateRandomChars(5, 10),
                Utils.GenerateRandomChars(5,10) + "@" + Utils.GenerateRandomChars(4,8) + ".com",
                true).ToString();
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
    }
}
