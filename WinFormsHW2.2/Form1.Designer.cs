namespace WinFormsHW2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Equal = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullAnswer = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.Blue;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equal.Location = new System.Drawing.Point(257, 440);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(103, 68);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtract.Location = new System.Drawing.Point(257, 300);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(103, 68);
            this.Subtract.TabIndex = 0;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(257, 372);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 68);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiply.Location = new System.Drawing.Point(257, 230);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(103, 64);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(176, 440);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 64);
            this.Divide.TabIndex = 1;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(95, 440);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 64);
            this.Zero.TabIndex = 1;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.btnN_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(14, 440);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 62);
            this.delete.TabIndex = 1;
            this.delete.Text = "⌫";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(176, 370);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 64);
            this.Three.TabIndex = 1;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(176, 302);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 64);
            this.Six.TabIndex = 1;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(176, 230);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 64);
            this.Nine.TabIndex = 1;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Two.Location = new System.Drawing.Point(95, 370);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 64);
            this.Two.TabIndex = 1;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(95, 302);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 64);
            this.Five.TabIndex = 1;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(95, 230);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 64);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.btnN_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(14, 370);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 64);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(14, 302);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 64);
            this.Four.TabIndex = 1;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(12, 230);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(75, 64);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.btnN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 2;
            // 
            // fullAnswer
            // 
            this.fullAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullAnswer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fullAnswer.Location = new System.Drawing.Point(284, 130);
            this.fullAnswer.Name = "fullAnswer";
            this.fullAnswer.Size = new System.Drawing.Size(85, 31);
            this.fullAnswer.TabIndex = 3;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Answer.Location = new System.Drawing.Point(266, 180);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(103, 47);
            this.Answer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 520);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.fullAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.One);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Equal);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Equal;
        private Button Subtract;
        private Button Add;
        private Button Multiply;
        private Button Divide;
        private Button Zero;
        private Button delete;
        private Button Three;
        private Button Six;
        private Button Nine;
        private Button Two;
        private Button Five;
        private Button Eight;
        private Button One;
        private Button Four;
        private Button Seven;
        private Label label1;
        private Label fullAnswer;
        private Label Answer;
    }
}