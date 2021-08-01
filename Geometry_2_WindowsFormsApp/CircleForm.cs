using System;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }        

        private void CirclePerimeterButton_Click(object sender, EventArgs e)
        {                      
            Circle circle = new Circle(Convert.ToDouble(RadiusTextBox.Text));
            
            CirclePerimeterLabel.Text = $"{circle.Perimeter()} mm";
        }

        private void CircleSquareButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Convert.ToDouble(RadiusTextBox.Text));

            CircleSquareLabel.Text =  $"{circle.Square()} mm2";
        }

        private void RadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
