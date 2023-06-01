namespace KursovaHotel2
{
    partial class ReservationForm
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
            this.btnDelAll = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.numUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.radioBtnGroupRes = new System.Windows.Forms.RadioButton();
            this.radioBtnOneRes = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveRes = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnExpiredOn = new System.Windows.Forms.Button();
            this.btnBookedOn = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxEGN = new System.Windows.Forms.TextBox();
            this.lblEGN = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(314, 585);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(81, 23);
            this.btnDelAll.TabIndex = 92;
            this.btnDelAll.Text = "Зачисти БД";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(196, 368);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 91;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Location = new System.Drawing.Point(204, 340);
            this.numUpDownAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(54, 23);
            this.numUpDownAge.TabIndex = 89;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(29, 52);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxFirstName.TabIndex = 88;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Enabled = false;
            this.lblDateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDateEnd.Location = new System.Drawing.Point(34, 449);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(173, 26);
            this.lblDateEnd.TabIndex = 87;
            this.lblDateEnd.Text = "Дата 2";
            this.lblDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateEnd.Visible = false;
            // 
            // lblDateStart
            // 
            this.lblDateStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateStart.Enabled = false;
            this.lblDateStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDateStart.Location = new System.Drawing.Point(34, 395);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(173, 26);
            this.lblDateStart.TabIndex = 86;
            this.lblDateStart.Text = "Дата 1";
            this.lblDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateStart.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(34, 539);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(365, 23);
            this.lblDuration.TabIndex = 84;
            this.lblDuration.Text = "Продължителност на престоя: ";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBtnGroupRes
            // 
            this.radioBtnGroupRes.AutoSize = true;
            this.radioBtnGroupRes.Location = new System.Drawing.Point(28, 589);
            this.radioBtnGroupRes.Name = "radioBtnGroupRes";
            this.radioBtnGroupRes.Size = new System.Drawing.Size(142, 19);
            this.radioBtnGroupRes.TabIndex = 83;
            this.radioBtnGroupRes.Text = "Групова регистрация";
            this.radioBtnGroupRes.UseVisualStyleBackColor = true;
            this.radioBtnGroupRes.Click += new System.EventHandler(this.radioBtnGroupRes_CheckedChanged);
            // 
            // radioBtnOneRes
            // 
            this.radioBtnOneRes.AutoSize = true;
            this.radioBtnOneRes.Checked = true;
            this.radioBtnOneRes.Location = new System.Drawing.Point(28, 564);
            this.radioBtnOneRes.Name = "radioBtnOneRes";
            this.radioBtnOneRes.Size = new System.Drawing.Size(150, 19);
            this.radioBtnOneRes.TabIndex = 82;
            this.radioBtnOneRes.TabStop = true;
            this.radioBtnOneRes.Text = "Единична регистрация";
            this.radioBtnOneRes.UseVisualStyleBackColor = true;
            this.radioBtnOneRes.Click += new System.EventHandler(this.radioBtnOneRes_CheckedChanged_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(152, 614);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 43);
            this.btnNext.TabIndex = 81;
            this.btnNext.Text = "Следващ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(19, 614);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 42);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveRes
            // 
            this.btnSaveRes.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveRes.Location = new System.Drawing.Point(296, 614);
            this.btnSaveRes.Name = "btnSaveRes";
            this.btnSaveRes.Size = new System.Drawing.Size(127, 43);
            this.btnSaveRes.TabIndex = 79;
            this.btnSaveRes.Text = "Завършване на регистрацията";
            this.btnSaveRes.UseVisualStyleBackColor = false;
            this.btnSaveRes.Click += new System.EventHandler(this.btnSaveRes_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(34, 509);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(106, 29);
            this.lblTotalPrice.TabIndex = 78;
            this.lblTotalPrice.Text = "Обща Цена:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExpiredOn
            // 
            this.btnExpiredOn.Location = new System.Drawing.Point(34, 424);
            this.btnExpiredOn.Name = "btnExpiredOn";
            this.btnExpiredOn.Size = new System.Drawing.Size(136, 23);
            this.btnExpiredOn.TabIndex = 77;
            this.btnExpiredOn.Text = "Дата на заминаване";
            this.btnExpiredOn.UseVisualStyleBackColor = true;
            this.btnExpiredOn.Click += new System.EventHandler(this.btnExpiredOn_Click);
            // 
            // btnBookedOn
            // 
            this.btnBookedOn.BackColor = System.Drawing.SystemColors.Control;
            this.btnBookedOn.Enabled = false;
            this.btnBookedOn.Location = new System.Drawing.Point(34, 369);
            this.btnBookedOn.Name = "btnBookedOn";
            this.btnBookedOn.Size = new System.Drawing.Size(136, 23);
            this.btnBookedOn.TabIndex = 76;
            this.btnBookedOn.Text = "Дата на пристигане";
            this.btnBookedOn.UseVisualStyleBackColor = false;
            this.btnBookedOn.Click += new System.EventHandler(this.btnBookedOn_Click);
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(28, 336);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(170, 23);
            this.lblAge.TabIndex = 75;
            this.lblAge.Text = "Възраст на клиента";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(30, 310);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(365, 23);
            this.txtBoxEmail.TabIndex = 74;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(30, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(365, 23);
            this.lblEmail.TabIndex = 73;
            this.lblEmail.Text = "Имейл адрес";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(30, 258);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(365, 23);
            this.txtBoxPhoneNumber.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 232);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(365, 23);
            this.lblPhoneNumber.TabIndex = 71;
            this.lblPhoneNumber.Text = "Телефонен номер на клиента";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(30, 206);
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(365, 23);
            this.txtBoxEGN.TabIndex = 70;
            // 
            // lblEGN
            // 
            this.lblEGN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEGN.Location = new System.Drawing.Point(30, 179);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(365, 23);
            this.lblEGN.TabIndex = 69;
            this.lblEGN.Text = "ЕГН на клиента";
            this.lblEGN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(30, 153);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxLastName.TabIndex = 68;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(30, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(365, 23);
            this.lblFirstName.TabIndex = 67;
            this.lblFirstName.Text = "Първо име на клиента";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(30, 127);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(365, 23);
            this.lblLastName.TabIndex = 66;
            this.lblLastName.Text = "Фамилия на клиента";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(30, 101);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxMiddleName.TabIndex = 65;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMiddleName.Location = new System.Drawing.Point(30, 75);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(365, 23);
            this.lblMiddleName.TabIndex = 64;
            this.lblMiddleName.Text = "Презиме на клиента";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.numUpDownAge);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.radioBtnGroupRes);
            this.Controls.Add(this.radioBtnOneRes);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveRes);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnExpiredOn);
            this.Controls.Add(this.btnBookedOn);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtBoxEGN);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelAll;
        private MonthCalendar monthCalendar;
        private NumericUpDown numUpDownAge;
        private TextBox txtBoxFirstName;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblDuration;
        private RadioButton radioBtnGroupRes;
        private RadioButton radioBtnOneRes;
        private Button btnNext;
        private Button btnBack;
        private Button btnSaveRes;
        private Label lblTotalPrice;
        private Button btnExpiredOn;
        private Button btnBookedOn;
        private Label lblAge;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtBoxEGN;
        private Label lblEGN;
        private TextBox txtBoxLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtBoxMiddleName;
        private Label lblMiddleName;
    }
}