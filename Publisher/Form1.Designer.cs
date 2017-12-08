namespace Publisher
{
    partial class Form1
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
            this.cmdRed = new System.Windows.Forms.Button();
            this.cmdGreen = new System.Windows.Forms.Button();
            this.cmdBlue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRed
            // 
            this.cmdRed.BackColor = System.Drawing.Color.Red;
            this.cmdRed.Location = new System.Drawing.Point(12, 30);
            this.cmdRed.Name = "cmdRed";
            this.cmdRed.Size = new System.Drawing.Size(75, 69);
            this.cmdRed.TabIndex = 0;
            this.cmdRed.UseVisualStyleBackColor = false;
            this.cmdRed.Click += new System.EventHandler(this.cmdRed_Click);
            // 
            // cmdGreen
            // 
            this.cmdGreen.BackColor = System.Drawing.Color.Green;
            this.cmdGreen.Location = new System.Drawing.Point(102, 30);
            this.cmdGreen.Name = "cmdGreen";
            this.cmdGreen.Size = new System.Drawing.Size(75, 69);
            this.cmdGreen.TabIndex = 1;
            this.cmdGreen.UseVisualStyleBackColor = false;
            this.cmdGreen.Click += new System.EventHandler(this.cmdGreen_Click);
            // 
            // cmdBlue
            // 
            this.cmdBlue.BackColor = System.Drawing.Color.Blue;
            this.cmdBlue.Location = new System.Drawing.Point(203, 30);
            this.cmdBlue.Name = "cmdBlue";
            this.cmdBlue.Size = new System.Drawing.Size(75, 69);
            this.cmdBlue.TabIndex = 2;
            this.cmdBlue.UseVisualStyleBackColor = false;
            this.cmdBlue.Click += new System.EventHandler(this.cmdBlue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 151);
            this.Controls.Add(this.cmdBlue);
            this.Controls.Add(this.cmdGreen);
            this.Controls.Add(this.cmdRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRed;
        private System.Windows.Forms.Button cmdGreen;
        private System.Windows.Forms.Button cmdBlue;
    }
}

