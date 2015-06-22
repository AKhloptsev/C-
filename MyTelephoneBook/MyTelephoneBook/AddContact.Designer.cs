namespace MyTelephoneBook
{
    partial class AddContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelBlackList = new System.Windows.Forms.Label();
            this.checkBoxBlacklist = new System.Windows.Forms.CheckBox();
            this.comboBoxPhoto = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(3, 81);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(76, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Phone number";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(3, 123);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(35, 13);
            this.labelPhoto.TabIndex = 2;
            this.labelPhoto.Text = "Photo";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(3, 161);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "Group";
            // 
            // labelBlackList
            // 
            this.labelBlackList.AutoSize = true;
            this.labelBlackList.Location = new System.Drawing.Point(3, 200);
            this.labelBlackList.Name = "labelBlackList";
            this.labelBlackList.Size = new System.Drawing.Size(49, 13);
            this.labelBlackList.TabIndex = 4;
            this.labelBlackList.Text = "Black list";
            // 
            // checkBoxBlacklist
            // 
            this.checkBoxBlacklist.AutoSize = true;
            this.checkBoxBlacklist.Location = new System.Drawing.Point(113, 200);
            this.checkBoxBlacklist.Name = "checkBoxBlacklist";
            this.checkBoxBlacklist.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBlacklist.TabIndex = 13;
            this.checkBoxBlacklist.UseVisualStyleBackColor = true;
            // 
            // comboBoxPhoto
            // 
            this.comboBoxPhoto.FormattingEnabled = true;
            this.comboBoxPhoto.Items.AddRange(new object[] {
            "Мальчик",
            "Девочка"});
            this.comboBoxPhoto.Location = new System.Drawing.Point(113, 120);
            this.comboBoxPhoto.Name = "comboBoxPhoto";
            this.comboBoxPhoto.Size = new System.Drawing.Size(162, 21);
            this.comboBoxPhoto.TabIndex = 11;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Семья",
            "Друзья",
            "Учёба",
            "Работа"});
            this.comboBoxGroup.Location = new System.Drawing.Point(113, 161);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(162, 21);
            this.comboBoxGroup.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(113, 78);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(162, 20);
            this.textBoxNumber.TabIndex = 10;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(53, 235);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(177, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(113, 42);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(162, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Surname";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 270);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxPhoto);
            this.Controls.Add(this.checkBoxBlacklist);
            this.Controls.Add(this.labelBlackList);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContact";
            this.Text = "Add contact";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelBlackList;
        private System.Windows.Forms.CheckBox checkBoxBlacklist;
        private System.Windows.Forms.ComboBox comboBoxPhoto;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}