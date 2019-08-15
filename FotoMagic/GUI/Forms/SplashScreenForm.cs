using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoMagic.GUI.Forms
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void TmrSwitchForm_Tick(object sender, EventArgs e)
        {
            tmrSwitchForm.Stop();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
