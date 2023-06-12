namespace KursovaHotel2
{
    partial class InformationForm
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 18;
            this.listBoxClients.Location = new System.Drawing.Point(12, 13);
            this.listBoxClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(1049, 382);
            this.listBoxClients.TabIndex = 1;
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 18;
            this.listBoxReservations.Location = new System.Drawing.Point(12, 404);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(469, 148);
            this.listBoxReservations.TabIndex = 2;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 733);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.listBoxClients);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxClients;
        private ListBox listBoxReservations;
    }
}