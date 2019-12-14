namespace AutoClicker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_start = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lblStarted = new System.Windows.Forms.Label();
            this.biRightMouse = new AutoClicker.ButtonInputs();
            this.biLeftMouse = new AutoClicker.ButtonInputs();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(359, 197);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(117, 63);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_action_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartTime.Location = new System.Drawing.Point(311, 273);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(41, 20);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "time";
            this.lblStartTime.Visible = false;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(220, 197);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(117, 63);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP!";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // lblStarted
            // 
            this.lblStarted.AutoSize = true;
            this.lblStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStarted.Location = new System.Drawing.Point(216, 273);
            this.lblStarted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStarted.Name = "lblStarted";
            this.lblStarted.Size = new System.Drawing.Size(87, 20);
            this.lblStarted.TabIndex = 6;
            this.lblStarted.Text = "Started at:";
            this.lblStarted.Visible = false;
            // 
            // biRightMouse
            // 
            this.biRightMouse.AutoSize = true;
            this.biRightMouse.Location = new System.Drawing.Point(359, 22);
            this.biRightMouse.Margin = new System.Windows.Forms.Padding(5);
            this.biRightMouse.Name = "biRightMouse";
            this.biRightMouse.Size = new System.Drawing.Size(320, 160);
            this.biRightMouse.TabIndex = 5;
            // 
            // biLeftMouse
            // 
            this.biLeftMouse.AutoSize = true;
            this.biLeftMouse.Location = new System.Drawing.Point(14, 22);
            this.biLeftMouse.Margin = new System.Windows.Forms.Padding(0);
            this.biLeftMouse.Name = "biLeftMouse";
            this.biLeftMouse.Size = new System.Drawing.Size(320, 160);
            this.biLeftMouse.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 308);
            this.Controls.Add(this.lblStarted);
            this.Controls.Add(this.biRightMouse);
            this.Controls.Add(this.biLeftMouse);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Auto-Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lblStarted;
        private ButtonInputs biRightMouse;
        private ButtonInputs biLeftMouse;
    }
}

