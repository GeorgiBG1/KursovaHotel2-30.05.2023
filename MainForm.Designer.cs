﻿namespace KursovaHotel2
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
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHideForm
            // 
            this.btnHideForm.Location = new System.Drawing.Point(1025, 57);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(227, 39);
            this.btnHideForm.TabIndex = 5;
            this.btnHideForm.Text = "Назад";
            this.btnHideForm.UseVisualStyleBackColor = true;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Location = new System.Drawing.Point(12, 58);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(227, 39);
            this.btnSelectRoom.TabIndex = 3;
            this.btnSelectRoom.Text = "Избери стая";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Преглед на ресторанта";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Хотел Арте";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.Location = new System.Drawing.Point(12, 103);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new System.Drawing.Size(1240, 566);
            this.splitContainer.SplitterDistance = 413;
            this.splitContainer.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.btnSelectRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHideForm;
        private Button btnSelectRoom;
        private Button button1;
        private Label label1;
        private SplitContainer splitContainer;
    }
}