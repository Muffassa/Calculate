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
            this.Pow = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.QuickSort = new System.Windows.Forms.Button();
            this.CountingSort = new System.Windows.Forms.Button();
            this.HeapSort = new System.Windows.Forms.Button();
            this.GnomeSort = new System.Windows.Forms.Button();
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
            this.Multiplication.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(68, 91);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(50, 46);
            this.Division.TabIndex = 15;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(124, 91);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(51, 46);
            this.Sum.TabIndex = 16;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(181, 91);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(51, 46);
            this.Subtraction.TabIndex = 17;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(13, 143);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(50, 46);
            this.Abs.TabIndex = 18;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 195);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(106, 45);
            this.Sin.TabIndex = 19;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(69, 143);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(51, 45);
            this.Pow.TabIndex = 20;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(126, 144);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(51, 45);
            this.Sqrt.TabIndex = 21;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(181, 144);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(51, 44);
            this.Factorial.TabIndex = 22;
            this.Factorial.Text = "x!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(124, 195);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(108, 45);
            this.Cos.TabIndex = 23;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(12, 246);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(49, 44);
            this.QuickSort.TabIndex = 24;
            this.QuickSort.Text = "QuickSort";
            this.QuickSort.UseVisualStyleBackColor = true;
            // 
            // CountingSort
            // 
            this.CountingSort.Location = new System.Drawing.Point(71, 246);
            this.CountingSort.Name = "CountingSort";
            this.CountingSort.Size = new System.Drawing.Size(49, 44);
            this.CountingSort.TabIndex = 25;
            this.CountingSort.Text = "CountingSort";
            this.CountingSort.UseVisualStyleBackColor = true;
            // 
            // HeapSort
            // 
            this.HeapSort.Location = new System.Drawing.Point(128, 246);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(49, 44);
            this.HeapSort.TabIndex = 26;
            this.HeapSort.Text = "HeapSort";
            this.HeapSort.UseVisualStyleBackColor = true;
            this.HeapSort.Click += new System.EventHandler(this.SortingMassivs);
            // 
            // GnomeSort
            // 
            this.GnomeSort.Location = new System.Drawing.Point(183, 246);
            this.GnomeSort.Name = "GnomeSort";
            this.GnomeSort.Size = new System.Drawing.Size(49, 44);
            this.GnomeSort.TabIndex = 27;
            this.GnomeSort.Text = "GnomeSort";
            this.GnomeSort.UseVisualStyleBackColor = true;
            this.GnomeSort.Click += new System.EventHandler(this.SortingMassivs);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 295);
            this.Controls.Add(this.GnomeSort);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.CountingSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Pow);
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
        private Button Pow;
        private Button Sqrt;
        private Button Factorial;
        private Button Cos;
        private Button QuickSort;
        private Button CountingSort;
        private Button HeapSort;
        private Button GnomeSort;

    }
}

