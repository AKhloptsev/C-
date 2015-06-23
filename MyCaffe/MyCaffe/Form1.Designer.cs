namespace MyCaffe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toOrderButton = new System.Windows.Forms.Button();
            this.labelForBeverage = new System.Windows.Forms.Label();
            this.radioButtonForCoffee = new System.Windows.Forms.RadioButton();
            this.radioButtonForEspresso = new System.Windows.Forms.RadioButton();
            this.radioButtonForLatte = new System.Windows.Forms.RadioButton();
            this.radioButtonForMineralWater = new System.Windows.Forms.RadioButton();
            this.radioButtonForTea = new System.Windows.Forms.RadioButton();
            this.radioButtonForBlackTea = new System.Windows.Forms.RadioButton();
            this.radioButtonForGreenTea = new System.Windows.Forms.RadioButton();
            this.labelForBeverageAdditives = new System.Windows.Forms.Label();
            this.buttonForBeverageAdditivesAdd = new System.Windows.Forms.Button();
            this.checkBoxForSugar = new System.Windows.Forms.CheckBox();
            this.checkBoxForMilk = new System.Windows.Forms.CheckBox();
            this.checkBoxForCream = new System.Windows.Forms.CheckBox();
            this.checkBoxForCinnamon = new System.Windows.Forms.CheckBox();
            this.checkBoxForMapleSyrup = new System.Windows.Forms.CheckBox();
            this.pictureBoxCoffee = new System.Windows.Forms.PictureBox();
            this.pictureBoxEspresso = new System.Windows.Forms.PictureBox();
            this.pictureBoxLatte = new System.Windows.Forms.PictureBox();
            this.pictureBoxMineralWater = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlackTea = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreenTea = new System.Windows.Forms.PictureBox();
            this.pictureBoxSugar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMilk = new System.Windows.Forms.PictureBox();
            this.pictureBoxCream = new System.Windows.Forms.PictureBox();
            this.pictureBoxCinnamon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMapleSyrup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLatte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMineralWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCinnamon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapleSyrup)).BeginInit();
            this.SuspendLayout();
            // 
            // toOrderButton
            // 
            this.toOrderButton.BackColor = System.Drawing.Color.Lavender;
            this.toOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.toOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toOrderButton.Location = new System.Drawing.Point(365, 522);
            this.toOrderButton.Name = "toOrderButton";
            this.toOrderButton.Size = new System.Drawing.Size(116, 24);
            this.toOrderButton.TabIndex = 0;
            this.toOrderButton.Text = "Оформить заказ";
            this.toOrderButton.UseVisualStyleBackColor = false;
            this.toOrderButton.Click += new System.EventHandler(this.toOrderButton_Click);
            // 
            // labelForBeverage
            // 
            this.labelForBeverage.AutoSize = true;
            this.labelForBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForBeverage.Location = new System.Drawing.Point(362, 9);
            this.labelForBeverage.Name = "labelForBeverage";
            this.labelForBeverage.Size = new System.Drawing.Size(64, 15);
            this.labelForBeverage.TabIndex = 1;
            this.labelForBeverage.Text = "Напиток";
            // 
            // radioButtonForCoffee
            // 
            this.radioButtonForCoffee.AutoSize = true;
            this.radioButtonForCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForCoffee.Location = new System.Drawing.Point(19, 73);
            this.radioButtonForCoffee.Name = "radioButtonForCoffee";
            this.radioButtonForCoffee.Size = new System.Drawing.Size(113, 17);
            this.radioButtonForCoffee.TabIndex = 8;
            this.radioButtonForCoffee.Text = "Кофе, 11.5 грн";
            this.radioButtonForCoffee.UseVisualStyleBackColor = true;
            this.radioButtonForCoffee.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonForEspresso
            // 
            this.radioButtonForEspresso.AutoSize = true;
            this.radioButtonForEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForEspresso.Location = new System.Drawing.Point(433, 73);
            this.radioButtonForEspresso.Name = "radioButtonForEspresso";
            this.radioButtonForEspresso.Size = new System.Drawing.Size(139, 17);
            this.radioButtonForEspresso.TabIndex = 9;
            this.radioButtonForEspresso.Text = "Эспрессо, 14.3 грн";
            this.radioButtonForEspresso.UseVisualStyleBackColor = true;
            this.radioButtonForEspresso.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonForLatte
            // 
            this.radioButtonForLatte.AutoSize = true;
            this.radioButtonForLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForLatte.Location = new System.Drawing.Point(20, 157);
            this.radioButtonForLatte.Name = "radioButtonForLatte";
            this.radioButtonForLatte.Size = new System.Drawing.Size(106, 17);
            this.radioButtonForLatte.TabIndex = 10;
            this.radioButtonForLatte.Text = "Латте, 14 грн";
            this.radioButtonForLatte.UseVisualStyleBackColor = true;
            this.radioButtonForLatte.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonForMineralWater
            // 
            this.radioButtonForMineralWater.AutoSize = true;
            this.radioButtonForMineralWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForMineralWater.Location = new System.Drawing.Point(433, 177);
            this.radioButtonForMineralWater.Name = "radioButtonForMineralWater";
            this.radioButtonForMineralWater.Size = new System.Drawing.Size(141, 17);
            this.radioButtonForMineralWater.TabIndex = 11;
            this.radioButtonForMineralWater.Text = "Минералка, 7.5 грн";
            this.radioButtonForMineralWater.UseVisualStyleBackColor = true;
            this.radioButtonForMineralWater.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonForTea
            // 
            this.radioButtonForTea.AutoSize = true;
            this.radioButtonForTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForTea.Location = new System.Drawing.Point(14, 274);
            this.radioButtonForTea.Name = "radioButtonForTea";
            this.radioButtonForTea.Size = new System.Drawing.Size(48, 17);
            this.radioButtonForTea.TabIndex = 12;
            this.radioButtonForTea.Text = "Чай";
            this.radioButtonForTea.UseVisualStyleBackColor = true;
            this.radioButtonForTea.CheckedChanged += new System.EventHandler(this.radioButtonForTea_CheckedChanged);
            // 
            // radioButtonForBlackTea
            // 
            this.radioButtonForBlackTea.AutoSize = true;
            this.radioButtonForBlackTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForBlackTea.Location = new System.Drawing.Point(26, 297);
            this.radioButtonForBlackTea.Name = "radioButtonForBlackTea";
            this.radioButtonForBlackTea.Size = new System.Drawing.Size(145, 17);
            this.radioButtonForBlackTea.TabIndex = 13;
            this.radioButtonForBlackTea.Text = "Чёрный чай, 6.5 грн";
            this.radioButtonForBlackTea.UseVisualStyleBackColor = true;
            this.radioButtonForBlackTea.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonForGreenTea
            // 
            this.radioButtonForGreenTea.AutoSize = true;
            this.radioButtonForGreenTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForGreenTea.Location = new System.Drawing.Point(433, 297);
            this.radioButtonForGreenTea.Name = "radioButtonForGreenTea";
            this.radioButtonForGreenTea.Size = new System.Drawing.Size(140, 17);
            this.radioButtonForGreenTea.TabIndex = 14;
            this.radioButtonForGreenTea.Text = "Зелёный чай, 7 грн";
            this.radioButtonForGreenTea.UseVisualStyleBackColor = true;
            this.radioButtonForGreenTea.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelForBeverageAdditives
            // 
            this.labelForBeverageAdditives.AutoSize = true;
            this.labelForBeverageAdditives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForBeverageAdditives.Location = new System.Drawing.Point(385, 366);
            this.labelForBeverageAdditives.Name = "labelForBeverageAdditives";
            this.labelForBeverageAdditives.Size = new System.Drawing.Size(64, 15);
            this.labelForBeverageAdditives.TabIndex = 15;
            this.labelForBeverageAdditives.Text = "Добавки";
            // 
            // buttonForBeverageAdditivesAdd
            // 
            this.buttonForBeverageAdditivesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForBeverageAdditivesAdd.Location = new System.Drawing.Point(388, 487);
            this.buttonForBeverageAdditivesAdd.Name = "buttonForBeverageAdditivesAdd";
            this.buttonForBeverageAdditivesAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonForBeverageAdditivesAdd.TabIndex = 35;
            this.buttonForBeverageAdditivesAdd.Text = "Добавить";
            this.buttonForBeverageAdditivesAdd.UseVisualStyleBackColor = true;
            this.buttonForBeverageAdditivesAdd.Click += new System.EventHandler(this.buttonForBeverageAdditivesAdd_Click);
            // 
            // checkBoxForSugar
            // 
            this.checkBoxForSugar.AutoSize = true;
            this.checkBoxForSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForSugar.Location = new System.Drawing.Point(26, 400);
            this.checkBoxForSugar.Name = "checkBoxForSugar";
            this.checkBoxForSugar.Size = new System.Drawing.Size(111, 17);
            this.checkBoxForSugar.TabIndex = 36;
            this.checkBoxForSugar.Text = "Сахар, 0.5 грн";
            this.checkBoxForSugar.UseVisualStyleBackColor = true;
            // 
            // checkBoxForMilk
            // 
            this.checkBoxForMilk.AutoSize = true;
            this.checkBoxForMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForMilk.Location = new System.Drawing.Point(160, 400);
            this.checkBoxForMilk.Name = "checkBoxForMilk";
            this.checkBoxForMilk.Size = new System.Drawing.Size(121, 17);
            this.checkBoxForMilk.TabIndex = 37;
            this.checkBoxForMilk.Text = "Молоко, 1.5 грн";
            this.checkBoxForMilk.UseVisualStyleBackColor = true;
            // 
            // checkBoxForCream
            // 
            this.checkBoxForCream.AutoSize = true;
            this.checkBoxForCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForCream.Location = new System.Drawing.Point(307, 400);
            this.checkBoxForCream.Name = "checkBoxForCream";
            this.checkBoxForCream.Size = new System.Drawing.Size(119, 17);
            this.checkBoxForCream.TabIndex = 38;
            this.checkBoxForCream.Text = "Сливки, 1.5 грн";
            this.checkBoxForCream.UseVisualStyleBackColor = true;
            // 
            // checkBoxForCinnamon
            // 
            this.checkBoxForCinnamon.AutoSize = true;
            this.checkBoxForCinnamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForCinnamon.Location = new System.Drawing.Point(455, 400);
            this.checkBoxForCinnamon.Name = "checkBoxForCinnamon";
            this.checkBoxForCinnamon.Size = new System.Drawing.Size(119, 17);
            this.checkBoxForCinnamon.TabIndex = 39;
            this.checkBoxForCinnamon.Text = "Корица, 0.5 грн";
            this.checkBoxForCinnamon.UseVisualStyleBackColor = true;
            // 
            // checkBoxForMapleSyrup
            // 
            this.checkBoxForMapleSyrup.AutoSize = true;
            this.checkBoxForMapleSyrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForMapleSyrup.Location = new System.Drawing.Point(580, 400);
            this.checkBoxForMapleSyrup.Name = "checkBoxForMapleSyrup";
            this.checkBoxForMapleSyrup.Size = new System.Drawing.Size(163, 17);
            this.checkBoxForMapleSyrup.TabIndex = 40;
            this.checkBoxForMapleSyrup.Text = "Кленовый сироп, 2 грн";
            this.checkBoxForMapleSyrup.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCoffee
            // 
            this.pictureBoxCoffee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoffee.Image")));
            this.pictureBoxCoffee.Location = new System.Drawing.Point(186, 27);
            this.pictureBoxCoffee.Name = "pictureBoxCoffee";
            this.pictureBoxCoffee.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoffee.TabIndex = 46;
            this.pictureBoxCoffee.TabStop = false;
            // 
            // pictureBoxEspresso
            // 
            this.pictureBoxEspresso.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEspresso.Image")));
            this.pictureBoxEspresso.Location = new System.Drawing.Point(594, 27);
            this.pictureBoxEspresso.Name = "pictureBoxEspresso";
            this.pictureBoxEspresso.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxEspresso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEspresso.TabIndex = 47;
            this.pictureBoxEspresso.TabStop = false;
            // 
            // pictureBoxLatte
            // 
            this.pictureBoxLatte.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLatte.Image")));
            this.pictureBoxLatte.Location = new System.Drawing.Point(186, 133);
            this.pictureBoxLatte.Name = "pictureBoxLatte";
            this.pictureBoxLatte.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxLatte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLatte.TabIndex = 48;
            this.pictureBoxLatte.TabStop = false;
            // 
            // pictureBoxMineralWater
            // 
            this.pictureBoxMineralWater.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMineralWater.Image")));
            this.pictureBoxMineralWater.Location = new System.Drawing.Point(594, 133);
            this.pictureBoxMineralWater.Name = "pictureBoxMineralWater";
            this.pictureBoxMineralWater.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxMineralWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMineralWater.TabIndex = 49;
            this.pictureBoxMineralWater.TabStop = false;
            // 
            // pictureBoxBlackTea
            // 
            this.pictureBoxBlackTea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlackTea.Image")));
            this.pictureBoxBlackTea.Location = new System.Drawing.Point(186, 237);
            this.pictureBoxBlackTea.Name = "pictureBoxBlackTea";
            this.pictureBoxBlackTea.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxBlackTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlackTea.TabIndex = 50;
            this.pictureBoxBlackTea.TabStop = false;
            // 
            // pictureBoxGreenTea
            // 
            this.pictureBoxGreenTea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreenTea.Image")));
            this.pictureBoxGreenTea.Location = new System.Drawing.Point(594, 239);
            this.pictureBoxGreenTea.Name = "pictureBoxGreenTea";
            this.pictureBoxGreenTea.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxGreenTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreenTea.TabIndex = 51;
            this.pictureBoxGreenTea.TabStop = false;
            // 
            // pictureBoxSugar
            // 
            this.pictureBoxSugar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSugar.Image")));
            this.pictureBoxSugar.Location = new System.Drawing.Point(26, 420);
            this.pictureBoxSugar.Name = "pictureBoxSugar";
            this.pictureBoxSugar.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxSugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSugar.TabIndex = 52;
            this.pictureBoxSugar.TabStop = false;
            // 
            // pictureBoxMilk
            // 
            this.pictureBoxMilk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMilk.Image")));
            this.pictureBoxMilk.Location = new System.Drawing.Point(160, 420);
            this.pictureBoxMilk.Name = "pictureBoxMilk";
            this.pictureBoxMilk.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMilk.TabIndex = 53;
            this.pictureBoxMilk.TabStop = false;
            // 
            // pictureBoxCream
            // 
            this.pictureBoxCream.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCream.Image")));
            this.pictureBoxCream.Location = new System.Drawing.Point(307, 423);
            this.pictureBoxCream.Name = "pictureBoxCream";
            this.pictureBoxCream.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxCream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCream.TabIndex = 54;
            this.pictureBoxCream.TabStop = false;
            // 
            // pictureBoxCinnamon
            // 
            this.pictureBoxCinnamon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCinnamon.Image")));
            this.pictureBoxCinnamon.Location = new System.Drawing.Point(455, 423);
            this.pictureBoxCinnamon.Name = "pictureBoxCinnamon";
            this.pictureBoxCinnamon.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxCinnamon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCinnamon.TabIndex = 55;
            this.pictureBoxCinnamon.TabStop = false;
            // 
            // pictureBoxMapleSyrup
            // 
            this.pictureBoxMapleSyrup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMapleSyrup.Image")));
            this.pictureBoxMapleSyrup.Location = new System.Drawing.Point(580, 423);
            this.pictureBoxMapleSyrup.Name = "pictureBoxMapleSyrup";
            this.pictureBoxMapleSyrup.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxMapleSyrup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMapleSyrup.TabIndex = 56;
            this.pictureBoxMapleSyrup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 565);
            this.Controls.Add(this.pictureBoxMapleSyrup);
            this.Controls.Add(this.pictureBoxCinnamon);
            this.Controls.Add(this.pictureBoxCream);
            this.Controls.Add(this.pictureBoxMilk);
            this.Controls.Add(this.pictureBoxSugar);
            this.Controls.Add(this.pictureBoxGreenTea);
            this.Controls.Add(this.pictureBoxBlackTea);
            this.Controls.Add(this.pictureBoxMineralWater);
            this.Controls.Add(this.pictureBoxLatte);
            this.Controls.Add(this.pictureBoxEspresso);
            this.Controls.Add(this.pictureBoxCoffee);
            this.Controls.Add(this.checkBoxForMapleSyrup);
            this.Controls.Add(this.checkBoxForCinnamon);
            this.Controls.Add(this.checkBoxForCream);
            this.Controls.Add(this.checkBoxForMilk);
            this.Controls.Add(this.checkBoxForSugar);
            this.Controls.Add(this.buttonForBeverageAdditivesAdd);
            this.Controls.Add(this.labelForBeverageAdditives);
            this.Controls.Add(this.radioButtonForGreenTea);
            this.Controls.Add(this.radioButtonForBlackTea);
            this.Controls.Add(this.radioButtonForTea);
            this.Controls.Add(this.radioButtonForMineralWater);
            this.Controls.Add(this.radioButtonForLatte);
            this.Controls.Add(this.radioButtonForEspresso);
            this.Controls.Add(this.radioButtonForCoffee);
            this.Controls.Add(this.labelForBeverage);
            this.Controls.Add(this.toOrderButton);
            this.Name = "Form1";
            this.Text = "MyCaffe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLatte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMineralWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCinnamon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapleSyrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toOrderButton;
        private System.Windows.Forms.Label labelForBeverage;
        private System.Windows.Forms.RadioButton radioButtonForCoffee;
        private System.Windows.Forms.RadioButton radioButtonForEspresso;
        private System.Windows.Forms.RadioButton radioButtonForLatte;
        private System.Windows.Forms.RadioButton radioButtonForMineralWater;
        private System.Windows.Forms.RadioButton radioButtonForTea;
        private System.Windows.Forms.RadioButton radioButtonForBlackTea;
        private System.Windows.Forms.RadioButton radioButtonForGreenTea;
        private System.Windows.Forms.Label labelForBeverageAdditives;
        private System.Windows.Forms.Button buttonForBeverageAdditivesAdd;
        private System.Windows.Forms.CheckBox checkBoxForSugar;
        private System.Windows.Forms.CheckBox checkBoxForMilk;
        private System.Windows.Forms.CheckBox checkBoxForCream;
        private System.Windows.Forms.CheckBox checkBoxForCinnamon;
        private System.Windows.Forms.CheckBox checkBoxForMapleSyrup;
        private System.Windows.Forms.PictureBox pictureBoxCoffee;
        private System.Windows.Forms.PictureBox pictureBoxEspresso;
        private System.Windows.Forms.PictureBox pictureBoxLatte;
        private System.Windows.Forms.PictureBox pictureBoxMineralWater;
        private System.Windows.Forms.PictureBox pictureBoxBlackTea;
        private System.Windows.Forms.PictureBox pictureBoxGreenTea;
        private System.Windows.Forms.PictureBox pictureBoxSugar;
        private System.Windows.Forms.PictureBox pictureBoxMilk;
        private System.Windows.Forms.PictureBox pictureBoxCream;
        private System.Windows.Forms.PictureBox pictureBoxCinnamon;
        private System.Windows.Forms.PictureBox pictureBoxMapleSyrup;
    }
}

