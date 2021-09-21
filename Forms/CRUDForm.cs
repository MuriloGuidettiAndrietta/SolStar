using CRUD.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUDForm : Form
    {
        public CRUDForm()
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

        private void insertButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var insertForm = new InsertForm();
            insertForm.Show();
        }

        private void getButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var get = new GetForm();
            get.Show();
        }

        private void getByIdButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var getById = new GetByIdForm();
            getById.Show();
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var delete = new DeleteForm();
            delete.Show();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.Show();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
