using System;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void TrianglePerimeterButton_Click(object sender, EventArgs e)
        {            
            Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));
            var roundValue = Math.Round(triangle.Perimeter(), 2);
            TrianglePerimeterLabel.Text = $"{roundValue} mm";
        }

        private void TriangleSquareButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));
            var roundValue = Math.Round(triangle.Square(), 2);
            TriangleSquareLabel.Text = $"{roundValue} mm2"; 
        }        

        private void Side1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void Side2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void Side3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
