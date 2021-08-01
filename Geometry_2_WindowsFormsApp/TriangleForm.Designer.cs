
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
            this.TriangleDrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Geometry_2_WindowsFormsApp.Properties.Resources.Triangle_simple;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Side1Label
            // 
            this.Side1Label.AutoSize = true;
            this.Side1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side1Label.Location = new System.Drawing.Point(16, 236);
            this.Side1Label.Name = "Side1Label";
            this.Side1Label.Size = new System.Drawing.Size(96, 20);
            this.Side1Label.TabIndex = 1;
            this.Side1Label.Text = "1 Сторона";
            // 
            // Side2Label
            // 
            this.Side2Label.AutoSize = true;
            this.Side2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side2Label.Location = new System.Drawing.Point(16, 270);
            this.Side2Label.Name = "Side2Label";
            this.Side2Label.Size = new System.Drawing.Size(96, 20);
            this.Side2Label.TabIndex = 2;
            this.Side2Label.Text = "2 Сторона";
            // 
            // Side3Label
            // 
            this.Side3Label.AutoSize = true;
            this.Side3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side3Label.Location = new System.Drawing.Point(16, 304);
            this.Side3Label.Name = "Side3Label";
            this.Side3Label.Size = new System.Drawing.Size(96, 20);
            this.Side3Label.TabIndex = 3;
            this.Side3Label.Text = "3 Сторона";
            // 
            // Side1TextBox
            // 
            this.Side1TextBox.Location = new System.Drawing.Point(130, 236);
            this.Side1TextBox.Name = "Side1TextBox";
            this.Side1TextBox.Size = new System.Drawing.Size(90, 20);
            this.Side1TextBox.TabIndex = 4;
            this.Side1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side1TextBox_KeyPress);
            // 
            // Side2TextBox
            // 
            this.Side2TextBox.Location = new System.Drawing.Point(130, 272);
            this.Side2TextBox.Name = "Side2TextBox";
            this.Side2TextBox.Size = new System.Drawing.Size(90, 20);
            this.Side2TextBox.TabIndex = 5;
            this.Side2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side2TextBox_KeyPress);
            // 
            // Side3TextBox
            // 
            this.Side3TextBox.Location = new System.Drawing.Point(130, 306);
            this.Side3TextBox.Name = "Side3TextBox";
            this.Side3TextBox.Size = new System.Drawing.Size(90, 20);
            this.Side3TextBox.TabIndex = 6;
            this.Side3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side3TextBox_KeyPress);
            // 
            // TrianglePerimeterButton
            // 
            this.TrianglePerimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrianglePerimeterButton.Location = new System.Drawing.Point(20, 346);
            this.TrianglePerimeterButton.Name = "TrianglePerimeterButton";
            this.TrianglePerimeterButton.Size = new System.Drawing.Size(111, 43);
            this.TrianglePerimeterButton.TabIndex = 7;
            this.TrianglePerimeterButton.Text = "Периметр";
            this.TrianglePerimeterButton.UseVisualStyleBackColor = true;
            this.TrianglePerimeterButton.Click += new System.EventHandler(this.TrianglePerimeterButton_Click);
            // 
            // TriangleSquareButton
            // 
            this.TriangleSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriangleSquareButton.Location = new System.Drawing.Point(20, 408);
            this.TriangleSquareButton.Name = "TriangleSquareButton";
            this.TriangleSquareButton.Size = new System.Drawing.Size(111, 43);
            this.TriangleSquareButton.TabIndex = 8;
            this.TriangleSquareButton.Text = "Площадь";
            this.TriangleSquareButton.UseVisualStyleBackColor = true;
            this.TriangleSquareButton.Click += new System.EventHandler(this.TriangleSquareButton_Click);
            // 
            // TrianglePerimeterLabel
            // 
            this.TrianglePerimeterLabel.AutoSize = true;
            this.TrianglePerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrianglePerimeterLabel.Location = new System.Drawing.Point(162, 357);
            this.TrianglePerimeterLabel.Name = "TrianglePerimeterLabel";
            this.TrianglePerimeterLabel.Size = new System.Drawing.Size(0, 20);
            this.TrianglePerimeterLabel.TabIndex = 9;
            // 
            // TriangleSquareLabel
            // 
            this.TriangleSquareLabel.AutoSize = true;
            this.TriangleSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriangleSquareLabel.Location = new System.Drawing.Point(162, 408);
            this.TriangleSquareLabel.Name = "TriangleSquareLabel";
            this.TriangleSquareLabel.Size = new System.Drawing.Size(0, 20);
            this.TriangleSquareLabel.TabIndex = 10;
            // 
            // TriangleDrawButton
            // 
            this.TriangleDrawButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TriangleDrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriangleDrawButton.Location = new System.Drawing.Point(20, 474);
            this.TriangleDrawButton.Name = "TriangleDrawButton";
            this.TriangleDrawButton.Size = new System.Drawing.Size(111, 41);
            this.TriangleDrawButton.TabIndex = 11;
            this.TriangleDrawButton.Text = "Создать";
            this.TriangleDrawButton.UseVisualStyleBackColor = false;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 661);
            this.Controls.Add(this.TriangleDrawButton);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Треугольник";
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
        private System.Windows.Forms.Button TriangleDrawButton;
    }
}