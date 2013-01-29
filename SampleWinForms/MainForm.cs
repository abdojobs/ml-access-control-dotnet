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

namespace SampleWinForms
{
    public partial class MainForm : Form
    {
        BusManager _BLL = null;

        public MainForm()
        {
            _BLL = new BusManager(
               Type.GetType("ML.AccessControl.DAL.SQLite.DBManager, ML.AccessControl.DAL.SQLite", true),
                "Data Source=" + Settings.Default.SQLiteDBFile + ";Pooling=true;FailIfMissing=true",
               true);
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
    }
}
