using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ML.AccessControl.BUS;

namespace TestWinForms
{
    public class TestCase : UserControl
    {
        public TextBox Result {get; set;}
        public BusManager BLL { get; set; }

        public TestCase()
        {
        }

        public TestCase(TextBox pResultTextBox, BusManager pBLL)
        {
            Result = pResultTextBox;
            BLL = pBLL;
        }
    }
}
