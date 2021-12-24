using Models;
using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevators_
{
    public partial class Settings : Form, ISettingsView
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }
        public void LoadCurrentParameters(ISettings settings)
        {

        }
    }
}
