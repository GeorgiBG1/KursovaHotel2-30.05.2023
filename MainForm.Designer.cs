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
            this.lblName = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnRoomForm = new System.Windows.Forms.Button();
            this.btnReservationForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(359, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(500, 45);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Хотел Арте";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.Location = new System.Drawing.Point(12, 103);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnRoomForm);
            this.splitContainer.Size = new System.Drawing.Size(1240, 566);
            this.splitContainer.SplitterDistance = 934;
            this.splitContainer.TabIndex = 8;
            // 
            // btnRoomForm
            // 
            this.btnRoomForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRoomForm.Location = new System.Drawing.Point(0, 0);
            this.btnRoomForm.Name = "btnRoomForm";
            this.btnRoomForm.Size = new System.Drawing.Size(18, 566);
            this.btnRoomForm.TabIndex = 0;
            this.btnRoomForm.Text = "Разгърни";
            this.btnRoomForm.UseVisualStyleBackColor = true;
            // 
            // btnReservationForm
            // 
            this.btnReservationForm.Location = new System.Drawing.Point(12, 49);
            this.btnReservationForm.Name = "btnReservationForm";
            this.btnReservationForm.Size = new System.Drawing.Size(142, 48);
            this.btnReservationForm.TabIndex = 9;
            this.btnReservationForm.Text = "Нова регистрация";
            this.btnReservationForm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnReservationForm);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Хотел Арте";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblName;
        private SplitContainer splitContainer;
        private Button btnRoomForm;
        private Button btnReservationForm;
    }
}