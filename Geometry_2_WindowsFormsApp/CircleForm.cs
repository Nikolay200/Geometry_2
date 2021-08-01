using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class CircleForm : Form
    {        
        public static Random random = new Random();
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

        private void CircleDrawButton_Click(object sender, EventArgs e)
        {
            GraphicForm graphicForm = new GraphicForm();
            var graphics = graphicForm.CreateGraphics();
            var brush = Brushes.Blue;
            var x = random.Next(300, 600);
            var y = random.Next(50, 600);
            var diameter = Convert.ToDouble(RadiusTextBox.Text) * 2;
            graphics.FillEllipse(brush, 300, 300, (float)diameter, (float)diameter);
        }
    }
}
