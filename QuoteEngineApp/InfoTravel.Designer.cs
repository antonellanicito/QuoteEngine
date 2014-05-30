namespace QuoteEngineApp
{
    partial class InfoTravel
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTripType = new System.Windows.Forms.ComboBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbTripType
            // 
            this.cmbTripType.FormattingEnabled = true;
            this.cmbTripType.Items.AddRange(new object[] {
            "SingleTrip",
            "Annual"});
            this.cmbTripType.Location = new System.Drawing.Point(49, 36);
            this.cmbTripType.Name = "cmbTripType";
            this.cmbTripType.Size = new System.Drawing.Size(121, 21);
            this.cmbTripType.TabIndex = 0;
            this.cmbTripType.Text = "Select Trip";
            this.cmbTripType.SelectedIndexChanged += new System.EventHandler(this.cmbTripType_SelectedIndexChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(239, 36);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            this.txtDays.Visible = false;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "UK",
            "EU",
            "World"});
            this.cmbDestination.Location = new System.Drawing.Point(49, 86);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(121, 21);
            this.cmbDestination.TabIndex = 2;
            this.cmbDestination.Text = "Destination";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbSex.Location = new System.Drawing.Point(49, 141);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(121, 21);
            this.cmbSex.TabIndex = 3;
            this.cmbSex.Text = "Sex";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(239, 144);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(99, 20);
            this.txtAge.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(423, 144);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(101, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Quote";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trip";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(236, 20);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Days";
            this.lblDays.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 125);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(49, 201);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(475, 190);
            this.txtBox.TabIndex = 12;
            this.txtBox.Text = "";
            // 
            // InfoTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.cmbTripType);
            this.Name = "InfoTravel";
            this.Text = "InfoTravel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTripType;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtBox;
    }
}

