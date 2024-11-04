namespace Bai02
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
            this.components = new System.ComponentModel.Container();
            this.MyTime = new System.Windows.Forms.Timer(this.components);
            this.displayTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyTime
            // 
            this.MyTime.Tick += new System.EventHandler(this.MyTime_Tick);
            // 
            // displayTime
            // 
            this.displayTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayTime.BackColor = System.Drawing.SystemColors.Control;
            this.displayTime.Location = new System.Drawing.Point(134, 169);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(543, 53);
            this.displayTime.TabIndex = 0;
            this.displayTime.Text = "\r\n";
            this.displayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTime);
            this.Name = "Form1";
            this.Text = "Simple Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MyTime;
        protected internal System.Windows.Forms.Label displayTime;
    }
}

