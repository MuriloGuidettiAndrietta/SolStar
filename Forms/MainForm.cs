using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradientRectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradientRectangle, Color.MediumPurple, Color.Yellow, 55f);
            graphics.FillRectangle(brush, gradientRectangle);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var crud = new CRUDForm();
            crud.Show();
        }

        public void closeButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }      

    }
}
