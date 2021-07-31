using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
