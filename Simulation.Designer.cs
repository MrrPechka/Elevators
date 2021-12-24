namespace Elevators_
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.simulationSpeedLabel = new System.Windows.Forms.Label();
            this.new_human_button = new System.Windows.Forms.Button();
            this.fire_alarm_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(2, 38);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 34);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(2, 78);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 33);
            this.stop_button.TabIndex = 1;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Location = new System.Drawing.Point(2, 117);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 32);
            this.pause_button.TabIndex = 2;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(0, 186);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(75, 22);
            this.Speed.TabIndex = 5;
            this.Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed.ValueChanged += new System.EventHandler(this.SimulationSpeed);
            // 
            // simulationSpeedLabel
            // 
            this.simulationSpeedLabel.AutoSize = true;
            this.simulationSpeedLabel.Location = new System.Drawing.Point(12, 166);
            this.simulationSpeedLabel.Name = "simulationSpeedLabel";
            this.simulationSpeedLabel.Size = new System.Drawing.Size(49, 17);
            this.simulationSpeedLabel.TabIndex = 6;
            this.simulationSpeedLabel.Text = "Speed";
            // 
            // new_human_button
            // 
            this.new_human_button.Location = new System.Drawing.Point(0, 214);
            this.new_human_button.Name = "new_human_button";
            this.new_human_button.Size = new System.Drawing.Size(77, 45);
            this.new_human_button.TabIndex = 7;
            this.new_human_button.Text = "New human";
            this.new_human_button.UseVisualStyleBackColor = true;
            this.new_human_button.Click += new System.EventHandler(this.new_human_button_Click);
            // 
            // fire_alarm_button
            // 
            this.fire_alarm_button.Location = new System.Drawing.Point(0, 265);
            this.fire_alarm_button.Name = "fire_alarm_button";
            this.fire_alarm_button.Size = new System.Drawing.Size(77, 44);
            this.fire_alarm_button.TabIndex = 8;
            this.fire_alarm_button.Text = "Fire alarm";
            this.fire_alarm_button.UseVisualStyleBackColor = true;
            this.fire_alarm_button.Click += new System.EventHandler(this.fire_alarm_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(2, 368);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(2, 397);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fireAlarmToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.settingsToolStripMenuItem.Text = "More";
            // 
            // fireAlarmToolStripMenuItem
            // 
            this.fireAlarmToolStripMenuItem.Name = "fireAlarmToolStripMenuItem";
            this.fireAlarmToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.fireAlarmToolStripMenuItem.Text = "Fire alarm";
            this.fireAlarmToolStripMenuItem.Click += new System.EventHandler(this.fireAlarmToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // simulationTable
            // 
            this.simulationTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.simulationTable.ColumnCount = 4;
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.15266F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.84734F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.simulationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.simulationTable.Location = new System.Drawing.Point(102, 38);
            this.simulationTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simulationTable.Name = "simulationTable";
            this.simulationTable.RowCount = 5;
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.simulationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.simulationTable.Size = new System.Drawing.Size(818, 517);
            this.simulationTable.TabIndex = 12;
            this.simulationTable.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationTable_Paint);
            // 
            // Simulation
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 566);
            this.Controls.Add(this.simulationTable);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.fire_alarm_button);
            this.Controls.Add(this.new_human_button);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.Label simulationSpeedLabel;
        private System.Windows.Forms.Button new_human_button;
        private System.Windows.Forms.Button fire_alarm_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel simulationTable;
    }
}