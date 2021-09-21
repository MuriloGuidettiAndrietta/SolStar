using System.Drawing;
using System.Windows.Forms;

namespace CRUD
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCrud;
        private System.Windows.Forms.Label labelMurilo;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox image;
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
            // Main Form
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "SolStar - CRUD";
            this.startButton = new System.Windows.Forms.Button();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            // Background Image
            this.Paint += new PaintEventHandler(SetBackground);

            // CRUD Label
            this.labelCrud = new System.Windows.Forms.Label();
            this.labelCrud.Text = "Desafio SolStar";
            this.labelCrud.Size = new System.Drawing.Size(500, 100);
            this.labelCrud.Font = new Font("Calibri", 50, FontStyle.Bold);
            this.labelCrud.Location = new System.Drawing.Point(180, 75);
            this.labelCrud.BackColor = Color.Transparent;

            // SolStar Logo
            this.image = new PictureBox();
            this.image.Image = Image.FromFile("~/../../../../Images/SolStar.png");
            this.image.Size = new System.Drawing.Size(130, 35);
            this.image.Location = new System.Drawing.Point(670, 415);

            // Start Button
            this.startButton.Location = new System.Drawing.Point(300, 215);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 100);
            this.startButton.Text = "Iniciar";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // Murilo Label
            this.labelMurilo = new System.Windows.Forms.Label();
            this.labelMurilo.Text = "Murilo Guidetti Andrietta";
            this.labelMurilo.Size = new System.Drawing.Size(400, 200);
            this.labelMurilo.Font = new Font("Calibri", 20, FontStyle.Bold);
            this.labelMurilo.Location = new System.Drawing.Point(0, 420);
            this.labelMurilo.BackColor = Color.Transparent;

            // Close Button
            this.closeButton = new System.Windows.Forms.Button();
            this.closeButton.Location = new System.Drawing.Point(750, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);

            // Attaching Components
            this.Controls.Add(this.labelCrud);
            this.Controls.Add(this.labelMurilo);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.image);
            this.Controls.Add(closeButton);
        }        

        #endregion
    }
}

