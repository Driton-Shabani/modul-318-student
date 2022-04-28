namespace MySwisstransportApp
{
    partial class MySwisstransportApp
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
            this.tbx_Startstation = new System.Windows.Forms.TextBox();
            this.tbx_Endstation = new System.Windows.Forms.TextBox();
            this.dtp_Datum = new System.Windows.Forms.DateTimePicker();
            this.nud_Zeitauswahl = new System.Windows.Forms.NumericUpDown();
            this.lbl_Startstation = new System.Windows.Forms.Label();
            this.lbl_Endstation = new System.Windows.Forms.Label();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.dgv_Verbindungen = new System.Windows.Forms.DataGridView();
            this.Column_Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Linie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Reisezeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Verbindungen = new System.Windows.Forms.Label();
            this.lbl_Abfahrtstafel = new System.Windows.Forms.Label();
            this.dgv_Abfahrstafel = new System.Windows.Forms.DataGridView();
            this.Column_Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Abfahrtstafel_Linie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Zeitauswahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abfahrstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Startstation
            // 
            this.tbx_Startstation.Location = new System.Drawing.Point(258, 47);
            this.tbx_Startstation.Name = "tbx_Startstation";
            this.tbx_Startstation.Size = new System.Drawing.Size(268, 23);
            this.tbx_Startstation.TabIndex = 0;
            this.tbx_Startstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Startstatioin_KeyDown);
            // 
            // tbx_Endstation
            // 
            this.tbx_Endstation.Location = new System.Drawing.Point(258, 116);
            this.tbx_Endstation.Name = "tbx_Endstation";
            this.tbx_Endstation.Size = new System.Drawing.Size(268, 23);
            this.tbx_Endstation.TabIndex = 1;
            this.tbx_Endstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Endstation_KeyDown);
            // 
            // dtp_Datum
            // 
            this.dtp_Datum.Location = new System.Drawing.Point(577, 47);
            this.dtp_Datum.Name = "dtp_Datum";
            this.dtp_Datum.Size = new System.Drawing.Size(200, 23);
            this.dtp_Datum.TabIndex = 2;
            // 
            // nud_Zeitauswahl
            // 
            this.nud_Zeitauswahl.Location = new System.Drawing.Point(577, 116);
            this.nud_Zeitauswahl.Name = "nud_Zeitauswahl";
            this.nud_Zeitauswahl.Size = new System.Drawing.Size(200, 23);
            this.nud_Zeitauswahl.TabIndex = 3;
            // 
            // lbl_Startstation
            // 
            this.lbl_Startstation.AutoSize = true;
            this.lbl_Startstation.Location = new System.Drawing.Point(258, 29);
            this.lbl_Startstation.Name = "lbl_Startstation";
            this.lbl_Startstation.Size = new System.Drawing.Size(67, 15);
            this.lbl_Startstation.TabIndex = 4;
            this.lbl_Startstation.Text = "Startstation";
            // 
            // lbl_Endstation
            // 
            this.lbl_Endstation.AutoSize = true;
            this.lbl_Endstation.Location = new System.Drawing.Point(258, 98);
            this.lbl_Endstation.Name = "lbl_Endstation";
            this.lbl_Endstation.Size = new System.Drawing.Size(63, 15);
            this.lbl_Endstation.TabIndex = 5;
            this.lbl_Endstation.Text = "Endstation";
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(577, 29);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(43, 15);
            this.lbl_Datum.TabIndex = 6;
            this.lbl_Datum.Text = "Datum";
            // 
            // dgv_Verbindungen
            // 
            this.dgv_Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Abfahrt,
            this.Column_Ankunft,
            this.Column_Linie,
            this.Column_Reisezeit});
            this.dgv_Verbindungen.Location = new System.Drawing.Point(83, 178);
            this.dgv_Verbindungen.Name = "dgv_Verbindungen";
            this.dgv_Verbindungen.RowTemplate.Height = 25;
            this.dgv_Verbindungen.Size = new System.Drawing.Size(443, 436);
            this.dgv_Verbindungen.TabIndex = 9;
            // 
            // Column_Abfahrt
            // 
            this.Column_Abfahrt.HeaderText = "Abfahrt";
            this.Column_Abfahrt.Name = "Column_Abfahrt";
            // 
            // Column_Ankunft
            // 
            this.Column_Ankunft.HeaderText = "Ankunft";
            this.Column_Ankunft.Name = "Column_Ankunft";
            // 
            // Column_Linie
            // 
            this.Column_Linie.HeaderText = "Linie";
            this.Column_Linie.Name = "Column_Linie";
            // 
            // Column_Reisezeit
            // 
            this.Column_Reisezeit.HeaderText = "Reisezeit";
            this.Column_Reisezeit.Name = "Column_Reisezeit";
            // 
            // lbl_Verbindungen
            // 
            this.lbl_Verbindungen.AutoSize = true;
            this.lbl_Verbindungen.Location = new System.Drawing.Point(103, 152);
            this.lbl_Verbindungen.Name = "lbl_Verbindungen";
            this.lbl_Verbindungen.Size = new System.Drawing.Size(127, 15);
            this.lbl_Verbindungen.TabIndex = 10;
            this.lbl_Verbindungen.Text = "Nächste Verbindungen";
            // 
            // lbl_Abfahrtstafel
            // 
            this.lbl_Abfahrtstafel.AutoSize = true;
            this.lbl_Abfahrtstafel.Location = new System.Drawing.Point(577, 160);
            this.lbl_Abfahrtstafel.Name = "lbl_Abfahrtstafel";
            this.lbl_Abfahrtstafel.Size = new System.Drawing.Size(75, 15);
            this.lbl_Abfahrtstafel.TabIndex = 11;
            this.lbl_Abfahrtstafel.Text = "Abfahrtstafel";
            // 
            // dgv_Abfahrstafel
            // 
            this.dgv_Abfahrstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Abfahrstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Zeit,
            this.Column_Nach,
            this.Column_Abfahrtstafel_Linie,
            this.Column_Number});
            this.dgv_Abfahrstafel.Location = new System.Drawing.Point(577, 178);
            this.dgv_Abfahrstafel.Name = "dgv_Abfahrstafel";
            this.dgv_Abfahrstafel.RowTemplate.Height = 25;
            this.dgv_Abfahrstafel.Size = new System.Drawing.Size(495, 436);
            this.dgv_Abfahrstafel.TabIndex = 12;
            // 
            // Column_Zeit
            // 
            this.Column_Zeit.HeaderText = "Zeit";
            this.Column_Zeit.Name = "Column_Zeit";
            this.Column_Zeit.Width = 150;
            // 
            // Column_Nach
            // 
            this.Column_Nach.HeaderText = "Nach";
            this.Column_Nach.Name = "Column_Nach";
            this.Column_Nach.Width = 150;
            // 
            // Column_Abfahrtstafel_Linie
            // 
            this.Column_Abfahrtstafel_Linie.HeaderText = "Gleis/Kante";
            this.Column_Abfahrtstafel_Linie.Name = "Column_Abfahrtstafel_Linie";
            this.Column_Abfahrtstafel_Linie.Width = 75;
            // 
            // Column_Number
            // 
            this.Column_Number.HeaderText = "Nummer";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.Width = 75;
            // 
            // MySwisstransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 626);
            this.Controls.Add(this.dgv_Abfahrstafel);
            this.Controls.Add(this.lbl_Abfahrtstafel);
            this.Controls.Add(this.lbl_Verbindungen);
            this.Controls.Add(this.dgv_Verbindungen);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_Endstation);
            this.Controls.Add(this.lbl_Startstation);
            this.Controls.Add(this.nud_Zeitauswahl);
            this.Controls.Add(this.dtp_Datum);
            this.Controls.Add(this.tbx_Endstation);
            this.Controls.Add(this.tbx_Startstation);
            this.Name = "MySwisstransportApp";
            this.Text = "MySwisstransportApp";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Zeitauswahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abfahrstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_Startstation;
        private TextBox tbx_Endstation;
        private DateTimePicker dtp_Datum;
        private NumericUpDown nud_Zeitauswahl;
        private Label lbl_Startstation;
        private Label lbl_Endstation;
        private Label lbl_Datum;
        private DataGridView dgv_Verbindungen;
        private DataGridViewTextBoxColumn Column_Abfahrt;
        private DataGridViewTextBoxColumn Column_Ankunft;
        private DataGridViewTextBoxColumn Column_Linie;
        private DataGridViewTextBoxColumn Column_Reisezeit;
        private Label lbl_Verbindungen;
        private Label lbl_Abfahrtstafel;
        private DataGridView dgv_Abfahrstafel;
        private DataGridViewTextBoxColumn Column_Zeit;
        private DataGridViewTextBoxColumn Column_Nach;
        private DataGridViewTextBoxColumn Column_Abfahrtstafel_Linie;
        private DataGridViewTextBoxColumn Column_Number;
    }
}