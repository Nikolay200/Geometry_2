
namespace Geometry_2_WindowsFormsApp
{
    partial class RectangleForm
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
            this.RectanglePictureBox = new System.Windows.Forms.PictureBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglePerimeterButton = new System.Windows.Forms.Button();
            this.RectangleSquareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RectanglePictureBox
            // 
            this.RectanglePictureBox.Location = new System.Drawing.Point(50, 80);
            this.RectanglePictureBox.Name = "RectanglePictureBox";
            this.RectanglePictureBox.Size = new System.Drawing.Size(200, 200);
            this.RectanglePictureBox.TabIndex = 0;
            this.RectanglePictureBox.TabStop = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.Location = new System.Drawing.Point(328, 80);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(63, 20);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Длина";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(331, 126);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(73, 20);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Ширина";
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(411, 80);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleHeightTextBox.TabIndex = 3;
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(411, 126);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidthTextBox.TabIndex = 4;
            // 
            // RectanglePerimeterButton
            // 
            this.RectanglePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglePerimeterButton.Location = new System.Drawing.Point(335, 175);
            this.RectanglePerimeterButton.Name = "RectanglePerimeterButton";
            this.RectanglePerimeterButton.Size = new System.Drawing.Size(116, 42);
            this.RectanglePerimeterButton.TabIndex = 5;
            this.RectanglePerimeterButton.Text = "Периметр";
            this.RectanglePerimeterButton.UseVisualStyleBackColor = true;
            // 
            // RectangleSquareButton
            // 
            this.RectangleSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleSquareButton.Location = new System.Drawing.Point(335, 238);
            this.RectangleSquareButton.Name = "RectangleSquareButton";
            this.RectangleSquareButton.Size = new System.Drawing.Size(116, 42);
            this.RectangleSquareButton.TabIndex = 6;
            this.RectangleSquareButton.Text = "Площадь";
            this.RectangleSquareButton.UseVisualStyleBackColor = true;
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.RectangleSquareButton);
            this.Controls.Add(this.RectanglePerimeterButton);
            this.Controls.Add(this.RectangleWidthTextBox);
            this.Controls.Add(this.RectangleHeightTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.RectanglePictureBox);
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            ((System.ComponentModel.ISupportInitialize)(this.RectanglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RectanglePictureBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Button RectanglePerimeterButton;
        private System.Windows.Forms.Button RectangleSquareButton;
    }
}