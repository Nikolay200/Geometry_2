
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
            this.CirclePictureBox = new System.Windows.Forms.PictureBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.CirclePerimeterButton = new System.Windows.Forms.Button();
            this.CircleSquareButton = new System.Windows.Forms.Button();
            this.CirclePerimeterLabel = new System.Windows.Forms.Label();
            this.CircleSquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CirclePictureBox
            // 
            this.CirclePictureBox.Image = global::Geometry_2_WindowsFormsApp.Properties.Resources.Circle_simple;
            this.CirclePictureBox.Location = new System.Drawing.Point(50, 80);
            this.CirclePictureBox.Name = "CirclePictureBox";
            this.CirclePictureBox.Size = new System.Drawing.Size(200, 200);
            this.CirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CirclePictureBox.TabIndex = 0;
            this.CirclePictureBox.TabStop = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiusLabel.Location = new System.Drawing.Point(296, 80);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(69, 20);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Радиус";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(370, 80);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            // 
            // CirclePerimeterButton
            // 
            this.CirclePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CirclePerimeterButton.Location = new System.Drawing.Point(299, 162);
            this.CirclePerimeterButton.Name = "CirclePerimeterButton";
            this.CirclePerimeterButton.Size = new System.Drawing.Size(108, 45);
            this.CirclePerimeterButton.TabIndex = 3;
            this.CirclePerimeterButton.Text = "Периметр";
            this.CirclePerimeterButton.UseVisualStyleBackColor = true;
            this.CirclePerimeterButton.Click += new System.EventHandler(this.CirclePerimeterButton_Click);
            // 
            // CircleSquareButton
            // 
            this.CircleSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleSquareButton.Location = new System.Drawing.Point(299, 236);
            this.CircleSquareButton.Name = "CircleSquareButton";
            this.CircleSquareButton.Size = new System.Drawing.Size(108, 46);
            this.CircleSquareButton.TabIndex = 4;
            this.CircleSquareButton.Text = "Площадь";
            this.CircleSquareButton.UseVisualStyleBackColor = true;
            this.CircleSquareButton.Click += new System.EventHandler(this.CircleSquareButton_Click);
            // 
            // CirclePerimeterLabel
            // 
            this.CirclePerimeterLabel.AutoSize = true;
            this.CirclePerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CirclePerimeterLabel.Location = new System.Drawing.Point(441, 177);
            this.CirclePerimeterLabel.Name = "CirclePerimeterLabel";
            this.CirclePerimeterLabel.Size = new System.Drawing.Size(18, 20);
            this.CirclePerimeterLabel.TabIndex = 5;
            this.CirclePerimeterLabel.Text = "0";
            // 
            // CircleSquareLabel
            // 
            this.CircleSquareLabel.AutoSize = true;
            this.CircleSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleSquareLabel.Location = new System.Drawing.Point(441, 249);
            this.CircleSquareLabel.Name = "CircleSquareLabel";
            this.CircleSquareLabel.Size = new System.Drawing.Size(18, 20);
            this.CircleSquareLabel.TabIndex = 6;
            this.CircleSquareLabel.Text = "0";
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.CircleSquareLabel);
            this.Controls.Add(this.CirclePerimeterLabel);
            this.Controls.Add(this.CircleSquareButton);
            this.Controls.Add(this.CirclePerimeterButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.CirclePictureBox);
            this.Name = "CircleForm";
            this.Text = "Круг";
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CirclePictureBox;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Button CirclePerimeterButton;
        private System.Windows.Forms.Button CircleSquareButton;
        private System.Windows.Forms.Label CirclePerimeterLabel;
        private System.Windows.Forms.Label CircleSquareLabel;
    }
}