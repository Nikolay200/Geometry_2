﻿
namespace Geometry_2_WindowsFormsApp
{
    partial class TriangleForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Side1Label = new System.Windows.Forms.Label();
            this.Side2Label = new System.Windows.Forms.Label();
            this.Side3Label = new System.Windows.Forms.Label();
            this.Side1TextBox = new System.Windows.Forms.TextBox();
            this.Side2TextBox = new System.Windows.Forms.TextBox();
            this.Side3TextBox = new System.Windows.Forms.TextBox();
            this.TrianglePerimeterButton = new System.Windows.Forms.Button();
            this.TriangleSquareButton = new System.Windows.Forms.Button();
            this.TrianglePerimeterLabel = new System.Windows.Forms.Label();
            this.TriangleSquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Side1Label
            // 
            this.Side1Label.AutoSize = true;
            this.Side1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side1Label.Location = new System.Drawing.Point(304, 80);
            this.Side1Label.Name = "Side1Label";
            this.Side1Label.Size = new System.Drawing.Size(96, 20);
            this.Side1Label.TabIndex = 1;
            this.Side1Label.Text = "1 Сторона";
            // 
            // Side2Label
            // 
            this.Side2Label.AutoSize = true;
            this.Side2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side2Label.Location = new System.Drawing.Point(304, 114);
            this.Side2Label.Name = "Side2Label";
            this.Side2Label.Size = new System.Drawing.Size(96, 20);
            this.Side2Label.TabIndex = 2;
            this.Side2Label.Text = "2 Сторона";
            // 
            // Side3Label
            // 
            this.Side3Label.AutoSize = true;
            this.Side3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side3Label.Location = new System.Drawing.Point(304, 148);
            this.Side3Label.Name = "Side3Label";
            this.Side3Label.Size = new System.Drawing.Size(96, 20);
            this.Side3Label.TabIndex = 3;
            this.Side3Label.Text = "3 Сторона";
            // 
            // Side1TextBox
            // 
            this.Side1TextBox.Location = new System.Drawing.Point(418, 80);
            this.Side1TextBox.Name = "Side1TextBox";
            this.Side1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Side1TextBox.TabIndex = 4;
            // 
            // Side2TextBox
            // 
            this.Side2TextBox.Location = new System.Drawing.Point(418, 116);
            this.Side2TextBox.Name = "Side2TextBox";
            this.Side2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Side2TextBox.TabIndex = 5;
            // 
            // Side3TextBox
            // 
            this.Side3TextBox.Location = new System.Drawing.Point(418, 150);
            this.Side3TextBox.Name = "Side3TextBox";
            this.Side3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Side3TextBox.TabIndex = 6;
            // 
            // TrianglePerimeterButton
            // 
            this.TrianglePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrianglePerimeterButton.Location = new System.Drawing.Point(308, 186);
            this.TrianglePerimeterButton.Name = "TrianglePerimeterButton";
            this.TrianglePerimeterButton.Size = new System.Drawing.Size(111, 43);
            this.TrianglePerimeterButton.TabIndex = 7;
            this.TrianglePerimeterButton.Text = "Периметр";
            this.TrianglePerimeterButton.UseVisualStyleBackColor = true;
            // 
            // TriangleSquareButton
            // 
            this.TriangleSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriangleSquareButton.Location = new System.Drawing.Point(308, 237);
            this.TriangleSquareButton.Name = "TriangleSquareButton";
            this.TriangleSquareButton.Size = new System.Drawing.Size(111, 43);
            this.TriangleSquareButton.TabIndex = 8;
            this.TriangleSquareButton.Text = "Площадь";
            this.TriangleSquareButton.UseVisualStyleBackColor = true;
            // 
            // TrianglePerimeterLabel
            // 
            this.TrianglePerimeterLabel.AutoSize = true;
            this.TrianglePerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrianglePerimeterLabel.Location = new System.Drawing.Point(450, 197);
            this.TrianglePerimeterLabel.Name = "TrianglePerimeterLabel";
            this.TrianglePerimeterLabel.Size = new System.Drawing.Size(18, 20);
            this.TrianglePerimeterLabel.TabIndex = 9;
            this.TrianglePerimeterLabel.Text = "0";
            // 
            // TriangleSquareLabel
            // 
            this.TriangleSquareLabel.AutoSize = true;
            this.TriangleSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriangleSquareLabel.Location = new System.Drawing.Point(450, 248);
            this.TriangleSquareLabel.Name = "TriangleSquareLabel";
            this.TriangleSquareLabel.Size = new System.Drawing.Size(18, 20);
            this.TriangleSquareLabel.TabIndex = 10;
            this.TriangleSquareLabel.Text = "0";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TriangleSquareLabel);
            this.Controls.Add(this.TrianglePerimeterLabel);
            this.Controls.Add(this.TriangleSquareButton);
            this.Controls.Add(this.TrianglePerimeterButton);
            this.Controls.Add(this.Side3TextBox);
            this.Controls.Add(this.Side2TextBox);
            this.Controls.Add(this.Side1TextBox);
            this.Controls.Add(this.Side3Label);
            this.Controls.Add(this.Side2Label);
            this.Controls.Add(this.Side1Label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TriangleForm";
            this.Text = "TriangleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Side1Label;
        private System.Windows.Forms.Label Side2Label;
        private System.Windows.Forms.Label Side3Label;
        private System.Windows.Forms.TextBox Side1TextBox;
        private System.Windows.Forms.TextBox Side2TextBox;
        private System.Windows.Forms.TextBox Side3TextBox;
        private System.Windows.Forms.Button TrianglePerimeterButton;
        private System.Windows.Forms.Button TriangleSquareButton;
        private System.Windows.Forms.Label TrianglePerimeterLabel;
        private System.Windows.Forms.Label TriangleSquareLabel;
    }
}