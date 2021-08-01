
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
            this.RectanglePerimeterLabel = new System.Windows.Forms.Label();
            this.RectangleSquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RectanglePictureBox
            // 
            this.RectanglePictureBox.Image = global::Geometry_2_WindowsFormsApp.Properties.Resources.Rectangle_simple;
            this.RectanglePictureBox.Location = new System.Drawing.Point(20, 10);
            this.RectanglePictureBox.Name = "RectanglePictureBox";
            this.RectanglePictureBox.Size = new System.Drawing.Size(200, 200);
            this.RectanglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RectanglePictureBox.TabIndex = 0;
            this.RectanglePictureBox.TabStop = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.Location = new System.Drawing.Point(14, 235);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(63, 20);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Длина";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(14, 281);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(73, 20);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Ширина";
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(94, 235);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleHeightTextBox.TabIndex = 3;
            this.RectangleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectangleHeightTextBox_KeyPress);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(94, 281);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidthTextBox.TabIndex = 4;
            this.RectangleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectangleWidthTextBox_KeyPress);
            // 
            // RectanglePerimeterButton
            // 
            this.RectanglePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglePerimeterButton.Location = new System.Drawing.Point(18, 330);
            this.RectanglePerimeterButton.Name = "RectanglePerimeterButton";
            this.RectanglePerimeterButton.Size = new System.Drawing.Size(116, 42);
            this.RectanglePerimeterButton.TabIndex = 5;
            this.RectanglePerimeterButton.Text = "Периметр";
            this.RectanglePerimeterButton.UseVisualStyleBackColor = true;
            this.RectanglePerimeterButton.Click += new System.EventHandler(this.RectanglePerimeterButton_Click);
            // 
            // RectangleSquareButton
            // 
            this.RectangleSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleSquareButton.Location = new System.Drawing.Point(18, 393);
            this.RectangleSquareButton.Name = "RectangleSquareButton";
            this.RectangleSquareButton.Size = new System.Drawing.Size(116, 42);
            this.RectangleSquareButton.TabIndex = 6;
            this.RectangleSquareButton.Text = "Площадь";
            this.RectangleSquareButton.UseVisualStyleBackColor = true;
            this.RectangleSquareButton.Click += new System.EventHandler(this.RectangleSquareButton_Click);
            // 
            // RectanglePerimeterLabel
            // 
            this.RectanglePerimeterLabel.AutoSize = true;
            this.RectanglePerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglePerimeterLabel.Location = new System.Drawing.Point(165, 342);
            this.RectanglePerimeterLabel.Name = "RectanglePerimeterLabel";
            this.RectanglePerimeterLabel.Size = new System.Drawing.Size(0, 20);
            this.RectanglePerimeterLabel.TabIndex = 7;
            // 
            // RectangleSquareLabel
            // 
            this.RectangleSquareLabel.AutoSize = true;
            this.RectangleSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleSquareLabel.Location = new System.Drawing.Point(165, 404);
            this.RectangleSquareLabel.Name = "RectangleSquareLabel";
            this.RectangleSquareLabel.Size = new System.Drawing.Size(0, 20);
            this.RectangleSquareLabel.TabIndex = 8;
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 461);
            this.Controls.Add(this.RectangleSquareLabel);
            this.Controls.Add(this.RectanglePerimeterLabel);
            this.Controls.Add(this.RectangleSquareButton);
            this.Controls.Add(this.RectanglePerimeterButton);
            this.Controls.Add(this.RectangleWidthTextBox);
            this.Controls.Add(this.RectangleHeightTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.RectanglePictureBox);
            this.Name = "RectangleForm";
            this.Text = "Прямоугольник";
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
        private System.Windows.Forms.Label RectanglePerimeterLabel;
        private System.Windows.Forms.Label RectangleSquareLabel;
    }
}