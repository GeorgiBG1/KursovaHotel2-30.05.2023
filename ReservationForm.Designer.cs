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
            btnDelAll = new Button();
            monthCalendar = new MonthCalendar();
            numUpDownAge = new NumericUpDown();
            txtBoxFirstName = new TextBox();
            lblDateEnd = new Label();
            lblDateStart = new Label();
            lblDuration = new Label();
            radioBtnGroupRes = new RadioButton();
            radioBtnOneRes = new RadioButton();
            btnNext = new Button();
            btnBack = new Button();
            btnSaveRes = new Button();
            lblTotalPrice = new Label();
            btnExpiredOn = new Button();
            btnBookedOn = new Button();
            lblAge = new Label();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtBoxEGN = new TextBox();
            lblEGN = new Label();
            txtBoxLastName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtBoxMiddleName = new TextBox();
            lblMiddleName = new Label();
            tableRooms = new TableLayoutPanel();
            btnRoom35 = new Button();
            btnRoom34 = new Button();
            btnRoom33 = new Button();
            btnRoom32 = new Button();
            btnRoom31 = new Button();
            btnRoom25 = new Button();
            btnRoom24 = new Button();
            btnRoom23 = new Button();
            btnRoom22 = new Button();
            btnRoom21 = new Button();
            btnRoom20 = new Button();
            btnRoom15 = new Button();
            btnRoom14 = new Button();
            btnRoom13 = new Button();
            btnRoom12 = new Button();
            lblFloor3 = new Label();
            btnRoom10 = new Button();
            btnRoom11 = new Button();
            lblFloor1 = new Label();
            lblFloor2 = new Label();
            btnRoom30 = new Button();
            tabControlMenu = new TabControl();
            tabPageWithMenus = new TabPage();
            tabPageBuffet = new TabPage();
            tabPageALLIn = new TabPage();
            tabPageVipMenu = new TabPage();
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).BeginInit();
            tableRooms.SuspendLayout();
            tabControlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelAll
            // 
            btnDelAll.Location = new Point(314, 585);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(81, 23);
            btnDelAll.TabIndex = 92;
            btnDelAll.Text = "Зачисти БД";
            btnDelAll.UseVisualStyleBackColor = true;
            btnDelAll.Click += btnDelAll_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Enabled = false;
            monthCalendar.Location = new Point(196, 368);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 91;
            monthCalendar.Visible = false;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // numUpDownAge
            // 
            numUpDownAge.Location = new Point(204, 340);
            numUpDownAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numUpDownAge.Name = "numUpDownAge";
            numUpDownAge.Size = new Size(54, 23);
            numUpDownAge.TabIndex = 89;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(29, 52);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(365, 23);
            txtBoxFirstName.TabIndex = 88;
            // 
            // lblDateEnd
            // 
            lblDateEnd.Enabled = false;
            lblDateEnd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDateEnd.Location = new Point(34, 449);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(173, 26);
            lblDateEnd.TabIndex = 87;
            lblDateEnd.Text = "Дата 2";
            lblDateEnd.TextAlign = ContentAlignment.MiddleLeft;
            lblDateEnd.Visible = false;
            // 
            // lblDateStart
            // 
            lblDateStart.BackColor = SystemColors.Control;
            lblDateStart.Enabled = false;
            lblDateStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDateStart.Location = new Point(34, 395);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(173, 26);
            lblDateStart.TabIndex = 86;
            lblDateStart.Text = "Дата 1";
            lblDateStart.TextAlign = ContentAlignment.MiddleLeft;
            lblDateStart.Visible = false;
            // 
            // lblDuration
            // 
            lblDuration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.Location = new Point(34, 539);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(365, 23);
            lblDuration.TabIndex = 84;
            lblDuration.Text = "Продължителност на престоя: ";
            lblDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioBtnGroupRes
            // 
            radioBtnGroupRes.AutoSize = true;
            radioBtnGroupRes.Location = new Point(28, 589);
            radioBtnGroupRes.Name = "radioBtnGroupRes";
            radioBtnGroupRes.Size = new Size(142, 19);
            radioBtnGroupRes.TabIndex = 83;
            radioBtnGroupRes.Text = "Групова регистрация";
            radioBtnGroupRes.UseVisualStyleBackColor = true;
            radioBtnGroupRes.Click += radioBtnGroupRes_CheckedChanged;
            // 
            // radioBtnOneRes
            // 
            radioBtnOneRes.AutoSize = true;
            radioBtnOneRes.Checked = true;
            radioBtnOneRes.Location = new Point(28, 564);
            radioBtnOneRes.Name = "radioBtnOneRes";
            radioBtnOneRes.Size = new Size(150, 19);
            radioBtnOneRes.TabIndex = 82;
            radioBtnOneRes.TabStop = true;
            radioBtnOneRes.Text = "Единична регистрация";
            radioBtnOneRes.UseVisualStyleBackColor = true;
            radioBtnOneRes.Click += radioBtnOneRes_CheckedChanged_1;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Control;
            btnNext.Enabled = false;
            btnNext.Location = new Point(152, 614);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 43);
            btnNext.TabIndex = 81;
            btnNext.Text = "Следващ";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Enabled = false;
            btnBack.Location = new Point(19, 614);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 42);
            btnBack.TabIndex = 80;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveRes
            // 
            btnSaveRes.BackColor = SystemColors.Control;
            btnSaveRes.Location = new Point(296, 614);
            btnSaveRes.Name = "btnSaveRes";
            btnSaveRes.Size = new Size(127, 43);
            btnSaveRes.TabIndex = 79;
            btnSaveRes.Text = "Завършване на регистрацията";
            btnSaveRes.UseVisualStyleBackColor = false;
            btnSaveRes.Click += btnSaveRes_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(34, 509);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(106, 29);
            lblTotalPrice.TabIndex = 78;
            lblTotalPrice.Text = "Обща Цена:";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExpiredOn
            // 
            btnExpiredOn.Location = new Point(34, 424);
            btnExpiredOn.Name = "btnExpiredOn";
            btnExpiredOn.Size = new Size(136, 23);
            btnExpiredOn.TabIndex = 77;
            btnExpiredOn.Text = "Дата на заминаване";
            btnExpiredOn.UseVisualStyleBackColor = true;
            btnExpiredOn.Click += btnExpiredOn_Click;
            // 
            // btnBookedOn
            // 
            btnBookedOn.BackColor = SystemColors.Control;
            btnBookedOn.Enabled = false;
            btnBookedOn.Location = new Point(34, 369);
            btnBookedOn.Name = "btnBookedOn";
            btnBookedOn.Size = new Size(136, 23);
            btnBookedOn.TabIndex = 76;
            btnBookedOn.Text = "Дата на пристигане";
            btnBookedOn.UseVisualStyleBackColor = false;
            btnBookedOn.Click += btnBookedOn_Click;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(28, 336);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(170, 23);
            lblAge.TabIndex = 75;
            lblAge.Text = "Възраст на клиента";
            lblAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(30, 310);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(365, 23);
            txtBoxEmail.TabIndex = 74;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(30, 284);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(365, 23);
            lblEmail.TabIndex = 73;
            lblEmail.Text = "Имейл адрес";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(30, 258);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(365, 23);
            txtBoxPhoneNumber.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(30, 232);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(365, 23);
            lblPhoneNumber.TabIndex = 71;
            lblPhoneNumber.Text = "Телефонен номер на клиента";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            txtBoxEGN.Location = new Point(30, 206);
            txtBoxEGN.Name = "txtBoxEGN";
            txtBoxEGN.Size = new Size(365, 23);
            txtBoxEGN.TabIndex = 70;
            // 
            // lblEGN
            // 
            lblEGN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEGN.Location = new Point(30, 179);
            lblEGN.Name = "lblEGN";
            lblEGN.Size = new Size(365, 23);
            lblEGN.TabIndex = 69;
            lblEGN.Text = "ЕГН на клиента";
            lblEGN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(30, 153);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(365, 23);
            txtBoxLastName.TabIndex = 68;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(30, 26);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(365, 23);
            lblFirstName.TabIndex = 67;
            lblFirstName.Text = "Първо име на клиента";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(30, 127);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(365, 23);
            lblLastName.TabIndex = 66;
            lblLastName.Text = "Фамилия на клиента";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.Location = new Point(30, 101);
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.Size = new Size(365, 23);
            txtBoxMiddleName.TabIndex = 65;
            // 
            // lblMiddleName
            // 
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(30, 75);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(365, 23);
            lblMiddleName.TabIndex = 64;
            lblMiddleName.Text = "Презиме на клиента";
            lblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableRooms
            // 
            tableRooms.BackColor = SystemColors.ActiveCaption;
            tableRooms.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableRooms.ColumnCount = 7;
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableRooms.Controls.Add(btnRoom35, 6, 2);
            tableRooms.Controls.Add(btnRoom34, 5, 2);
            tableRooms.Controls.Add(btnRoom33, 4, 2);
            tableRooms.Controls.Add(btnRoom32, 3, 2);
            tableRooms.Controls.Add(btnRoom31, 2, 2);
            tableRooms.Controls.Add(btnRoom25, 6, 1);
            tableRooms.Controls.Add(btnRoom24, 5, 1);
            tableRooms.Controls.Add(btnRoom23, 4, 1);
            tableRooms.Controls.Add(btnRoom22, 3, 1);
            tableRooms.Controls.Add(btnRoom21, 2, 1);
            tableRooms.Controls.Add(btnRoom20, 1, 1);
            tableRooms.Controls.Add(btnRoom15, 6, 0);
            tableRooms.Controls.Add(btnRoom14, 5, 0);
            tableRooms.Controls.Add(btnRoom13, 4, 0);
            tableRooms.Controls.Add(btnRoom12, 3, 0);
            tableRooms.Controls.Add(lblFloor3, 0, 2);
            tableRooms.Controls.Add(btnRoom10, 1, 0);
            tableRooms.Controls.Add(btnRoom11, 2, 0);
            tableRooms.Controls.Add(lblFloor1, 0, 0);
            tableRooms.Controls.Add(lblFloor2, 0, 1);
            tableRooms.Controls.Add(btnRoom30, 1, 2);
            tableRooms.Enabled = false;
            tableRooms.Location = new Point(424, 165);
            tableRooms.Name = "tableRooms";
            tableRooms.RowCount = 3;
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableRooms.Size = new Size(396, 116);
            tableRooms.TabIndex = 93;
            tableRooms.Visible = false;
            // 
            // btnRoom35
            // 
            btnRoom35.Location = new Point(339, 78);
            btnRoom35.Margin = new Padding(0);
            btnRoom35.Name = "btnRoom35";
            btnRoom35.Size = new Size(55, 36);
            btnRoom35.TabIndex = 65;
            btnRoom35.Text = "Ап 35";
            btnRoom35.UseVisualStyleBackColor = true;
            // 
            // btnRoom34
            // 
            btnRoom34.Location = new Point(282, 78);
            btnRoom34.Margin = new Padding(0);
            btnRoom34.Name = "btnRoom34";
            btnRoom34.Size = new Size(55, 36);
            btnRoom34.TabIndex = 65;
            btnRoom34.Text = "Ап 34";
            btnRoom34.UseVisualStyleBackColor = true;
            // 
            // btnRoom33
            // 
            btnRoom33.Location = new Point(225, 78);
            btnRoom33.Margin = new Padding(0);
            btnRoom33.Name = "btnRoom33";
            btnRoom33.Size = new Size(55, 36);
            btnRoom33.TabIndex = 65;
            btnRoom33.Text = "Ап 33";
            btnRoom33.UseVisualStyleBackColor = true;
            // 
            // btnRoom32
            // 
            btnRoom32.Location = new Point(168, 78);
            btnRoom32.Margin = new Padding(0);
            btnRoom32.Name = "btnRoom32";
            btnRoom32.Size = new Size(55, 36);
            btnRoom32.TabIndex = 65;
            btnRoom32.Text = "Ап 32";
            btnRoom32.UseVisualStyleBackColor = true;
            // 
            // btnRoom31
            // 
            btnRoom31.Location = new Point(111, 78);
            btnRoom31.Margin = new Padding(0);
            btnRoom31.Name = "btnRoom31";
            btnRoom31.Size = new Size(55, 36);
            btnRoom31.TabIndex = 65;
            btnRoom31.Text = "Ап 31";
            btnRoom31.UseVisualStyleBackColor = true;
            // 
            // btnRoom25
            // 
            btnRoom25.Location = new Point(339, 40);
            btnRoom25.Margin = new Padding(0);
            btnRoom25.Name = "btnRoom25";
            btnRoom25.Size = new Size(55, 36);
            btnRoom25.TabIndex = 65;
            btnRoom25.Text = "Ап 25";
            btnRoom25.UseVisualStyleBackColor = true;
            // 
            // btnRoom24
            // 
            btnRoom24.Location = new Point(282, 40);
            btnRoom24.Margin = new Padding(0);
            btnRoom24.Name = "btnRoom24";
            btnRoom24.Size = new Size(55, 36);
            btnRoom24.TabIndex = 65;
            btnRoom24.Text = "Стая 24";
            btnRoom24.UseVisualStyleBackColor = true;
            // 
            // btnRoom23
            // 
            btnRoom23.Location = new Point(225, 40);
            btnRoom23.Margin = new Padding(0);
            btnRoom23.Name = "btnRoom23";
            btnRoom23.Size = new Size(55, 36);
            btnRoom23.TabIndex = 65;
            btnRoom23.Text = "Стая 23";
            btnRoom23.UseVisualStyleBackColor = true;
            // 
            // btnRoom22
            // 
            btnRoom22.Location = new Point(168, 40);
            btnRoom22.Margin = new Padding(0);
            btnRoom22.Name = "btnRoom22";
            btnRoom22.Size = new Size(55, 36);
            btnRoom22.TabIndex = 65;
            btnRoom22.Text = "Стая 22";
            btnRoom22.UseVisualStyleBackColor = true;
            // 
            // btnRoom21
            // 
            btnRoom21.Location = new Point(111, 40);
            btnRoom21.Margin = new Padding(0);
            btnRoom21.Name = "btnRoom21";
            btnRoom21.Size = new Size(55, 36);
            btnRoom21.TabIndex = 65;
            btnRoom21.Text = "Стая 21";
            btnRoom21.UseVisualStyleBackColor = true;
            // 
            // btnRoom20
            // 
            btnRoom20.Location = new Point(54, 40);
            btnRoom20.Margin = new Padding(0);
            btnRoom20.Name = "btnRoom20";
            btnRoom20.Size = new Size(55, 36);
            btnRoom20.TabIndex = 65;
            btnRoom20.Text = "Стая 20";
            btnRoom20.UseVisualStyleBackColor = true;
            // 
            // btnRoom15
            // 
            btnRoom15.Location = new Point(339, 2);
            btnRoom15.Margin = new Padding(0);
            btnRoom15.Name = "btnRoom15";
            btnRoom15.Size = new Size(55, 36);
            btnRoom15.TabIndex = 67;
            btnRoom15.Text = "Ап 15";
            btnRoom15.UseVisualStyleBackColor = true;
            // 
            // btnRoom14
            // 
            btnRoom14.Location = new Point(282, 2);
            btnRoom14.Margin = new Padding(0);
            btnRoom14.Name = "btnRoom14";
            btnRoom14.Size = new Size(55, 36);
            btnRoom14.TabIndex = 67;
            btnRoom14.Text = "Ап 14";
            btnRoom14.UseVisualStyleBackColor = true;
            // 
            // btnRoom13
            // 
            btnRoom13.Location = new Point(225, 2);
            btnRoom13.Margin = new Padding(0);
            btnRoom13.Name = "btnRoom13";
            btnRoom13.Size = new Size(55, 36);
            btnRoom13.TabIndex = 66;
            btnRoom13.Text = "Ап 13";
            btnRoom13.UseVisualStyleBackColor = true;
            // 
            // btnRoom12
            // 
            btnRoom12.Location = new Point(168, 2);
            btnRoom12.Margin = new Padding(0);
            btnRoom12.Name = "btnRoom12";
            btnRoom12.Size = new Size(55, 36);
            btnRoom12.TabIndex = 65;
            btnRoom12.Text = "Стая 12";
            btnRoom12.UseVisualStyleBackColor = true;
            // 
            // lblFloor3
            // 
            lblFloor3.BackColor = SystemColors.AppWorkspace;
            lblFloor3.Location = new Point(2, 78);
            lblFloor3.Margin = new Padding(0);
            lblFloor3.Name = "lblFloor3";
            lblFloor3.Size = new Size(50, 36);
            lblFloor3.TabIndex = 65;
            lblFloor3.Text = "Етаж 3";
            lblFloor3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRoom10
            // 
            btnRoom10.Location = new Point(54, 2);
            btnRoom10.Margin = new Padding(0);
            btnRoom10.Name = "btnRoom10";
            btnRoom10.Size = new Size(55, 36);
            btnRoom10.TabIndex = 1;
            btnRoom10.Text = "Стая 10";
            btnRoom10.UseVisualStyleBackColor = true;
            // 
            // btnRoom11
            // 
            btnRoom11.Location = new Point(111, 2);
            btnRoom11.Margin = new Padding(0);
            btnRoom11.Name = "btnRoom11";
            btnRoom11.Size = new Size(55, 36);
            btnRoom11.TabIndex = 0;
            btnRoom11.Text = "Стая 11";
            btnRoom11.UseVisualStyleBackColor = true;
            // 
            // lblFloor1
            // 
            lblFloor1.BackColor = SystemColors.AppWorkspace;
            lblFloor1.Location = new Point(2, 2);
            lblFloor1.Margin = new Padding(0);
            lblFloor1.Name = "lblFloor1";
            lblFloor1.Size = new Size(50, 36);
            lblFloor1.TabIndex = 2;
            lblFloor1.Text = "Етаж 1";
            lblFloor1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFloor2
            // 
            lblFloor2.BackColor = SystemColors.AppWorkspace;
            lblFloor2.Location = new Point(2, 40);
            lblFloor2.Margin = new Padding(0);
            lblFloor2.Name = "lblFloor2";
            lblFloor2.Size = new Size(50, 36);
            lblFloor2.TabIndex = 3;
            lblFloor2.Text = "Етаж 2";
            lblFloor2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRoom30
            // 
            btnRoom30.Location = new Point(54, 78);
            btnRoom30.Margin = new Padding(0);
            btnRoom30.Name = "btnRoom30";
            btnRoom30.Size = new Size(55, 36);
            btnRoom30.TabIndex = 65;
            btnRoom30.Text = "Стая 30";
            btnRoom30.UseVisualStyleBackColor = true;
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(tabPageWithMenus);
            tabControlMenu.Controls.Add(tabPageBuffet);
            tabControlMenu.Controls.Add(tabPageALLIn);
            tabControlMenu.Controls.Add(tabPageVipMenu);
            tabControlMenu.Enabled = false;
            tabControlMenu.Location = new Point(440, 310);
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(396, 258);
            tabControlMenu.TabIndex = 94;
            tabControlMenu.Visible = false;
            // 
            // tabPageWithMenus
            // 
            tabPageWithMenus.Location = new Point(4, 24);
            tabPageWithMenus.Name = "tabPageWithMenus";
            tabPageWithMenus.Padding = new Padding(3);
            tabPageWithMenus.Size = new Size(388, 230);
            tabPageWithMenus.TabIndex = 0;
            tabPageWithMenus.Text = "Обикновено меню";
            tabPageWithMenus.UseVisualStyleBackColor = true;
            // 
            // tabPageBuffet
            // 
            tabPageBuffet.Location = new Point(4, 24);
            tabPageBuffet.Name = "tabPageBuffet";
            tabPageBuffet.Padding = new Padding(3);
            tabPageBuffet.Size = new Size(388, 230);
            tabPageBuffet.TabIndex = 1;
            tabPageBuffet.Text = "Блок маса";
            tabPageBuffet.UseVisualStyleBackColor = true;
            // 
            // tabPageALLIn
            // 
            tabPageALLIn.Location = new Point(4, 24);
            tabPageALLIn.Name = "tabPageALLIn";
            tabPageALLIn.Padding = new Padding(3);
            tabPageALLIn.Size = new Size(388, 230);
            tabPageALLIn.TabIndex = 2;
            tabPageALLIn.Text = "All Inclusive";
            tabPageALLIn.UseVisualStyleBackColor = true;
            // 
            // tabPageVipMenu
            // 
            tabPageVipMenu.Location = new Point(4, 24);
            tabPageVipMenu.Name = "tabPageVipMenu";
            tabPageVipMenu.Padding = new Padding(3);
            tabPageVipMenu.Size = new Size(388, 230);
            tabPageVipMenu.TabIndex = 3;
            tabPageVipMenu.Text = "VIP меню";
            tabPageVipMenu.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControlMenu);
            Controls.Add(tableRooms);
            Controls.Add(btnDelAll);
            Controls.Add(monthCalendar);
            Controls.Add(numUpDownAge);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(lblDuration);
            Controls.Add(radioBtnGroupRes);
            Controls.Add(radioBtnOneRes);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnSaveRes);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnExpiredOn);
            Controls.Add(btnBookedOn);
            Controls.Add(lblAge);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtBoxEGN);
            Controls.Add(lblEGN);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxMiddleName);
            Controls.Add(lblMiddleName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationForm";
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).EndInit();
            tableRooms.ResumeLayout(false);
            tabControlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}