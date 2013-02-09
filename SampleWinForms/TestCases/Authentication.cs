﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;

namespace SampleWinForms.TestCases
{
    public partial class Authentication : TestCase
    {
        public Authentication(TextBox pResultTextBox, BusManager pBLL)
            : base(pResultTextBox, pBLL)
        {
            InitializeComponent();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Guid SessionId = BLL.Sessions.Authenticate(tbLoginName.Text, tbPassword.Text, tbAccessPoint.Text);
            if (SessionId == Guid.Empty)
            {
                Result.Text = "Invalid login name or password!";
                tbSessionGuid.Text = "";
            }
            else
            {
                Result.Text = "Success!\r\nSession ID: " + SessionId.ToString();
                tbSessionGuid.Text = SessionId.ToString();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Guid SessionId = Guid.Parse(tbSessionGuid.Text);
            if (BLL.Sessions.EndSession(SessionId))
            {
                Result.Text = "OK! Session ended successfully";
            }
            else
            {
                Result.Text = "Error: Session cannot be found!";
            }
        }
    }
}
