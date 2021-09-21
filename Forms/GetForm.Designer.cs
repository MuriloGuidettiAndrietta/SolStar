using System.Drawing;
using System.Windows.Forms;

namespace CRUD.Forms
{
    partial class GetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridUpdateDate;
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
            // Get Form
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
            this.title.Text = "Recupera Alunos";
            this.title.Size = new System.Drawing.Size(250, 50);
            this.title.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(60, 40);
            this.title.BackColor = Color.Transparent;

            // Get Button
            this.getButton = new System.Windows.Forms.Button();
            this.getButton.Location = new System.Drawing.Point(330, 310);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(130, 45);
            this.getButton.Text = "Recuperar";
            this.getButton.Click += new System.EventHandler(this.getButtonClick);

            // Grid Id
            this.gridId = new DataGridViewTextBoxColumn();
            this.gridId.HeaderText = "Id";
            this.gridId.Name = "gridId";
            this.gridId.Width = 40;

            // Grid Name
            this.gridName = new DataGridViewTextBoxColumn();
            this.gridName.HeaderText = "Nome";
            this.gridName.Name = "gridName";
            this.gridName.Width = 100;

            // Grid Birthday
            this.gridBirthday = new DataGridViewTextBoxColumn();
            this.gridBirthday.HeaderText = "Nascimento";
            this.gridBirthday.Name = "gridBirthday";
            this.gridBirthday.Width = 150;

            // Grid Address
            this.gridAddress = new DataGridViewTextBoxColumn();
            this.gridAddress.HeaderText = "Endereço";
            this.gridAddress.Name = "gridAddress";
            this.gridAddress.Width = 150;

            // Grid Update Date
            this.gridUpdateDate = new DataGridViewTextBoxColumn();
            this.gridUpdateDate.HeaderText = "Data de Atualização";
            this.gridUpdateDate.Name = "gridUpdateDate";
            this.gridUpdateDate.Width = 150;

            // Grid 
            dgvDataList = new DataGridView();
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridName,
            this.gridBirthday,
            this.gridAddress,
            this.gridUpdateDate});
            this.dgvDataList.Location = new System.Drawing.Point(110, 100);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.Size = new System.Drawing.Size(593, 175);
            this.dgvDataList.TabIndex = 1;
            this.dgvDataList.Visible = false;

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
            this.Controls.Add(getButton);
            this.Controls.Add(backButton);
            this.Controls.Add(dgvDataList);
            this.Controls.Add(closeButton);
        }

        #endregion
    }
}