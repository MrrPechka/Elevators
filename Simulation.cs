﻿using System;
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
    }
}

