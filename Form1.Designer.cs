﻿namespace Course_work
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
            textBoxConsoleOutput = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxConsoleOutput
            // 
            textBoxConsoleOutput.Location = new Point(626, 258);
            textBoxConsoleOutput.Multiline = true;
            textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            textBoxConsoleOutput.Size = new Size(144, 81);
            textBoxConsoleOutput.TabIndex = 0;
            textBoxConsoleOutput.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(656, 31);
            button2.Name = "button2";
            button2.Size = new Size(114, 30);
            button2.TabIndex = 2;
            button2.Text = "Перевірка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBoxConsoleOutput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConsoleOutput;
        private Button button2;
    }
}
