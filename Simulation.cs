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
    public partial class Simulation : Form
    {
        public Simulation()
        {
            InitializeComponent();
            InitTable();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pause_button_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void new_human_button_Click(object sender, EventArgs e)
        {
            NewHuman form = new NewHuman();
            form.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status form = new Status();
            form.Show();
        }

        private void fireAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireAlarm form = new FireAlarm();
            form.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            Statistics form = new Statistics();
            form.Show();
        }

        private void fire_alarm_button_Click(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }

        private void simulationTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private Label CreateTable(string str)
        {
            Label label = new Label
            {
                Text = str,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Anchor = AnchorStyles.Right | AnchorStyles.Left
            };
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            return label;
        }

        private void InitTable()
        {
            for (int i = 1; i < this.simulationTable.RowCount; i++)
                this.simulationTable.Controls.Add(CreateTable(i.ToString()), 0, this.simulationTable.RowCount - i);

            this.simulationTable.Controls.Add(CreateTable("Floor"), 0, 0);
            this.simulationTable.Controls.Add(CreateTable("Count of people"), 1, 0);

            for (int i = 2; i < this.simulationTable.ColumnCount; i++)
                this.simulationTable.Controls.Add(CreateTable("Elevator" + (i - 1)), i, 0);

            for (int i = 1; i < this.simulationTable.RowCount; i++)
                for (int j = 1; j < this.simulationTable.ColumnCount; j++)
                    this.simulationTable.Controls.Add(CreateTable(""), j, i);
        }
    }
}

