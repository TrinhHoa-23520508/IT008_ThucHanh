﻿namespace Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(327, 70);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(283, 26);
            this.Number1.TabIndex = 0;
            this.Number1.ContextMenuStripChanged += new System.EventHandler(this.Number1_ContextMenuStripChanged);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(327, 142);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(283, 26);
            this.Number2.TabIndex = 1;
            this.Number2.ContextMenuStripChanged += new System.EventHandler(this.Number2_ContextMenuStripChanged);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Addition.Location = new System.Drawing.Point(172, 218);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(80, 86);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Subtraction.Location = new System.Drawing.Point(282, 218);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(80, 86);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Multiplication.Location = new System.Drawing.Point(386, 218);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(83, 86);
            this.Multiplication.TabIndex = 4;
            this.Multiplication.Text = "x";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.button3_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Division.Location = new System.Drawing.Point(485, 218);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(84, 86);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 343);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 26);
            this.textBox3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab02-Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

