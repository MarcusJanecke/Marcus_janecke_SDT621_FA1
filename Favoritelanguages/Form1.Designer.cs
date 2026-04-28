namespace FavouriteLanguages
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstLanguages = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSort = new Button();
            lblStatus = new Label();
            lblTitle = new Label();
            lblCount = new Label();
            SuspendLayout();
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(150, 60);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(400, 144);
            lstLanguages.TabIndex = 1;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(150, 240);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(400, 27);
            txtLanguage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(150, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(290, 280);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 35);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.SteelBlue;
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(430, 280);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(120, 35);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort A-Z";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Location = new Point(150, 330);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Favourite Programming Languages v2.0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DarkSlateGray;
            lblCount.Location = new Point(150, 355);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(133, 18);
            lblCount.TabIndex = 7;
            lblCount.Text = "Languages in list: 0";
            // 
            // Form1
            // 
            ClientSize = new Size(750, 420);
            Controls.Add(lblTitle);
            Controls.Add(lstLanguages);
            Controls.Add(txtLanguage);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnSort);
            Controls.Add(lblStatus);
            Controls.Add(lblCount);
            Name = "Form1";
            Text = "Favourite Programming Languages v2.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;    // NEW in v2.0
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCount;    // NEW in v2.0
    }
}
