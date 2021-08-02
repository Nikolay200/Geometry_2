using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class TriangleForm : Form
    {
        public GraphicForm graphicForm = new GraphicForm();
        public static Random random = new Random();
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void TrianglePerimeterButton_Click(object sender, EventArgs e)
        {
            if (Side1TextBox.Text != string.Empty && Side2TextBox.Text != string.Empty && Side3TextBox.Text != string.Empty)
            {
                Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));
                var roundValue = Math.Round(triangle.Perimeter(), 2);
                TrianglePerimeterLabel.Text = $"{roundValue} mm";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }            
        }

        private void TriangleSquareButton_Click(object sender, EventArgs e)
        {
            if (Side1TextBox.Text != string.Empty && Side2TextBox.Text != string.Empty && Side3TextBox.Text != string.Empty)
            {
                Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));
                var roundValue = Math.Round(triangle.Square(), 2);
                TriangleSquareLabel.Text = $"{roundValue} mm2";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }
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

        private void TriangleDrawButton_Click(object sender, EventArgs e)
        {
            graphicForm.ControlBox = false;
            graphicForm.Refresh();
            graphicForm.Show();
            var graphics = graphicForm.CreateGraphics();
            var brush = Brushes.Green;
            var x1 = random.Next(350, 500);
            var y1 = random.Next(200, 350);
            var x2 = random.Next(350, 500);
            var y2 = random.Next(200, 350);
            var x3 = random.Next(350, 500);
            var y3 = random.Next(200, 350);            
            Point[] trianglePoints = new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3)};
            graphics.FillPolygon(brush, trianglePoints);
        }
    }
}
