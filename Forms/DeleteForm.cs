using CRUD.Database;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRUD.Forms
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
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

        private void deleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == String.Empty)
                    MessageBox.Show("Nenhum Id foi informado!");
                else
                {
                    var aluno = DatabaseAPI.GetById(Convert.ToInt32(id.Text));
                    if(aluno.Name == null)
                        MessageBox.Show("O Id informardo não existe!");
                    else
                    {
                        DatabaseAPI.Delete(Convert.ToInt32(id.Text));
                        aluno = DatabaseAPI.GetById(Convert.ToInt32(id.Text));
                        if (aluno.Name == null)
                            MessageBox.Show("A deleção foi efetuada com sucesso!");
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
