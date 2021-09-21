using System.Drawing;
using System.Windows.Forms;

namespace CRUD.Forms
{
    partial class DeleteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button closeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Delete Form
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "SolStar - CRUD";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            // Background
            this.Paint += new PaintEventHandler(SetBackground);

            // SolStar Logo
            this.image = new PictureBox();
            this.image.Image = Image.FromFile("~/../../../../Images/SolStar.png");
            this.image.Size = new System.Drawing.Size(130, 35);
            this.image.Location = new System.Drawing.Point(670, 415);

            // Title
            this.title = new System.Windows.Forms.Label();
            this.title.Text = "Deleta Aluno";
            this.title.Size = new System.Drawing.Size(250, 50);
            this.title.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(60, 40);
            this.title.BackColor = Color.Transparent;

            // Label Id
            this.labelId = new System.Windows.Forms.Label();
            this.labelId.Text = "Digite o Id: ";
            this.labelId.Size = new System.Drawing.Size(120, 50);
            this.labelId.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(240, 140);
            this.labelId.BackColor = Color.Transparent;

            // TextBox Id
            this.id = new System.Windows.Forms.TextBox();
            this.id.Width = 130;
            this.id.Location = new System.Drawing.Point(380, 143);

            // Delete Button
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteButton.Location = new System.Drawing.Point(330, 310);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 45);
            this.deleteButton.Text = "Deletar";
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);

            // Back Button
            this.backButton = new System.Windows.Forms.Button();
            this.backButton.Location = new System.Drawing.Point(330, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 45);
            this.backButton.Text = "Voltar";
            this.backButton.Click += new System.EventHandler(this.backButtonClick);

            // Close Button
            this.closeButton = new System.Windows.Forms.Button();
            this.closeButton.Location = new System.Drawing.Point(750, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);

            // Attaching Components
            this.Controls.Add(image);
            this.Controls.Add(title);
            this.Controls.Add(labelId);
            this.Controls.Add(id);
            this.Controls.Add(deleteButton);
            this.Controls.Add(backButton);
            this.Controls.Add(closeButton);
        }

        #endregion
    }
}