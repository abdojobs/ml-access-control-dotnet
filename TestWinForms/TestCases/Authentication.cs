using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;

namespace TestWinForms.TestCases
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
                Result.Text = "OK! Session ended successfully";
            else
                Result.Text = "Error: Session cannot be found!";
        }

        private void btnKeepAlive_Click(object sender, EventArgs e)
        {
            Guid SessionId = Guid.Parse(tbSessionGuid.Text);
            if (BLL.Sessions.KeepAlive(SessionId, false))
                Result.Text = "OK! Session updated successfully";
            else
                Result.Text = "!!!!! Session was not found";
        }

        private void btnEndOldSessions_Click(object sender, EventArgs e)
        {
            int iSessionsEnded = BLL.Sessions.EndOldSessions();
            Result.Text = iSessionsEnded.ToString() + " Sessions ended successfully";

        }

        private void btnKeepAliveAndEndOldSessions_Click(object sender, EventArgs e)
        {
            Guid SessionId = Guid.Parse(tbSessionGuid.Text);
            if (BLL.Sessions.KeepAlive(SessionId))
                Result.Text = "OK! Expired Sessions ended successfully \r\nSession updated successfully";
            else
                Result.Text = "OK! Expired Sessions ended successfully \r\n!!!!! Session was not found";
        }

        private void btnDeleteAllSessions_Click(object sender, EventArgs e)
        {
            int iSessionsEnded = BLL.Sessions.EndAllSessions();
            Result.Text = iSessionsEnded.ToString() + " Sessions ended successfully";
        }
    }
}
