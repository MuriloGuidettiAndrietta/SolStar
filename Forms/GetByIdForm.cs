using CRUD.Database;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRUD.Forms
{
    public partial class GetByIdForm : Form
    {
        public GetByIdForm()
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

        private void getButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == String.Empty)
                    MessageBox.Show("Nenhum Id foi informado!");
                else
                {
                    dgvDataList.Rows.Clear();
                    var aluno = DatabaseAPI.GetById(Convert.ToInt32(id.Text));
                    if (aluno.Name != null)
                    {
                        dgvDataList.Rows.Add(id.Text, aluno.Name, aluno.Birthday, aluno.Address, aluno.UpdateDate);
                        dgvDataList.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("O Id informado não existe!");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro aconteceu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var crud = new CRUDForm();
            crud.Show();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
