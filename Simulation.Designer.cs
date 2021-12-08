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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.simulationSpeedLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 186);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "New human";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "Fire alarm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(20, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(568, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Elevator 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(384, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Elevator 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Floor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(20, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(20, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(20, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(2, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Load";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.15266F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.84734F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label24, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(102, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.20118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.79881F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 401);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(59, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(255, 17);
            this.label24.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(132, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 16);
            this.label23.TabIndex = 19;
            this.label23.Text = "Count of people";
            // 
            // Simulation
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label simulationSpeedLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
    }
}