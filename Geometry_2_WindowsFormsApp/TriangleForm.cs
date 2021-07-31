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
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void TrianglePerimeterButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));

            TrianglePerimeterLabel.Text = $"{triangle.Perimeter()} mm";
        }

        private void TriangleSquareButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(Convert.ToDouble(Side1TextBox.Text), Convert.ToDouble(Side2TextBox.Text), Convert.ToDouble(Side3TextBox.Text));

            TriangleSquareLabel.Text = $"{triangle.Square()} mm2";
        }
    }
}
