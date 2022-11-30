namespace ChaseLab4
{
    partial class Form1
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFlight = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCredit);
            this.grpBook.Controls.Add(this.groupBox1);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(212, 304);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(70, 223);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(135, 27);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price:";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(119, 263);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(87, 35);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(10, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(7, 199);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(72, 24);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Checked = true;
            this.radCredit.Location = new System.Drawing.Point(7, 178);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(127, 24);
            this.radCredit.TabIndex = 2;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chkFlight);
            this.groupBox1.Controls.Add(this.radMexico);
            this.groupBox1.Controls.Add(this.radFlorida);
            this.groupBox1.Controls.Add(this.radCuba);
            this.groupBox1.Location = new System.Drawing.Point(7, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Location";
            // 
            // chkFlight
            // 
            this.chkFlight.AutoSize = true;
            this.chkFlight.Checked = true;
            this.chkFlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlight.Enabled = false;
            this.chkFlight.Location = new System.Drawing.Point(16, 88);
            this.chkFlight.Name = "chkFlight";
            this.chkFlight.Size = new System.Drawing.Size(154, 24);
            this.chkFlight.TabIndex = 3;
            this.chkFlight.Text = "Flight Included";
            this.chkFlight.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(16, 67);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(88, 24);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(16, 47);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(88, 24);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Checked = true;
            this.radCuba.Location = new System.Drawing.Point(16, 27);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(74, 24);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(83, 16);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 27);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTripInfo
            // 
            this.grpTripInfo.Controls.Add(this.btnConfirm);
            this.grpTripInfo.Controls.Add(this.lblDisplay);
            this.grpTripInfo.Location = new System.Drawing.Point(241, 12);
            this.grpTripInfo.Name = "grpTripInfo";
            this.grpTripInfo.Size = new System.Drawing.Size(239, 304);
            this.grpTripInfo.TabIndex = 1;
            this.grpTripInfo.TabStop = false;
            this.grpTripInfo.Text = "Trip Information";
            this.grpTripInfo.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(72, 263);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(6, 23);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(227, 217);
            this.lblDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(492, 328);
            this.Controls.Add(this.grpTripInfo);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Brayden Chase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTripInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFlight;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTripInfo;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblDisplay;
    }
}

