namespace Elevators_
{
    partial class NewHuman
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
            this.countOfPeople = new System.Windows.Forms.NumericUpDown();
            this.locationFloore = new System.Windows.Forms.NumericUpDown();
            this.destinationFloor = new System.Windows.Forms.NumericUpDown();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.simulationSpeedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationFloore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // countOfPeople
            // 
            this.countOfPeople.Location = new System.Drawing.Point(94, 29);
            this.countOfPeople.Name = "countOfPeople";
            this.countOfPeople.Size = new System.Drawing.Size(104, 22);
            this.countOfPeople.TabIndex = 0;
            // 
            // locationFloore
            // 
            this.locationFloore.Location = new System.Drawing.Point(268, 29);
            this.locationFloore.Name = "locationFloore";
            this.locationFloore.Size = new System.Drawing.Size(100, 22);
            this.locationFloore.TabIndex = 1;
            // 
            // destinationFloor
            // 
            this.destinationFloor.Location = new System.Drawing.Point(458, 29);
            this.destinationFloor.Name = "destinationFloor";
            this.destinationFloor.Size = new System.Drawing.Size(105, 22);
            this.destinationFloor.TabIndex = 2;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(174, 57);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(110, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(356, 57);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(112, 23);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // simulationSpeedLabel
            // 
            this.simulationSpeedLabel.AutoSize = true;
            this.simulationSpeedLabel.Location = new System.Drawing.Point(91, 9);
            this.simulationSpeedLabel.Name = "simulationSpeedLabel";
            this.simulationSpeedLabel.Size = new System.Drawing.Size(108, 17);
            this.simulationSpeedLabel.TabIndex = 7;
            this.simulationSpeedLabel.Text = "Count of people";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination";
            // 
            // NewHuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 102);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulationSpeedLabel);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.destinationFloor);
            this.Controls.Add(this.locationFloore);
            this.Controls.Add(this.countOfPeople);
            this.Name = "NewHuman";
            this.Text = "NewHuman";
            ((System.ComponentModel.ISupportInitialize)(this.countOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationFloore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown countOfPeople;
        private System.Windows.Forms.NumericUpDown locationFloore;
        private System.Windows.Forms.NumericUpDown destinationFloor;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label simulationSpeedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}