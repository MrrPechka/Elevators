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
    public partial class SimulationForm : Form, IMainView
    {
        private ISimulation simulation;
        private bool isSimulationLoaded = false;
        public SimulationForm()
        {
            InitializeComponent();
            InitTable();
            InitSimulation();
        }

        public event Action StartSimulation;
        public event Action PauseSimulation;
        public event IMainView.Status StopSimulation;
        public event Action<decimal> SetSpeed;
        private delegate void UpdateState(SystemData systemData);

        public void ShowState(SystemData systemData)
        {
            if (simulationTable.InvokeRequired)
                simulationTable.Invoke(new UpdateState(ShowStateInForm), systemData);
            else ShowStateInForm(systemData);
        }
        public void ShowStateInForm(SystemData systemData) 
        {
            int[] a = new int[systemData.GetSettings().FloorsNumber];
            int[] b = new int[systemData.GetSettings().FloorsNumber];
            int[] c = new int[systemData.GetSettings().FloorsNumber];
            Color[] d = new Color[b.Length];
            if (this.simulationTable.RowCount != a.Length + 1 || this.simulationTable.ColumnCount != b.Length + 2)
            {
                this.simulationTable.SuspendLayout();
                this.ResizeTable(a.Length + 1, b.Length + 2);
                this.simulationTable.ResumeLayout(false);
                this.simulationTable.PerformLayout();
            }
            int i = 0;   
            foreach (Floor floor in systemData.GetFloor())
            {
                a[i] = floor.getFullHumanCount();
                i++;
            }
            i = 0;
            foreach (Elevator elevator in systemData.GetElevator())
            {
                c[i] = elevator.GetKeepeFloor();
                b[i] = elevator.GetHumanCount();
                d[i] = elevator.status == Elevator.ElevatorStatus.WaitOpened ? Color.Green : Color.Red;
                i++;
            }
            for (int j = this.simulationTable.RowCount - 1; j > 0; j--)
            {
                Control control = this.simulationTable.GetControlFromPosition(1, j);
                if (control != null)
                    control.Text = a[this.simulationTable.RowCount - j - 1].ToString();
                else MessageBox.Show("I'm sorry, please try again");
                for (i = 2; i < this.simulationTable.ColumnCount; i++)
                {
                    Control controli = this.simulationTable.GetControlFromPosition(i, j);
                    controli.Text = (this.simulationTable.RowCount - j - 1 == c[i - 2]) ? b[i - 2].ToString() : null;
                    controli.Dock = DockStyle.Fill;
                    controli.BackColor = (this.simulationTable.RowCount - j - 1 == c[i - 2]) ? d[i - 2] : Color.Transparent;
                }
            }
        }

        public void ShowStatus(SystemData systemData) {
            
        }
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
            new NewHumanPresenter(form, new HumanCreateService(simulation.GetSystemData()));
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
            SettingsPresenter settingsPresenter = new SettingsPresenter(form, new SettingsService(simulation.GetSystemData()), simulation.GetService());
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

        public void InitSimulation()
        {
            if (!isSimulationLoaded)
            {
                simulation = new Simulation(5, 2);
                _ = new Presenter(this, new Service(simulation));
                isSimulationLoaded = true;
            }
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
            this.SetSpeed?.Invoke(Speed.Value);
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

