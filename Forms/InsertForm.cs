using CRUD.Database;
using CRUD.Entity;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRUD.Forms
{
    public partial class InsertForm : Form
    {
        public InsertForm()
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
            int error = 0;
            if (name.Text == String.Empty)
            {
                error = 1;
                MessageBox.Show("O campo Nome é obrigatório!");
            }

            if (birthday.Text == String.Empty)
            {
                error = 1;
                MessageBox.Show("O campo Nascimento é obrigatório!");
            }

            DateTime dateValue;
            if (DateTime.TryParse(birthday.Text, out dateValue))
                String.Format("{0:d/MM/yyyy}", dateValue);
            else
            {
                error = 1;
                MessageBox.Show("A data do campo Nascimento é inválida!");
            }

            if (DateTime.TryParse(updateDate.Text, out dateValue))
                String.Format("{0:d/MM/yyyy}", dateValue);
            else
            {
                error = 1;
                MessageBox.Show("A data do campo Data de Atualização é inválida!");
            }

            if (error == 0)
            {
                var aluno = new Aluno();
                aluno.Name = name.Text;
                aluno.Birthday = Convert.ToDateTime(birthday.Text);
                aluno.Address = address.Text;
                aluno.UpdateDate = Convert.ToDateTime(updateDate.Text);

                try
                {
                    DatabaseAPI.Add(aluno);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("A inserçao foi efetuada com sucesso!");
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
