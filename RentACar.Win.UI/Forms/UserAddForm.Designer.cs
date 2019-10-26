namespace RentACar.Win.UI.Forms
{
    partial class UserAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCitizenId = new System.Windows.Forms.Label();
            this.txtCitizenId = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblResidentalCity = new System.Windows.Forms.Label();
            this.cmbResidentalCity = new System.Windows.Forms.ComboBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(108, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(22, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Adı";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(91, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(39, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Soyadı";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(148, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(148, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblCitizenId
            // 
            this.lblCitizenId.AutoSize = true;
            this.lblCitizenId.Location = new System.Drawing.Point(29, 121);
            this.lblCitizenId.Name = "lblCitizenId";
            this.lblCitizenId.Size = new System.Drawing.Size(101, 13);
            this.lblCitizenId.TabIndex = 7;
            this.lblCitizenId.Text = "T.C Kimlik Numarası";
            // 
            // txtCitizenId
            // 
            this.txtCitizenId.Location = new System.Drawing.Point(148, 118);
            this.txtCitizenId.Name = "txtCitizenId";
            this.txtCitizenId.Size = new System.Drawing.Size(100, 20);
            this.txtCitizenId.TabIndex = 8;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(60, 163);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(70, 13);
            this.lblBirthDate.TabIndex = 9;
            this.lblBirthDate.Text = "Doğum Tarihi";
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(148, 163);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(185, 20);
            this.dateTimeBirthDate.TabIndex = 10;
            // 
            // lblResidentalCity
            // 
            this.lblResidentalCity.AutoSize = true;
            this.lblResidentalCity.Location = new System.Drawing.Point(14, 210);
            this.lblResidentalCity.Name = "lblResidentalCity";
            this.lblResidentalCity.Size = new System.Drawing.Size(116, 13);
            this.lblResidentalCity.TabIndex = 11;
            this.lblResidentalCity.Text = "Nüfusa Kayıtlı Olduğu İl";
            // 
            // cmbResidentalCity
            // 
            this.cmbResidentalCity.FormattingEnabled = true;
            this.cmbResidentalCity.Location = new System.Drawing.Point(148, 207);
            this.cmbResidentalCity.Name = "cmbResidentalCity";
            this.cmbResidentalCity.Size = new System.Drawing.Size(121, 21);
            this.cmbResidentalCity.TabIndex = 12;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(514, 43);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(133, 133);
            this.pictureBoxUser.TabIndex = 13;
            this.pictureBoxUser.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(532, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 51);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "BİLGİLERİ KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 359);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.cmbResidentalCity);
            this.Controls.Add(this.lblResidentalCity);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtCitizenId);
            this.Controls.Add(this.lblCitizenId);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "UserAddForm";
            this.Text = "UserAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCitizenId;
        private System.Windows.Forms.TextBox txtCitizenId;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.Label lblResidentalCity;
        private System.Windows.Forms.ComboBox cmbResidentalCity;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button btnSave;
    }
}