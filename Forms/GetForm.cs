using CRUD.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.Forms
{
    public partial class GetForm : Form
    {
        public GetForm()
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
                dgvDataList.Rows.Clear();
                List<int> ids = new List<int>();
                var alunos = DatabaseAPI.Get(ref ids);

                if(alunos.Any())
                    dgvDataList.Visible = true;

                int i = 0;
                foreach (var aluno in alunos)
                {
                    dgvDataList.Rows.Add(ids[i], aluno.Name, aluno.Birthday, aluno.Address, aluno.UpdateDate);
                    i++;
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
