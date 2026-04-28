namespace HomeAffairsDigitalIdentityProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblID = new Label();
            txtID = new TextBox();
            lblCitizen = new Label();
            cmbCitizenship = new ComboBox();
            btnValidate = new Button();
            lblValidationResult = new Label();
            txtOutput = new TextBox();
            btnGenerateProfile = new Button();
            picCoatOfArms = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCoatOfArms).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkGreen;
            lblTitle.Location = new Point(119, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(461, 29);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.DarkOrange;
            lblName.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(184, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(370, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.DarkOrange;
            lblID.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(184, 119);
            lblID.Name = "lblID";
            lblID.Size = new Size(120, 21);
            lblID.TabIndex = 4;
            lblID.Text = "Enter your ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(370, 117);
            txtID.Name = "txtID";
            txtID.Size = new Size(280, 27);
            txtID.TabIndex = 5;
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.BackColor = Color.DarkOrange;
            lblCitizen.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCitizen.Location = new Point(184, 157);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(158, 21);
            lblCitizen.TabIndex = 6;
            lblCitizen.Text = "Citezinship Status:";
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCitizenship.Location = new Point(370, 157);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(280, 28);
            cmbCitizenship.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Green;
            btnValidate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(430, 217);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(150, 35);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Location = new Point(370, 250);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(0, 20);
            lblValidationResult.TabIndex = 9;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(370, 280);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(280, 150);
            txtOutput.TabIndex = 10;
            // 
            // btnGenerateProfile
            // 
            btnGenerateProfile.BackColor = Color.Green;
            btnGenerateProfile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnGenerateProfile.ForeColor = Color.White;
            btnGenerateProfile.Location = new Point(430, 449);
            btnGenerateProfile.Name = "btnGenerateProfile";
            btnGenerateProfile.Size = new Size(150, 35);
            btnGenerateProfile.TabIndex = 11;
            btnGenerateProfile.Text = "Generate Profile";
            btnGenerateProfile.UseVisualStyleBackColor = false;
            btnGenerateProfile.Click += btnGenerateProfile_Click;
            // 
            // picCoatOfArms
            // 
            picCoatOfArms.Image = (Image)resources.GetObject("picCoatOfArms.Image");
            picCoatOfArms.Location = new Point(74, 200);
            picCoatOfArms.Name = "picCoatOfArms";
            picCoatOfArms.Size = new Size(198, 230);
            picCoatOfArms.TabIndex = 0;
            picCoatOfArms.TabStop = false;
            // 
            // Form1
            // 
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(700, 510);
            Controls.Add(picCoatOfArms);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(lblCitizen);
            Controls.Add(cmbCitizenship);
            Controls.Add(btnValidate);
            Controls.Add(lblValidationResult);
            Controls.Add(txtOutput);
            Controls.Add(btnGenerateProfile);
            Name = "Form1";
            Text = "Home Affairs Digital Identity Processor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picCoatOfArms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenerateProfile;
        private System.Windows.Forms.PictureBox picCoatOfArms;
    }
}