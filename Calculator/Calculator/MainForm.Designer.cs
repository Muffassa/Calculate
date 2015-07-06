namespace Calculator
{
    partial class MainForm
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
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
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
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(12, 91);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(50, 46);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(68, 91);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(50, 46);
            this.buttonDivision.TabIndex = 15;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(124, 91);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(51, 46);
            this.buttonSum.TabIndex = 16;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(181, 91);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(51, 46);
            this.buttonSubtraction.TabIndex = 17;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 144);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
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

        private System.Windows.Forms.TextBox FirstArgument;
        private System.Windows.Forms.TextBox SecondArgument;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSubtraction;

    }
}

