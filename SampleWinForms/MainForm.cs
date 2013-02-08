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
using SampleWinForms.TestCases;

namespace SampleWinForms
{
    public partial class MainForm : Form
    {
        BusManager _BLL = null;
        Dictionary<string, Type> _TestCases = new Dictionary<string, Type>()
            {
                {"Validations 1",typeof(Validations_1)},
                {"Create Account",typeof(Create_Account)},
                {"Authentication",typeof(Authentication)}
            };

        public MainForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            InitializeComponent();

            ddlOperation.DisplayMember = "Key";
            ddlOperation.ValueMember = "Value";
            ddlOperation.DataSource = new BindingSource(_TestCases, null);


            ddlDataProvider.SelectedIndex = 0;
            ddlDataProvider_SelectedIndexChanged(null, EventArgs.Empty);

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
            ((TestCase)MainPanel.Controls[0]).BLL = _BLL;
        }

        private void ddlOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add((TestCase)Activator.CreateInstance((Type)ddlOperation.SelectedValue, new object[] { tbResult, _BLL }));
        }
    }
}
