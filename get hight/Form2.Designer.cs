﻿namespace get_hight
{
    partial class Form2
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
            this.SpringOnioneing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelsource = new System.Windows.Forms.Label();
            this.SaveCSV = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(556, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "สรรพคุณ";
            // 
            // SpringOnioneing
            // 
            this.SpringOnioneing.AutoSize = true;
            this.SpringOnioneing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SpringOnioneing.Location = new System.Drawing.Point(766, 325);
            this.SpringOnioneing.Name = "SpringOnioneing";
            this.SpringOnioneing.Size = new System.Drawing.Size(21, 20);
            this.SpringOnioneing.TabIndex = 1;
            this.SpringOnioneing.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(553, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "แหล่งที่มา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(556, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "ราคาตามท้องตลาด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(766, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "...";
            // 
            // labelsource
            // 
            this.labelsource.AutoSize = true;
            this.labelsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelsource.Location = new System.Drawing.Point(766, 25);
            this.labelsource.Name = "labelsource";
            this.labelsource.Size = new System.Drawing.Size(29, 20);
            this.labelsource.TabIndex = 2;
            this.labelsource.Text = ".....";
            // 
            // SaveCSV
            // 
            this.SaveCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SaveCSV.Location = new System.Drawing.Point(311, 519);
            this.SaveCSV.Name = "SaveCSV";
            this.SaveCSV.Size = new System.Drawing.Size(157, 53);
            this.SaveCSV.TabIndex = 3;
            this.SaveCSV.Text = "Save to CSV";
            this.SaveCSV.UseVisualStyleBackColor = true;
            this.SaveCSV.Click += new System.EventHandler(this.SaveCSV_Click);
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonback.Location = new System.Drawing.Point(37, 528);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(150, 44);
            this.buttonback.TabIndex = 4;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::get_hight.Properties.Resources.tonhom1;
            this.pictureBox1.Location = new System.Drawing.Point(37, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::get_hight.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1471, 797);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.SaveCSV);
            this.Controls.Add(this.labelsource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SpringOnioneing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpringOnioneing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelsource;
        private System.Windows.Forms.Button SaveCSV;
        private System.Windows.Forms.Button buttonback;
    }
}