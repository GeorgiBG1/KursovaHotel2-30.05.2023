namespace KursovaHotel2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblName = new Label();
            splitContainer = new SplitContainer();
            btnRoomForm = new Button();
            btnReservationForm = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe Script", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(359, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(500, 45);
            lblName.TabIndex = 7;
            lblName.Text = "Хотел Арте";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = SystemColors.ControlDark;
            splitContainer.Location = new Point(12, 103);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(btnRoomForm);
            splitContainer.Panel2MinSize = 161;
            splitContainer.Size = new Size(1240, 566);
            splitContainer.SplitterDistance = 1075;
            splitContainer.TabIndex = 8;
            // 
            // btnRoomForm
            // 
            btnRoomForm.Dock = DockStyle.Left;
            btnRoomForm.Location = new Point(0, 0);
            btnRoomForm.Name = "btnRoomForm";
            btnRoomForm.Size = new Size(18, 566);
            btnRoomForm.TabIndex = 0;
            btnRoomForm.Text = "Разгърни";
            btnRoomForm.UseVisualStyleBackColor = true;
            btnRoomForm.Click += btnRoomForm_Click;
            // 
            // btnReservationForm
            // 
            btnReservationForm.Location = new Point(12, 49);
            btnReservationForm.Name = "btnReservationForm";
            btnReservationForm.Size = new Size(142, 48);
            btnReservationForm.TabIndex = 9;
            btnReservationForm.Text = "Нова регистрация";
            btnReservationForm.UseVisualStyleBackColor = true;
            btnReservationForm.Click += btnReservationForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(btnReservationForm);
            Controls.Add(splitContainer);
            Controls.Add(lblName);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Хотел Арте";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private SplitContainer splitContainer;
        private Button btnRoomForm;
        private Button btnReservationForm;
    }
}