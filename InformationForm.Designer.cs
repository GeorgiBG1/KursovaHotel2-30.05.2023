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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.btnDisableRes = new System.Windows.Forms.Button();
            this.numResIndex = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numResIndex)).BeginInit();
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
            this.listBoxReservations.Size = new System.Drawing.Size(714, 148);
            this.listBoxReservations.TabIndex = 2;
            // 
            // btnDisableRes
            // 
            this.btnDisableRes.Location = new System.Drawing.Point(864, 409);
            this.btnDisableRes.Name = "btnDisableRes";
            this.btnDisableRes.Size = new System.Drawing.Size(197, 37);
            this.btnDisableRes.TabIndex = 3;
            this.btnDisableRes.Text = "Прекрати резервация";
            this.btnDisableRes.UseVisualStyleBackColor = true;
            this.btnDisableRes.Click += new System.EventHandler(this.btnDisableRes_Click);
            // 
            // numResIndex
            // 
            this.numResIndex.Location = new System.Drawing.Point(799, 409);
            this.numResIndex.Name = "numResIndex";
            this.numResIndex.Size = new System.Drawing.Size(59, 27);
            this.numResIndex.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(889, 452);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Опресни";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1217, 733);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.numResIndex);
            this.Controls.Add(this.btnDisableRes);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.listBoxClients);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numResIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxClients;
        private ListBox listBoxReservations;
        private Button btnDisableRes;
        private NumericUpDown numResIndex;
        private Button btnRefresh;
    }
}