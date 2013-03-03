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
    public partial class Roles : TestCase
    {
        public Roles(TextBox pResultTextBox, BusManager pBLL)
            : base(pResultTextBox, pBLL)
        {
            InitializeComponent();
        }

        private void btnListRoles_Click(object sender, EventArgs e)
        {
            ACRole[] roles = BLL.Roles.ListRoles();

            Result.Text = "";
            foreach (var role in roles)
                Result.Text += String.Format("Id: {0}, Name: {1}, System: {2}, Deletable: {3}, Hidden: {4}\r\n", role.Id, role.Name, role.IsSystem, role.IsDeletable, role.IsHidden);
        }

        private void btnListHiddenRoles_Click(object sender, EventArgs e)
        {
            ACRole[] roles = BLL.Roles.ListHiddenRoles();

            Result.Text = "";
            foreach (var role in roles)
                Result.Text += String.Format("Id: {0}, Name: {1}, System: {2}, Deletable: {3}, Hidden: {4}\r\n", role.Id, role.Name, role.IsSystem, role.IsDeletable, role.IsHidden);
        }

        private void btnListAllRoles_Click(object sender, EventArgs e)
        {
            ACRole[] roles = BLL.Roles.ListAllRoles();

            Result.Text = "";
            foreach (var role in roles)
                Result.Text += String.Format("Id: {0}, Name: {1}, System: {2}, Deletable: {3}, Hidden: {4}\r\n", role.Id, role.Name, role.IsSystem, role.IsDeletable, role.IsHidden);
        }
    }
}
