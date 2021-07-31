
namespace Geometry_2_WindowsFormsApp
{
    partial class CircleForm
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
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.CirclePerimeterButton = new System.Windows.Forms.Button();
            this.CircleSquareButton = new System.Windows.Forms.Button();
            this.CirclePerimeterLabel = new System.Windows.Forms.Label();
            this.CircleSquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(345, 78);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Радиус";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(419, 78);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            // 
            // CirclePerimeterButton
            // 
            this.CirclePerimeterButton.Location = new System.Drawing.Point(348, 147);
            this.CirclePerimeterButton.Name = "CirclePerimeterButton";
            this.CirclePerimeterButton.Size = new System.Drawing.Size(108, 38);
            this.CirclePerimeterButton.TabIndex = 3;
            this.CirclePerimeterButton.Text = "Периметр";
            this.CirclePerimeterButton.UseVisualStyleBackColor = true;
            // 
            // CircleSquareButton
            // 
            this.CircleSquareButton.Location = new System.Drawing.Point(348, 211);
            this.CircleSquareButton.Name = "CircleSquareButton";
            this.CircleSquareButton.Size = new System.Drawing.Size(108, 39);
            this.CircleSquareButton.TabIndex = 4;
            this.CircleSquareButton.Text = "Площадь";
            this.CircleSquareButton.UseVisualStyleBackColor = true;
            // 
            // CirclePerimeterLabel
            // 
            this.CirclePerimeterLabel.AutoSize = true;
            this.CirclePerimeterLabel.Location = new System.Drawing.Point(493, 160);
            this.CirclePerimeterLabel.Name = "CirclePerimeterLabel";
            this.CirclePerimeterLabel.Size = new System.Drawing.Size(0, 13);
            this.CirclePerimeterLabel.TabIndex = 5;
            // 
            // CircleSquareLabel
            // 
            this.CircleSquareLabel.AutoSize = true;
            this.CircleSquareLabel.Location = new System.Drawing.Point(493, 224);
            this.CircleSquareLabel.Name = "CircleSquareLabel";
            this.CircleSquareLabel.Size = new System.Drawing.Size(0, 13);
            this.CircleSquareLabel.TabIndex = 6;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 342);
            this.Controls.Add(this.CircleSquareLabel);
            this.Controls.Add(this.CirclePerimeterLabel);
            this.Controls.Add(this.CircleSquareButton);
            this.Controls.Add(this.CirclePerimeterButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CircleForm";
            this.Text = "Круг";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Button CirclePerimeterButton;
        private System.Windows.Forms.Button CircleSquareButton;
        private System.Windows.Forms.Label CirclePerimeterLabel;
        private System.Windows.Forms.Label CircleSquareLabel;
    }
}