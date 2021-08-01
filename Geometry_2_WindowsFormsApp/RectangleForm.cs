using System;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void RectanglePerimeterButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToDouble(RectangleHeightTextBox.Text), Convert.ToDouble(RectangleWidthTextBox.Text));

            RectanglePerimeterLabel.Text = $"{rectangle.Perimeter()} mm";
        }

        private void RectangleSquareButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToDouble(RectangleHeightTextBox.Text), Convert.ToDouble(RectangleWidthTextBox.Text));

            RectangleSquareLabel.Text = $"{rectangle.Square()} mm2";
        }

        private void RectangleHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void RectangleWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }       
    }
}
