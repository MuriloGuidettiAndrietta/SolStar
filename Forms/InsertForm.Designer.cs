using System.Drawing;
using System.Windows.Forms;

namespace CRUD.Forms
{
    partial class InsertForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox updateDate;
        private System.Windows.Forms.Label labelUpdateDate;
        private System.Windows.Forms.Button insertButton;
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
            // Insert Form
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
            this.title.Text = "Inserir Aluno";
            this.title.Size = new System.Drawing.Size(150, 50);
            this.title.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(60, 40);
            this.title.BackColor = Color.Transparent;

            // Label Name
            this.labelName = new System.Windows.Forms.Label();
            this.labelName.Text = "Nome";
            this.labelName.Size = new System.Drawing.Size(75, 50);
            this.labelName.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(200, 90);
            this.labelName.BackColor = Color.Transparent;

            // TextBox Name
            this.name = new System.Windows.Forms.TextBox();
            this.name.Width = 130;
            this.name.Location = new System.Drawing.Point(410, 93);

            // Label Birthday
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelBirthday.Text = "Nascimento";
            this.labelBirthday.Size = new System.Drawing.Size(125, 50);
            this.labelBirthday.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.labelBirthday.Location = new System.Drawing.Point(200, 140);
            this.labelBirthday.BackColor = Color.Transparent;

            // TextBox Birthday
            this.birthday = new System.Windows.Forms.TextBox();
            this.birthday.Width = 130;
            this.birthday.Location = new System.Drawing.Point(410, 143);

            // Label Address
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAddress.Text = "Endereço";
            this.labelAddress.Size = new System.Drawing.Size(125, 50);
            this.labelAddress.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.labelAddress.Location = new System.Drawing.Point(200, 190);
            this.labelAddress.BackColor = Color.Transparent;

            // TextBox Address
            this.address = new System.Windows.Forms.TextBox();
            this.address.Width = 130;
            this.address.Location = new System.Drawing.Point(410, 193);

            // Label Update Date
            this.labelUpdateDate = new System.Windows.Forms.Label();
            this.labelUpdateDate.Text = "Data de Atualização";
            this.labelUpdateDate.Size = new System.Drawing.Size(200, 50);
            this.labelUpdateDate.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.labelUpdateDate.Location = new System.Drawing.Point(200, 240);
            this.labelUpdateDate.BackColor = Color.Transparent;

            // TextBox Update Date
            this.updateDate = new System.Windows.Forms.TextBox();
            this.updateDate.Width = 130;
            this.updateDate.Location = new System.Drawing.Point(410, 243);

            // Insert Button
            this.insertButton = new System.Windows.Forms.Button();
            this.insertButton.Location = new System.Drawing.Point(330, 310);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(130, 45);
            this.insertButton.Text = "Inserir";
            this.insertButton.Click += new System.EventHandler(this.insertButtonClick);

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
            this.Controls.Add(labelName);
            this.Controls.Add(name);
            this.Controls.Add(labelBirthday);
            this.Controls.Add(birthday);
            this.Controls.Add(labelAddress);
            this.Controls.Add(address);
            this.Controls.Add(labelUpdateDate);
            this.Controls.Add(updateDate);
            this.Controls.Add(insertButton);
            this.Controls.Add(backButton);
            this.Controls.Add(closeButton);
        }

        #endregion
    }
}