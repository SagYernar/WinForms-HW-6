namespace WindowsFormsApp5
{
    partial class InformBuro
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maleComboBox = new System.Windows.Forms.ComboBox();
            this.familyComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.maleLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.showLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(76, 108);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.Text = "Фамилия";
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(76, 143);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "Имя";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(76, 177);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fatherNameTextBox.TabIndex = 2;
            this.fatherNameTextBox.Text = "Отчество";
            this.fatherNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLabel.Location = new System.Drawing.Point(73, 64);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(206, 17);
            this.editLabel.TabIndex = 4;
            this.editLabel.Text = "Внесите полную информацию";
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(76, 221);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthTimePicker.TabIndex = 5;
            // 
            // maleComboBox
            // 
            this.maleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maleComboBox.FormattingEnabled = true;
            this.maleComboBox.Location = new System.Drawing.Point(76, 262);
            this.maleComboBox.Name = "maleComboBox";
            this.maleComboBox.Size = new System.Drawing.Size(89, 21);
            this.maleComboBox.TabIndex = 6;
            // 
            // familyComboBox
            // 
            this.familyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familyComboBox.FormattingEnabled = true;
            this.familyComboBox.Location = new System.Drawing.Point(187, 262);
            this.familyComboBox.Name = "familyComboBox";
            this.familyComboBox.Size = new System.Drawing.Size(89, 21);
            this.familyComboBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(130, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(475, 115);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 13);
            this.surnameLabel.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(475, 143);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 10;
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Location = new System.Drawing.Point(475, 171);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fatherNameLabel.TabIndex = 11;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(475, 198);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(0, 13);
            this.dateOfBirthLabel.TabIndex = 12;
            // 
            // maleLabel
            // 
            this.maleLabel.AutoSize = true;
            this.maleLabel.Location = new System.Drawing.Point(475, 226);
            this.maleLabel.Name = "maleLabel";
            this.maleLabel.Size = new System.Drawing.Size(0, 13);
            this.maleLabel.TabIndex = 13;
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Location = new System.Drawing.Point(475, 253);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(0, 13);
            this.familyLabel.TabIndex = 14;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(435, 297);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 41);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(536, 297);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(63, 41);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Вперед";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showLabel.Location = new System.Drawing.Point(428, 64);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(193, 17);
            this.showLabel.TabIndex = 17;
            this.showLabel.Text = "Нажмите Вперед или Назад";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(336, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 431);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // InformBuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.maleLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.familyComboBox);
            this.Controls.Add(this.maleComboBox);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "InformBuro";
            this.Text = "Информационное бюро";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.ComboBox maleComboBox;
        private System.Windows.Forms.ComboBox familyComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label maleLabel;
        private System.Windows.Forms.Label familyLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

