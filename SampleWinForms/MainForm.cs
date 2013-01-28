using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;

namespace SampleWinForms
{
    public partial class MainForm : Form
    {
        BusManager _BLL = null;

        public MainForm()
        {
            _BLL = new BusManager(
               Type.GetType("ML.AccessControl.DAL.SQLite.DBManager, ML.AccessControl.DAL.SQLite", true),
               "my connection string",
               true);
            InitializeComponent();
        }
    }
}
