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
    }
}
