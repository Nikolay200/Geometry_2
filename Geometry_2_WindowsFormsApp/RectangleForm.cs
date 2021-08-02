using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class RectangleForm : Form
    {
        public GraphicForm graphicForm = new GraphicForm();
        public static Random random = new Random();
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void RectanglePerimeterButton_Click(object sender, EventArgs e)
        {
            if (RectangleHeightTextBox.Text != string.Empty && RectangleWidthTextBox.Text != string.Empty)
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(RectangleHeightTextBox.Text), Convert.ToDouble(RectangleWidthTextBox.Text));
                RectanglePerimeterLabel.Text = $"{rectangle.Perimeter()} mm";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }          
        }

        private void RectangleSquareButton_Click(object sender, EventArgs e)
        {
            if (RectangleHeightTextBox.Text != string.Empty && RectangleWidthTextBox.Text != string.Empty)
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(RectangleHeightTextBox.Text), Convert.ToDouble(RectangleWidthTextBox.Text));
                RectangleSquareLabel.Text = $"{rectangle.Square()} mm2";
            }
            else
            {
                MessageBox.Show("Введите данные.");
            }
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

        private void RectangleDrawButton_Click(object sender, EventArgs e)
        {
            graphicForm.ControlBox = false;
            graphicForm.Refresh();
            graphicForm.Show();
            var graphics = graphicForm.CreateGraphics();
            var brush = Brushes.Red;
            var x = random.Next(400, 500);
            var y = random.Next(200, 400);
            var height = Convert.ToDouble(RectangleHeightTextBox.Text) * 3.794;//Перевод из пикселей в миллиметры
            var width = Convert.ToDouble(RectangleWidthTextBox.Text) * 3.794;
            graphics.FillRectangle(brush, x, y, (float)height, (float)width);
        }        
    }
}
