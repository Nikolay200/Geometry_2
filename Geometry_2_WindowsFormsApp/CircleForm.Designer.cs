
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
            this.CircleDrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CirclePictureBox
            // 
            this.CirclePictureBox.Image = global::Geometry_2_WindowsFormsApp.Properties.Resources.Circle_simple;
            this.CirclePictureBox.Location = new System.Drawing.Point(20, 20);
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
            this.RadiusLabel.Location = new System.Drawing.Point(12, 235);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(69, 20);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Радиус";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(86, 235);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            this.RadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadiusTextBox_KeyPress);
            // 
            // CirclePerimeterButton
            // 
            this.CirclePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CirclePerimeterButton.Location = new System.Drawing.Point(15, 317);
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
            this.CircleSquareButton.Location = new System.Drawing.Point(15, 391);
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
            this.CirclePerimeterLabel.Location = new System.Drawing.Point(157, 332);
            this.CirclePerimeterLabel.Name = "CirclePerimeterLabel";
            this.CirclePerimeterLabel.Size = new System.Drawing.Size(0, 20);
            this.CirclePerimeterLabel.TabIndex = 5;
            // 
            // CircleSquareLabel
            // 
            this.CircleSquareLabel.AutoSize = true;
            this.CircleSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleSquareLabel.Location = new System.Drawing.Point(157, 404);
            this.CircleSquareLabel.Name = "CircleSquareLabel";
            this.CircleSquareLabel.Size = new System.Drawing.Size(0, 20);
            this.CircleSquareLabel.TabIndex = 6;
            // 
            // CircleDrawButton
            // 
            this.CircleDrawButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CircleDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleDrawButton.Location = new System.Drawing.Point(16, 468);
            this.CircleDrawButton.Name = "CircleDrawButton";
            this.CircleDrawButton.Size = new System.Drawing.Size(107, 43);
            this.CircleDrawButton.TabIndex = 7;
            this.CircleDrawButton.Text = "Создать";
            this.CircleDrawButton.UseVisualStyleBackColor = false;
            this.CircleDrawButton.Click += new System.EventHandler(this.CircleDrawButton_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 661);
            this.Controls.Add(this.CircleDrawButton);
            this.Controls.Add(this.CircleSquareLabel);
            this.Controls.Add(this.CirclePerimeterLabel);
            this.Controls.Add(this.CircleSquareButton);
            this.Controls.Add(this.CirclePerimeterButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.CirclePictureBox);
            this.Name = "CircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Button CircleDrawButton;
    }
}