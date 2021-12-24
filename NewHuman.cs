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
    public partial class NewHuman : Form, ICreateHumanAction
    {
        public event Action<int, int, int> CreateHuman;
        public NewHuman()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.CreateHuman?.Invoke((int)countOfPeople.Value, (int)locationFloore.Value, (int)destinationFloor.Value);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
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
    }
}
