﻿namespace KursovaHotel2
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
            this.tableRooms = new System.Windows.Forms.TableLayoutPanel();
            this.btnRoom35 = new System.Windows.Forms.Button();
            this.btnRoom34 = new System.Windows.Forms.Button();
            this.btnRoom33 = new System.Windows.Forms.Button();
            this.btnRoom32 = new System.Windows.Forms.Button();
            this.btnRoom31 = new System.Windows.Forms.Button();
            this.btnRoom25 = new System.Windows.Forms.Button();
            this.btnRoom24 = new System.Windows.Forms.Button();
            this.btnRoom23 = new System.Windows.Forms.Button();
            this.btnRoom22 = new System.Windows.Forms.Button();
            this.btnRoom21 = new System.Windows.Forms.Button();
            this.btnRoom20 = new System.Windows.Forms.Button();
            this.btnRoom14 = new System.Windows.Forms.Button();
            this.btnRoom13 = new System.Windows.Forms.Button();
            this.btnRoom12 = new System.Windows.Forms.Button();
            this.lblFloor3 = new System.Windows.Forms.Label();
            this.btnRoom11 = new System.Windows.Forms.Button();
            this.lblFloor1 = new System.Windows.Forms.Label();
            this.lblFloor2 = new System.Windows.Forms.Label();
            this.btnRoom30 = new System.Windows.Forms.Button();
            this.btnRoom15 = new System.Windows.Forms.Button();
            this.btnRoom10 = new System.Windows.Forms.Button();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageWithMenus = new System.Windows.Forms.TabPage();
            this.lblMenuOnOffPage1 = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.lblSelectedMenu = new System.Windows.Forms.Label();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.lblMenuDate = new System.Windows.Forms.Label();
            this.checkedListBoxMenu = new System.Windows.Forms.CheckedListBox();
            this.tabPageBuffet = new System.Windows.Forms.TabPage();
            this.lblMenuOnOffPage2 = new System.Windows.Forms.Label();
            this.tabPageALLIn = new System.Windows.Forms.TabPage();
            this.lblMenuOnOffPage3 = new System.Windows.Forms.Label();
            this.tabPageVipMenu = new System.Windows.Forms.TabPage();
            this.lblMenuOnOffPage4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            this.tableRooms.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageWithMenus.SuspendLayout();
            this.tabPageBuffet.SuspendLayout();
            this.tabPageALLIn.SuspendLayout();
            this.tabPageVipMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(303, 565);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(103, 35);
            this.btnDelAll.TabIndex = 92;
            this.btnDelAll.Text = "Зачисти БД";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(336, 334);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 91;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Location = new System.Drawing.Point(12, 351);
            this.numUpDownAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(100, 23);
            this.numUpDownAge.TabIndex = 89;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(12, 40);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(369, 23);
            this.txtBoxFirstName.TabIndex = 88;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Enabled = false;
            this.lblDateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDateEnd.Location = new System.Drawing.Point(12, 474);
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
            this.lblDateStart.Location = new System.Drawing.Point(12, 416);
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
            this.lblDuration.Location = new System.Drawing.Point(11, 527);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(545, 23);
            this.lblDuration.TabIndex = 84;
            this.lblDuration.Text = "Продължителност на престоя: ";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBtnGroupRes
            // 
            this.radioBtnGroupRes.AutoSize = true;
            this.radioBtnGroupRes.Location = new System.Drawing.Point(12, 585);
            this.radioBtnGroupRes.Name = "radioBtnGroupRes";
            this.radioBtnGroupRes.Size = new System.Drawing.Size(142, 19);
            this.radioBtnGroupRes.TabIndex = 83;
            this.radioBtnGroupRes.Text = "Групова регистрация";
            this.radioBtnGroupRes.UseVisualStyleBackColor = true;
            this.radioBtnGroupRes.CheckedChanged += new System.EventHandler(this.radioBtnGroupRes_CheckedChanged);
            // 
            // radioBtnOneRes
            // 
            this.radioBtnOneRes.AutoSize = true;
            this.radioBtnOneRes.Checked = true;
            this.radioBtnOneRes.Location = new System.Drawing.Point(12, 565);
            this.radioBtnOneRes.Name = "radioBtnOneRes";
            this.radioBtnOneRes.Size = new System.Drawing.Size(150, 19);
            this.radioBtnOneRes.TabIndex = 82;
            this.radioBtnOneRes.TabStop = true;
            this.radioBtnOneRes.Text = "Единична регистрация";
            this.radioBtnOneRes.UseVisualStyleBackColor = true;
            this.radioBtnOneRes.CheckedChanged += new System.EventHandler(this.radioBtnOneRes_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(135, 609);
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
            this.btnBack.Location = new System.Drawing.Point(2, 610);
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
            this.btnSaveRes.Location = new System.Drawing.Point(279, 609);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(11, 498);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(256, 29);
            this.lblTotalPrice.TabIndex = 78;
            this.lblTotalPrice.Text = "Обща цена:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExpiredOn
            // 
            this.btnExpiredOn.Location = new System.Drawing.Point(12, 445);
            this.btnExpiredOn.Name = "btnExpiredOn";
            this.btnExpiredOn.Size = new System.Drawing.Size(241, 26);
            this.btnExpiredOn.TabIndex = 77;
            this.btnExpiredOn.Text = "Дата на заминаване";
            this.btnExpiredOn.UseVisualStyleBackColor = true;
            this.btnExpiredOn.Click += new System.EventHandler(this.btnExpiredOn_Click);
            // 
            // btnBookedOn
            // 
            this.btnBookedOn.BackColor = System.Drawing.SystemColors.Control;
            this.btnBookedOn.Enabled = false;
            this.btnBookedOn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBookedOn.Location = new System.Drawing.Point(12, 387);
            this.btnBookedOn.Name = "btnBookedOn";
            this.btnBookedOn.Size = new System.Drawing.Size(241, 26);
            this.btnBookedOn.TabIndex = 76;
            this.btnBookedOn.Text = "Дата на пристигане";
            this.btnBookedOn.UseVisualStyleBackColor = false;
            this.btnBookedOn.Click += new System.EventHandler(this.btnBookedOn_Click);
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(12, 325);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(307, 23);
            this.lblAge.TabIndex = 75;
            this.lblAge.Text = "Възраст на клиента";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 299);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(369, 23);
            this.txtBoxEmail.TabIndex = 74;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(12, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(369, 23);
            this.lblEmail.TabIndex = 73;
            this.lblEmail.Text = "Имейл адрес";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(12, 247);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(369, 23);
            this.txtBoxPhoneNumber.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 221);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(369, 23);
            this.lblPhoneNumber.TabIndex = 71;
            this.lblPhoneNumber.Text = "Телефонен номер на клиента";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(12, 195);
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(369, 23);
            this.txtBoxEGN.TabIndex = 70;
            // 
            // lblEGN
            // 
            this.lblEGN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEGN.Location = new System.Drawing.Point(12, 169);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(369, 23);
            this.lblEGN.TabIndex = 69;
            this.lblEGN.Text = "ЕГН на клиента";
            this.lblEGN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(12, 144);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(369, 23);
            this.txtBoxLastName.TabIndex = 68;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(12, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(369, 23);
            this.lblFirstName.TabIndex = 67;
            this.lblFirstName.Text = "Първо име на клиента";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(12, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(369, 23);
            this.lblLastName.TabIndex = 66;
            this.lblLastName.Text = "Фамилия на клиента";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(12, 92);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(369, 23);
            this.txtBoxMiddleName.TabIndex = 65;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMiddleName.Location = new System.Drawing.Point(12, 66);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(369, 23);
            this.lblMiddleName.TabIndex = 64;
            this.lblMiddleName.Text = "Презиме на клиента";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableRooms
            // 
            this.tableRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableRooms.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableRooms.ColumnCount = 7;
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableRooms.Controls.Add(this.btnRoom35, 6, 2);
            this.tableRooms.Controls.Add(this.btnRoom34, 5, 2);
            this.tableRooms.Controls.Add(this.btnRoom33, 4, 2);
            this.tableRooms.Controls.Add(this.btnRoom32, 3, 2);
            this.tableRooms.Controls.Add(this.btnRoom31, 2, 2);
            this.tableRooms.Controls.Add(this.btnRoom25, 6, 1);
            this.tableRooms.Controls.Add(this.btnRoom24, 5, 1);
            this.tableRooms.Controls.Add(this.btnRoom23, 4, 1);
            this.tableRooms.Controls.Add(this.btnRoom22, 3, 1);
            this.tableRooms.Controls.Add(this.btnRoom21, 2, 1);
            this.tableRooms.Controls.Add(this.btnRoom20, 1, 1);
            this.tableRooms.Controls.Add(this.btnRoom14, 5, 0);
            this.tableRooms.Controls.Add(this.btnRoom13, 4, 0);
            this.tableRooms.Controls.Add(this.btnRoom12, 3, 0);
            this.tableRooms.Controls.Add(this.lblFloor3, 0, 2);
            this.tableRooms.Controls.Add(this.btnRoom11, 2, 0);
            this.tableRooms.Controls.Add(this.lblFloor1, 0, 0);
            this.tableRooms.Controls.Add(this.lblFloor2, 0, 1);
            this.tableRooms.Controls.Add(this.btnRoom30, 1, 2);
            this.tableRooms.Controls.Add(this.btnRoom15, 6, 0);
            this.tableRooms.Controls.Add(this.btnRoom10, 1, 0);
            this.tableRooms.Location = new System.Drawing.Point(423, 40);
            this.tableRooms.Name = "tableRooms";
            this.tableRooms.RowCount = 3;
            this.tableRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableRooms.Size = new System.Drawing.Size(635, 176);
            this.tableRooms.TabIndex = 93;
            // 
            // btnRoom35
            // 
            this.btnRoom35.Location = new System.Drawing.Point(543, 118);
            this.btnRoom35.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom35.Name = "btnRoom35";
            this.btnRoom35.Size = new System.Drawing.Size(90, 56);
            this.btnRoom35.TabIndex = 65;
            this.btnRoom35.Text = "Ап 35";
            this.btnRoom35.UseVisualStyleBackColor = true;
            this.btnRoom35.Click += new System.EventHandler(this.btnRoom35_Click);
            // 
            // btnRoom34
            // 
            this.btnRoom34.Location = new System.Drawing.Point(451, 118);
            this.btnRoom34.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom34.Name = "btnRoom34";
            this.btnRoom34.Size = new System.Drawing.Size(90, 56);
            this.btnRoom34.TabIndex = 65;
            this.btnRoom34.Text = "Ап 34";
            this.btnRoom34.UseVisualStyleBackColor = true;
            this.btnRoom34.Click += new System.EventHandler(this.btnRoom34_Click);
            // 
            // btnRoom33
            // 
            this.btnRoom33.Location = new System.Drawing.Point(359, 118);
            this.btnRoom33.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom33.Name = "btnRoom33";
            this.btnRoom33.Size = new System.Drawing.Size(90, 56);
            this.btnRoom33.TabIndex = 65;
            this.btnRoom33.Text = "Ап 33";
            this.btnRoom33.UseVisualStyleBackColor = true;
            this.btnRoom33.Click += new System.EventHandler(this.btnRoom33_Click);
            // 
            // btnRoom32
            // 
            this.btnRoom32.Location = new System.Drawing.Point(267, 118);
            this.btnRoom32.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom32.Name = "btnRoom32";
            this.btnRoom32.Size = new System.Drawing.Size(90, 56);
            this.btnRoom32.TabIndex = 65;
            this.btnRoom32.Text = "Ап 32";
            this.btnRoom32.UseVisualStyleBackColor = true;
            this.btnRoom32.Click += new System.EventHandler(this.btnRoom32_Click);
            // 
            // btnRoom31
            // 
            this.btnRoom31.Location = new System.Drawing.Point(175, 118);
            this.btnRoom31.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom31.Name = "btnRoom31";
            this.btnRoom31.Size = new System.Drawing.Size(90, 56);
            this.btnRoom31.TabIndex = 65;
            this.btnRoom31.Text = "Ап 31";
            this.btnRoom31.UseVisualStyleBackColor = true;
            this.btnRoom31.Click += new System.EventHandler(this.btnRoom31_Click);
            // 
            // btnRoom25
            // 
            this.btnRoom25.Location = new System.Drawing.Point(543, 60);
            this.btnRoom25.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom25.Name = "btnRoom25";
            this.btnRoom25.Size = new System.Drawing.Size(90, 56);
            this.btnRoom25.TabIndex = 65;
            this.btnRoom25.Text = "Ап 25";
            this.btnRoom25.UseVisualStyleBackColor = true;
            this.btnRoom25.Click += new System.EventHandler(this.btnRoom25_Click);
            // 
            // btnRoom24
            // 
            this.btnRoom24.Location = new System.Drawing.Point(451, 60);
            this.btnRoom24.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom24.Name = "btnRoom24";
            this.btnRoom24.Size = new System.Drawing.Size(90, 56);
            this.btnRoom24.TabIndex = 65;
            this.btnRoom24.Text = "Стая 24";
            this.btnRoom24.UseVisualStyleBackColor = true;
            this.btnRoom24.Click += new System.EventHandler(this.btnRoom24_Click);
            // 
            // btnRoom23
            // 
            this.btnRoom23.Location = new System.Drawing.Point(359, 60);
            this.btnRoom23.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom23.Name = "btnRoom23";
            this.btnRoom23.Size = new System.Drawing.Size(90, 56);
            this.btnRoom23.TabIndex = 65;
            this.btnRoom23.Text = "Стая 23";
            this.btnRoom23.UseVisualStyleBackColor = true;
            this.btnRoom23.Click += new System.EventHandler(this.btnRoom23_Click);
            // 
            // btnRoom22
            // 
            this.btnRoom22.Location = new System.Drawing.Point(267, 60);
            this.btnRoom22.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom22.Name = "btnRoom22";
            this.btnRoom22.Size = new System.Drawing.Size(90, 56);
            this.btnRoom22.TabIndex = 65;
            this.btnRoom22.Text = "Стая 22";
            this.btnRoom22.UseVisualStyleBackColor = true;
            this.btnRoom22.Click += new System.EventHandler(this.btnRoom22_Click);
            // 
            // btnRoom21
            // 
            this.btnRoom21.Location = new System.Drawing.Point(175, 60);
            this.btnRoom21.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom21.Name = "btnRoom21";
            this.btnRoom21.Size = new System.Drawing.Size(90, 56);
            this.btnRoom21.TabIndex = 65;
            this.btnRoom21.Text = "Стая 21";
            this.btnRoom21.UseVisualStyleBackColor = true;
            this.btnRoom21.Click += new System.EventHandler(this.btnRoom21_Click);
            // 
            // btnRoom20
            // 
            this.btnRoom20.Location = new System.Drawing.Point(83, 60);
            this.btnRoom20.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom20.Name = "btnRoom20";
            this.btnRoom20.Size = new System.Drawing.Size(90, 56);
            this.btnRoom20.TabIndex = 65;
            this.btnRoom20.Text = "Стая 20";
            this.btnRoom20.UseVisualStyleBackColor = true;
            this.btnRoom20.Click += new System.EventHandler(this.btnRoom20_Click);
            // 
            // btnRoom14
            // 
            this.btnRoom14.Location = new System.Drawing.Point(451, 2);
            this.btnRoom14.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom14.Name = "btnRoom14";
            this.btnRoom14.Size = new System.Drawing.Size(90, 56);
            this.btnRoom14.TabIndex = 67;
            this.btnRoom14.Text = "Ап 14\r\nЗает";
            this.btnRoom14.UseVisualStyleBackColor = true;
            this.btnRoom14.Click += new System.EventHandler(this.btnRoom14_Click);
            // 
            // btnRoom13
            // 
            this.btnRoom13.Location = new System.Drawing.Point(359, 2);
            this.btnRoom13.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom13.Name = "btnRoom13";
            this.btnRoom13.Size = new System.Drawing.Size(90, 56);
            this.btnRoom13.TabIndex = 66;
            this.btnRoom13.Text = "Ап 13\r\nСвободен";
            this.btnRoom13.UseVisualStyleBackColor = true;
            this.btnRoom13.Click += new System.EventHandler(this.btnRoom13_Click);
            // 
            // btnRoom12
            // 
            this.btnRoom12.Location = new System.Drawing.Point(267, 2);
            this.btnRoom12.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom12.Name = "btnRoom12";
            this.btnRoom12.Size = new System.Drawing.Size(90, 56);
            this.btnRoom12.TabIndex = 65;
            this.btnRoom12.Text = "Стая 12";
            this.btnRoom12.UseVisualStyleBackColor = true;
            this.btnRoom12.Click += new System.EventHandler(this.btnRoom12_Click);
            // 
            // lblFloor3
            // 
            this.lblFloor3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFloor3.Location = new System.Drawing.Point(2, 118);
            this.lblFloor3.Margin = new System.Windows.Forms.Padding(0);
            this.lblFloor3.Name = "lblFloor3";
            this.lblFloor3.Size = new System.Drawing.Size(79, 56);
            this.lblFloor3.TabIndex = 65;
            this.lblFloor3.Text = "Етаж 3";
            this.lblFloor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoom11
            // 
            this.btnRoom11.Location = new System.Drawing.Point(175, 2);
            this.btnRoom11.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom11.Name = "btnRoom11";
            this.btnRoom11.Size = new System.Drawing.Size(90, 56);
            this.btnRoom11.TabIndex = 0;
            this.btnRoom11.Text = "Стая 11\r\nЗаета";
            this.btnRoom11.UseVisualStyleBackColor = true;
            this.btnRoom11.Click += new System.EventHandler(this.btnRoom11_Click);
            // 
            // lblFloor1
            // 
            this.lblFloor1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFloor1.Location = new System.Drawing.Point(2, 2);
            this.lblFloor1.Margin = new System.Windows.Forms.Padding(0);
            this.lblFloor1.Name = "lblFloor1";
            this.lblFloor1.Size = new System.Drawing.Size(79, 56);
            this.lblFloor1.TabIndex = 2;
            this.lblFloor1.Text = "Етаж 1";
            this.lblFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFloor2
            // 
            this.lblFloor2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFloor2.Location = new System.Drawing.Point(2, 60);
            this.lblFloor2.Margin = new System.Windows.Forms.Padding(0);
            this.lblFloor2.Name = "lblFloor2";
            this.lblFloor2.Size = new System.Drawing.Size(79, 56);
            this.lblFloor2.TabIndex = 3;
            this.lblFloor2.Text = "Етаж 2";
            this.lblFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoom30
            // 
            this.btnRoom30.Location = new System.Drawing.Point(83, 118);
            this.btnRoom30.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom30.Name = "btnRoom30";
            this.btnRoom30.Size = new System.Drawing.Size(90, 56);
            this.btnRoom30.TabIndex = 65;
            this.btnRoom30.Text = "Стая 30";
            this.btnRoom30.UseVisualStyleBackColor = true;
            this.btnRoom30.Click += new System.EventHandler(this.btnRoom30_Click);
            // 
            // btnRoom15
            // 
            this.btnRoom15.Location = new System.Drawing.Point(543, 2);
            this.btnRoom15.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom15.Name = "btnRoom15";
            this.btnRoom15.Size = new System.Drawing.Size(90, 56);
            this.btnRoom15.TabIndex = 67;
            this.btnRoom15.Text = "Ап 15";
            this.btnRoom15.UseVisualStyleBackColor = true;
            this.btnRoom15.Click += new System.EventHandler(this.btnRoom15_Click);
            // 
            // btnRoom10
            // 
            this.btnRoom10.Location = new System.Drawing.Point(83, 2);
            this.btnRoom10.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoom10.Name = "btnRoom10";
            this.btnRoom10.Size = new System.Drawing.Size(90, 56);
            this.btnRoom10.TabIndex = 1;
            this.btnRoom10.Text = "Стая 10\r\nСвободна";
            this.btnRoom10.UseVisualStyleBackColor = true;
            this.btnRoom10.Click += new System.EventHandler(this.btnRoom10_Click);
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageWithMenus);
            this.tabControlMenu.Controls.Add(this.tabPageBuffet);
            this.tabControlMenu.Controls.Add(this.tabPageALLIn);
            this.tabControlMenu.Controls.Add(this.tabPageVipMenu);
            this.tabControlMenu.Location = new System.Drawing.Point(423, 232);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(635, 372);
            this.tabControlMenu.TabIndex = 94;
            this.tabControlMenu.Click += new System.EventHandler(this.tabPageWithMenus_Click);
            // 
            // tabPageWithMenus
            // 
            this.tabPageWithMenus.Controls.Add(this.lblMenuOnOffPage1);
            this.tabPageWithMenus.Controls.Add(this.lblDinner);
            this.tabPageWithMenus.Controls.Add(this.lblLunch);
            this.tabPageWithMenus.Controls.Add(this.lblBreakfast);
            this.tabPageWithMenus.Controls.Add(this.btnPreviousDay);
            this.tabPageWithMenus.Controls.Add(this.lblSelectedMenu);
            this.tabPageWithMenus.Controls.Add(this.btnNextDay);
            this.tabPageWithMenus.Controls.Add(this.lblMenuDate);
            this.tabPageWithMenus.Controls.Add(this.checkedListBoxMenu);
            this.tabPageWithMenus.Location = new System.Drawing.Point(4, 24);
            this.tabPageWithMenus.Name = "tabPageWithMenus";
            this.tabPageWithMenus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWithMenus.Size = new System.Drawing.Size(627, 344);
            this.tabPageWithMenus.TabIndex = 0;
            this.tabPageWithMenus.Text = "Обикновено меню";
            this.tabPageWithMenus.UseVisualStyleBackColor = true;
            this.tabPageWithMenus.Click += new System.EventHandler(this.tabPageWithMenus_Click);
            // 
            // lblMenuOnOffPage1
            // 
            this.lblMenuOnOffPage1.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuOnOffPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuOnOffPage1.Location = new System.Drawing.Point(175, 144);
            this.lblMenuOnOffPage1.Name = "lblMenuOnOffPage1";
            this.lblMenuOnOffPage1.Size = new System.Drawing.Size(276, 56);
            this.lblMenuOnOffPage1.TabIndex = 94;
            this.lblMenuOnOffPage1.Text = "Изберете дати\r\nна резервацията!";
            this.lblMenuOnOffPage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            this.lblDinner.BackColor = System.Drawing.SystemColors.Control;
            this.lblDinner.Enabled = false;
            this.lblDinner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDinner.Location = new System.Drawing.Point(330, 129);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(260, 26);
            this.lblDinner.TabIndex = 93;
            this.lblDinner.Text = "Вечеря";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDinner.Visible = false;
            // 
            // lblLunch
            // 
            this.lblLunch.BackColor = System.Drawing.SystemColors.Control;
            this.lblLunch.Enabled = false;
            this.lblLunch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLunch.Location = new System.Drawing.Point(330, 89);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(260, 26);
            this.lblLunch.TabIndex = 92;
            this.lblLunch.Text = "Обяд";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLunch.Visible = false;
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.BackColor = System.Drawing.SystemColors.Control;
            this.lblBreakfast.Enabled = false;
            this.lblBreakfast.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBreakfast.Location = new System.Drawing.Point(330, 51);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(260, 26);
            this.lblBreakfast.TabIndex = 91;
            this.lblBreakfast.Text = "Закуска";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBreakfast.Visible = false;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Enabled = false;
            this.btnPreviousDay.Location = new System.Drawing.Point(30, 281);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(115, 38);
            this.btnPreviousDay.TabIndex = 90;
            this.btnPreviousDay.Text = "Предишен ден";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Visible = false;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // lblSelectedMenu
            // 
            this.lblSelectedMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedMenu.Enabled = false;
            this.lblSelectedMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSelectedMenu.Location = new System.Drawing.Point(330, 14);
            this.lblSelectedMenu.Name = "lblSelectedMenu";
            this.lblSelectedMenu.Size = new System.Drawing.Size(260, 26);
            this.lblSelectedMenu.TabIndex = 89;
            this.lblSelectedMenu.Text = "Избраното меню";
            this.lblSelectedMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectedMenu.Visible = false;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Enabled = false;
            this.btnNextDay.Location = new System.Drawing.Point(175, 281);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(115, 38);
            this.btnNextDay.TabIndex = 88;
            this.btnNextDay.Text = "Следващ ден";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Visible = false;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // lblMenuDate
            // 
            this.lblMenuDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuDate.Enabled = false;
            this.lblMenuDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuDate.Location = new System.Drawing.Point(30, 14);
            this.lblMenuDate.Name = "lblMenuDate";
            this.lblMenuDate.Size = new System.Drawing.Size(260, 26);
            this.lblMenuDate.TabIndex = 87;
            this.lblMenuDate.Text = "Дата 3";
            this.lblMenuDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuDate.Visible = false;
            // 
            // checkedListBoxMenu
            // 
            this.checkedListBoxMenu.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxMenu.Enabled = false;
            this.checkedListBoxMenu.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxMenu.FormattingEnabled = true;
            this.checkedListBoxMenu.Items.AddRange(new object[] {
            "Закуска",
            "Обяд",
            "Вечеря"});
            this.checkedListBoxMenu.Location = new System.Drawing.Point(30, 51);
            this.checkedListBoxMenu.Name = "checkedListBoxMenu";
            this.checkedListBoxMenu.Size = new System.Drawing.Size(260, 202);
            this.checkedListBoxMenu.TabIndex = 0;
            this.checkedListBoxMenu.Visible = false;
            this.checkedListBoxMenu.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMenu_ItemCheck);
            // 
            // tabPageBuffet
            // 
            this.tabPageBuffet.Controls.Add(this.lblMenuOnOffPage2);
            this.tabPageBuffet.Location = new System.Drawing.Point(4, 24);
            this.tabPageBuffet.Name = "tabPageBuffet";
            this.tabPageBuffet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuffet.Size = new System.Drawing.Size(627, 344);
            this.tabPageBuffet.TabIndex = 1;
            this.tabPageBuffet.Text = "Блок маса";
            this.tabPageBuffet.UseVisualStyleBackColor = true;
            this.tabPageBuffet.Click += new System.EventHandler(this.tabPageBuffet_Click);
            // 
            // lblMenuOnOffPage2
            // 
            this.lblMenuOnOffPage2.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuOnOffPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuOnOffPage2.Location = new System.Drawing.Point(175, 144);
            this.lblMenuOnOffPage2.Name = "lblMenuOnOffPage2";
            this.lblMenuOnOffPage2.Size = new System.Drawing.Size(276, 56);
            this.lblMenuOnOffPage2.TabIndex = 95;
            this.lblMenuOnOffPage2.Text = "Изберете дати\r\nна резервацията!";
            this.lblMenuOnOffPage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageALLIn
            // 
            this.tabPageALLIn.Controls.Add(this.lblMenuOnOffPage3);
            this.tabPageALLIn.Location = new System.Drawing.Point(4, 24);
            this.tabPageALLIn.Name = "tabPageALLIn";
            this.tabPageALLIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageALLIn.Size = new System.Drawing.Size(627, 344);
            this.tabPageALLIn.TabIndex = 2;
            this.tabPageALLIn.Text = "All Inclusive";
            this.tabPageALLIn.UseVisualStyleBackColor = true;
            this.tabPageALLIn.Click += new System.EventHandler(this.tabPageALLIn_Click);
            // 
            // lblMenuOnOffPage3
            // 
            this.lblMenuOnOffPage3.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuOnOffPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuOnOffPage3.Location = new System.Drawing.Point(175, 144);
            this.lblMenuOnOffPage3.Name = "lblMenuOnOffPage3";
            this.lblMenuOnOffPage3.Size = new System.Drawing.Size(276, 56);
            this.lblMenuOnOffPage3.TabIndex = 96;
            this.lblMenuOnOffPage3.Text = "Изберете дати\r\nна резервацията!";
            this.lblMenuOnOffPage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageVipMenu
            // 
            this.tabPageVipMenu.Controls.Add(this.lblMenuOnOffPage4);
            this.tabPageVipMenu.Location = new System.Drawing.Point(4, 24);
            this.tabPageVipMenu.Name = "tabPageVipMenu";
            this.tabPageVipMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVipMenu.Size = new System.Drawing.Size(627, 344);
            this.tabPageVipMenu.TabIndex = 3;
            this.tabPageVipMenu.Text = "VIP меню";
            this.tabPageVipMenu.UseVisualStyleBackColor = true;
            this.tabPageVipMenu.Click += new System.EventHandler(this.tabPageVipMenu_Click);
            // 
            // lblMenuOnOffPage4
            // 
            this.lblMenuOnOffPage4.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuOnOffPage4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuOnOffPage4.Location = new System.Drawing.Point(175, 144);
            this.lblMenuOnOffPage4.Name = "lblMenuOnOffPage4";
            this.lblMenuOnOffPage4.Size = new System.Drawing.Size(276, 56);
            this.lblMenuOnOffPage4.TabIndex = 96;
            this.lblMenuOnOffPage4.Text = "Изберете дати\r\nна резервацията!";
            this.lblMenuOnOffPage4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 657);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.tabControlMenu);
            this.Controls.Add(this.tableRooms);
            this.Controls.Add(this.btnDelAll);
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
            this.tableRooms.ResumeLayout(false);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageWithMenus.ResumeLayout(false);
            this.tabPageBuffet.ResumeLayout(false);
            this.tabPageALLIn.ResumeLayout(false);
            this.tabPageVipMenu.ResumeLayout(false);
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
        private TableLayoutPanel tableRooms;
        private Button btnRoom35;
        private Button btnRoom34;
        private Button btnRoom33;
        private Button btnRoom32;
        private Button btnRoom31;
        private Button btnRoom25;
        private Button btnRoom24;
        private Button btnRoom23;
        private Button btnRoom22;
        private Button btnRoom21;
        private Button btnRoom20;
        private Button btnRoom15;
        private Button btnRoom14;
        private Button btnRoom13;
        private Button btnRoom12;
        private Label lblFloor3;
        private Button btnRoom10;
        private Button btnRoom11;
        private Label lblFloor1;
        private Label lblFloor2;
        private Button btnRoom30;
        private TabControl tabControlMenu;
        private TabPage tabPageWithMenus;
        private TabPage tabPageBuffet;
        private TabPage tabPageALLIn;
        private TabPage tabPageVipMenu;
        private CheckedListBox checkedListBoxMenu;
        private Label lblMenuDate;
        private Button btnNextDay;
        private Label lblSelectedMenu;
        private Button btnPreviousDay;
        private Label lblDinner;
        private Label lblLunch;
        private Label lblBreakfast;
        private Label lblMenuOnOffPage1;
        private Label lblMenuOnOffPage2;
        private Label lblMenuOnOffPage3;
        private Label lblMenuOnOffPage4;
    }
}