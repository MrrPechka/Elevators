using Models;
using Models.Service;
using Models.Services;
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
    public partial class Simulation : Form
    {
        private ISimulation simulation;
        public Simulation()
        {
            InitializeComponent();
            InitTable();
        }

        public event Action StartSimulation;
        public event Action<decimal> SetSimulationSpeed;

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {

            this.StartSimulation?.Invoke();
            this.settingToolStripMenuItem.Enabled = false;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {

        }

        private void new_human_button_Click(object sender, EventArgs e)
        {
            NewHuman form = new NewHuman();
            //new NewHumanPresenter(form, new HumanCreateService(simulation.GetSystemData()));
            form.Show();
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
          //
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

        private void ResizeTable(int row, int column)
        {
            int rowFirst = this.simulationTable.ColumnCount;
            int columnFirst = this.simulationTable.RowCount;

            if(column < columnFirst)
            {
                for(int col = column; col < columnFirst; ++col)
                {
                    for(int rows = 0; rows < rowFirst; ++rows)
                    {
                        Control control = simulationTable.GetControlFromPosition(col, rows);
                        simulationTable.Controls.Remove(control);
                        control.Dispose();
                    }
                }
                this.simulationTable.ColumnCount = column;
            } else if(column > columnFirst)
            {
                this.simulationTable.ColumnCount = column;
                for(int col = columnFirst; col < column; ++col)
                {
                    simulationTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    simulationTable.Controls.Add(CreateTable("Elevator" + (col - 1).ToString()), col, 0);

                    for (int rows = 1; rows < rowFirst; ++rows)
                        simulationTable.Controls.Add(CreateTable("0"), col, rows);
                }
            }
            columnFirst = this.simulationTable.ColumnCount;

            if(row < rowFirst)
            {
                for(int rows = row; rows < rowFirst; ++rows)
                {
                    for(int col = 0; col < columnFirst; ++col)
                    {
                        Control control = simulationTable.GetControlFromPosition(col, rows);
                        simulationTable.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                for(int rows = 1; rows < row; ++rows)
                {
                    Control control = simulationTable.GetControlFromPosition(0, rows);
                    control.Text = (row - rows).ToString();
                }
                this.simulationTable.RowCount = row;
            } else if(row > rowFirst)
            {
                this.simulationTable.RowCount = row;
                for(int rows = rowFirst; rows < row; ++rows)
                {
                    simulationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
                    simulationTable.Controls.Add(CreateTable("0"), 0, rows);

                    for (int col = 1; col < columnFirst; ++col)
                        simulationTable.Controls.Add(CreateTable("0"), col, rows);
                }


                for (int rows = 1; rows < row; ++rows)
                {
                    Control control = simulationTable.GetControlFromPosition(0, rows);
                    control.Text = (row - rows).ToString();
                }
            }
        }

        private void SimulationSpeed(object sender, EventArgs e)
        {
            this.SetSimulationSpeed?.Invoke(Speed.Value);
        }
    }
}

