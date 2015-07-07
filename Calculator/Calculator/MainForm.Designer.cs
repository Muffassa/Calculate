using System.ComponentModel;
using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(12, 13);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(220, 20);
            this.FirstArgument.TabIndex = 0;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(12, 39);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(220, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 65);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(220, 20);
            this.Result.TabIndex = 2;
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 91);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(50, 46);
            this.Multiplication.TabIndex = 13;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculate);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(68, 91);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(50, 46);
            this.Division.TabIndex = 15;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculate);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(124, 91);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(51, 46);
            this.Sum.TabIndex = 16;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Calculate);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(181, 91);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(51, 46);
            this.Subtraction.TabIndex = 17;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Calculate);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(12, 144);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(106, 23);
            this.Abs.TabIndex = 18;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(124, 144);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(108, 23);
            this.Sin.TabIndex = 19;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 175);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstArgument;
        private TextBox SecondArgument;
        private TextBox Result;
        private Button Multiplication;
        private Button Division;
        private Button Sum;
        private Button Subtraction;
        private Button Abs;
        private Button Sin;

    }
}

