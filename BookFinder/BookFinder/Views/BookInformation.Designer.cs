﻿namespace BookFinder.Views
{
    partial class BookInformation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.IdtextBox2 = new System.Windows.Forms.TextBox();
            this.AuthortextBox3 = new System.Windows.Forms.TextBox();
            this.EditiontextBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(252, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(196, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(224, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(188, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(188, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edition : ";
            // 
            // NametextBox1
            // 
            this.NametextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox1.Location = new System.Drawing.Point(281, 204);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.ReadOnly = true;
            this.NametextBox1.Size = new System.Drawing.Size(214, 28);
            this.NametextBox1.TabIndex = 5;
            this.NametextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdtextBox2
            // 
            this.IdtextBox2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox2.Location = new System.Drawing.Point(281, 254);
            this.IdtextBox2.Name = "IdtextBox2";
            this.IdtextBox2.ReadOnly = true;
            this.IdtextBox2.Size = new System.Drawing.Size(214, 28);
            this.IdtextBox2.TabIndex = 6;
            this.IdtextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthortextBox3
            // 
            this.AuthortextBox3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthortextBox3.Location = new System.Drawing.Point(281, 307);
            this.AuthortextBox3.Name = "AuthortextBox3";
            this.AuthortextBox3.ReadOnly = true;
            this.AuthortextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthortextBox3.Size = new System.Drawing.Size(214, 28);
            this.AuthortextBox3.TabIndex = 7;
            this.AuthortextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditiontextBox4
            // 
            this.EditiontextBox4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditiontextBox4.Location = new System.Drawing.Point(281, 355);
            this.EditiontextBox4.Name = "EditiontextBox4";
            this.EditiontextBox4.ReadOnly = true;
            this.EditiontextBox4.Size = new System.Drawing.Size(214, 28);
            this.EditiontextBox4.TabIndex = 8;
            this.EditiontextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditiontextBox4);
            this.Controls.Add(this.AuthortextBox3);
            this.Controls.Add(this.IdtextBox2);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookInformation";
            this.Text = "BookInformation";
            this.Load += new System.EventHandler(this.BookInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.TextBox IdtextBox2;
        private System.Windows.Forms.TextBox AuthortextBox3;
        private System.Windows.Forms.TextBox EditiontextBox4;
        private System.Windows.Forms.Button button1;
    }
}