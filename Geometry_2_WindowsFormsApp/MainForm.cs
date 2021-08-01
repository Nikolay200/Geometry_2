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
    public partial class MainForm : Form
    {
        public static GraphicForm graphicForm = new GraphicForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm();
            circleForm.Show();
            graphicForm.Show();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.Show();
            graphicForm.Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm();
            triangleForm.Show();
            graphicForm.Show();
        }
    }
}
