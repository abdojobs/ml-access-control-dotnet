using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;
using ML.AccessControl.Common.Entities;

namespace TestWinForms.TestCases
{
    public partial class Users : TestCase
    {
        public Users(TextBox pResultTextBox, BusManager pBLL)
            : base(pResultTextBox, pBLL)
        {
            InitializeComponent();
        }

        private void btnLoadUserInfo_Click(object sender, EventArgs e)
        {
            ACUser user = BLL.Users.LoadUserInfo(int.Parse(tbUserId.Text));
            Result.Text = "";
            if (user != null)
                Result.Text += String.Format("Id: {0}, Name: {1} {2}, Email: {3}\r\n", user.Id, user.FirstName, user.LastName, user.Email);
            else
                Result.Text += "User record not found\r\n";
        }
    }
}
