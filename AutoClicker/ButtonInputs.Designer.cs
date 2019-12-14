﻿namespace AutoClicker
{
    partial class ButtonInputs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbButtonEnable = new System.Windows.Forms.CheckBox();
            this.cbHold = new System.Windows.Forms.CheckBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // cbButtonEnable
            // 
            this.cbButtonEnable.AutoSize = true;
            this.cbButtonEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbButtonEnable.Location = new System.Drawing.Point(24, 15);
            this.cbButtonEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbButtonEnable.Name = "cbButtonEnable";
            this.cbButtonEnable.Size = new System.Drawing.Size(126, 24);
            this.cbButtonEnable.TabIndex = 1;
            this.cbButtonEnable.Text = "Button name";
            this.cbButtonEnable.UseVisualStyleBackColor = true;
            this.cbButtonEnable.Click += new System.EventHandler(this.CbButtonEnable_Click);
            // 
            // cbHold
            // 
            this.cbHold.AutoSize = true;
            this.cbHold.Enabled = false;
            this.cbHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbHold.Location = new System.Drawing.Point(24, 59);
            this.cbHold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHold.Name = "cbHold";
            this.cbHold.Size = new System.Drawing.Size(117, 24);
            this.cbHold.TabIndex = 2;
            this.cbHold.Text = "Hold button";
            this.cbHold.UseVisualStyleBackColor = true;
            this.cbHold.Click += new System.EventHandler(this.CbHold_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDelay.Location = new System.Drawing.Point(20, 104);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(97, 20);
            this.lblDelay.TabIndex = 3;
            this.lblDelay.Text = "Delay (ms):";
            // 
            // numDelay
            // 
            this.numDelay.Enabled = false;
            this.numDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numDelay.Location = new System.Drawing.Point(140, 102);
            this.numDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(160, 26);
            this.numDelay.TabIndex = 4;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.cbHold);
            this.Controls.Add(this.cbButtonEnable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ButtonInputs";
            this.Size = new System.Drawing.Size(320, 160);
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbButtonEnable;
        private System.Windows.Forms.CheckBox cbHold;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numDelay;
    }
}
