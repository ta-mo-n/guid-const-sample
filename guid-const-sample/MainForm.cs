using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace guid_const_sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// sample: システムの詳細を開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", GUIDConst.SYSTEM_DETAIL);
        }
    }
}
