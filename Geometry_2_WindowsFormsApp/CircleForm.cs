using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class CircleForm : Form
    {        
        public static Random random = new Random();
        public GraphicForm graphicForm = new GraphicForm();
        public CircleForm()
        {
            InitializeComponent();
            
        }
        
        private void CirclePerimeterButton_Click(object sender, EventArgs e)
        {      
            if (RadiusTextBox.Text != string.Empty)
            {
                Circle circle = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                CirclePerimeterLabel.Text = $"{circle.Perimeter()} mm";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }
            
        }

        private void CircleSquareButton_Click(object sender, EventArgs e)
        {
            if (RadiusTextBox.Text != string.Empty)
            {
                Circle circle = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                CircleSquareLabel.Text = $"{circle.Square()} mm2";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }
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
            graphicForm.Refresh();
            graphicForm.Show();
            var graphics = graphicForm.CreateGraphics();
            var brush = Brushes.Blue;
            var x = random.Next(350, 550);
            var y = random.Next(100, 550);
            var diameter = Convert.ToDouble(RadiusTextBox.Text) * 2 * 3.794;
            graphics.FillEllipse(brush, x, y, (float)diameter, (float)diameter);
            
        }
        
    }
}
