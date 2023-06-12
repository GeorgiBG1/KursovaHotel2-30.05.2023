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
            listBoxClients = new ListBox();
            listBoxReservations = new ListBox();
            SuspendLayout();
            // 
            // listBoxClients
            // 
            listBoxClients.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 18;
            listBoxClients.Location = new Point(12, 13);
            listBoxClients.Margin = new Padding(3, 4, 3, 4);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(1049, 382);
            listBoxClients.TabIndex = 1;
            // 
            // listBoxReservations
            // 
            listBoxReservations.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxReservations.FormattingEnabled = true;
            listBoxReservations.ItemHeight = 18;
            listBoxReservations.Location = new Point(12, 404);
            listBoxReservations.Name = "listBoxReservations";
            listBoxReservations.Size = new Size(566, 148);
            listBoxReservations.TabIndex = 2;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 733);
            Controls.Add(listBoxReservations);
            Controls.Add(listBoxClients);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InformationForm";
            Text = "InformationForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxClients;
        private ListBox listBoxReservations;
    }
}