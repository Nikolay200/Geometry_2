﻿using System;
using System.Windows.Forms;

namespace Geometry_2_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm();
            circleForm.Show();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm();
            triangleForm.Show();
        }
    }
}
