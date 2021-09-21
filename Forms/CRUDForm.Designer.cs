using System.Drawing;
using System.Windows.Forms;

namespace CRUD
{
    partial class CRUDForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button getByIdButton;
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
            // CRUD Form
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

            // Insert Button
            this.insertButton = new System.Windows.Forms.Button();
            this.insertButton.Location = new System.Drawing.Point(170, 60);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(225, 125);
            this.insertButton.Text = "Insere";
            this.insertButton.Click += new System.EventHandler(this.insertButtonClick);

            // Delete Button
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteButton.Location = new System.Drawing.Point(400, 60);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 125);
            this.deleteButton.Text = "Deleta";
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);

            // Get Button
            this.getButton = new System.Windows.Forms.Button();
            this.getButton.Location = new System.Drawing.Point(170, 195);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(225, 125);
            this.getButton.Text = "Recupera";
            this.getButton.Click += new System.EventHandler(this.getButtonClick);

            // Get By Id Button
            this.getByIdButton = new System.Windows.Forms.Button();
            this.getByIdButton.Location = new System.Drawing.Point(400, 195);
            this.getByIdButton.Name = "getByIdButton";
            this.getByIdButton.Size = new System.Drawing.Size(225, 125);
            this.getByIdButton.Text = "Recupera por Id";
            this.getByIdButton.Click += new System.EventHandler(this.getByIdButtonClick);

            // Back Button
            this.backButton = new System.Windows.Forms.Button();
            this.backButton.Location = new System.Drawing.Point(330, 350);
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
            this.Controls.Add(this.image);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.getByIdButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(closeButton);
        }

        #endregion
    }
}