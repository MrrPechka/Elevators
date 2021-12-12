namespace Elevators_
{
    partial class FireAlarm
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
            this.firePlanDataGridView = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firePlanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firePlanDataGridView
            // 
            this.firePlanDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firePlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firePlanDataGridView.Location = new System.Drawing.Point(13, 13);
            this.firePlanDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.firePlanDataGridView.Name = "firePlanDataGridView";
            this.firePlanDataGridView.RowHeadersWidth = 51;
            this.firePlanDataGridView.Size = new System.Drawing.Size(774, 407);
            this.firePlanDataGridView.TabIndex = 8;
            this.firePlanDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.firePlanDataGridView_CellContentClick);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(61, 462);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(115, 32);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(232, 462);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(130, 32);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(424, 462);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(122, 32);
            this.apply_button.TabIndex = 11;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(615, 462);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(121, 32);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // FireAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.firePlanDataGridView);
            this.Name = "FireAlarm";
            this.Text = "FireAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.firePlanDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView firePlanDataGridView;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
    }
}