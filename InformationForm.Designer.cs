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
            btnDisableRes = new Button();
            numResIndex = new NumericUpDown();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)numResIndex).BeginInit();
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
            // btnDisableRes
            // 
            btnDisableRes.Location = new Point(654, 404);
            btnDisableRes.Name = "btnDisableRes";
            btnDisableRes.Size = new Size(197, 31);
            btnDisableRes.TabIndex = 3;
            btnDisableRes.Text = "Прекрати резервация";
            btnDisableRes.UseVisualStyleBackColor = true;
            btnDisableRes.Click += btnDisableRes_Click;
            // 
            // numResIndex
            // 
            numResIndex.Location = new Point(589, 404);
            numResIndex.Name = "numResIndex";
            numResIndex.Size = new Size(59, 27);
            numResIndex.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(861, 405);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 30);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Опресни";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 733);
            Controls.Add(btnRefresh);
            Controls.Add(numResIndex);
            Controls.Add(btnDisableRes);
            Controls.Add(listBoxReservations);
            Controls.Add(listBoxClients);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InformationForm";
            Text = "InformationForm";
            ((System.ComponentModel.ISupportInitialize)numResIndex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxClients;
        private ListBox listBoxReservations;
        private Button btnDisableRes;
        private NumericUpDown numResIndex;
        private Button btnRefresh;
    }
}