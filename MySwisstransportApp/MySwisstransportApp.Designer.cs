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
            this.dtp_Datum = new System.Windows.Forms.DateTimePicker();
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
            this.dtp_Zeit = new System.Windows.Forms.DateTimePicker();
            this.cbo_Startstation = new System.Windows.Forms.ComboBox();
            this.cbo_Endstation = new System.Windows.Forms.ComboBox();
            this.lbl_Zeit = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abfahrstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Datum
            // 
            this.dtp_Datum.Location = new System.Drawing.Point(549, 116);
            this.dtp_Datum.Name = "dtp_Datum";
            this.dtp_Datum.Size = new System.Drawing.Size(200, 23);
            this.dtp_Datum.TabIndex = 3;
            this.dtp_Datum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Endstation_KeyDown);
            // 
            // lbl_Startstation
            // 
            this.lbl_Startstation.AutoSize = true;
            this.lbl_Startstation.Location = new System.Drawing.Point(258, 34);
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
            this.lbl_Datum.Location = new System.Drawing.Point(577, 98);
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
            this.dgv_Verbindungen.Location = new System.Drawing.Point(180, 201);
            this.dgv_Verbindungen.Name = "dgv_Verbindungen";
            this.dgv_Verbindungen.RowTemplate.Height = 25;
            this.dgv_Verbindungen.Size = new System.Drawing.Size(743, 209);
            this.dgv_Verbindungen.TabIndex = 9;
            this.dgv_Verbindungen.TabStop = false;
            // 
            // Column_Abfahrt
            // 
            this.Column_Abfahrt.HeaderText = "Abfahrt";
            this.Column_Abfahrt.Name = "Column_Abfahrt";
            this.Column_Abfahrt.Width = 200;
            // 
            // Column_Ankunft
            // 
            this.Column_Ankunft.HeaderText = "Ankunft";
            this.Column_Ankunft.Name = "Column_Ankunft";
            this.Column_Ankunft.Width = 200;
            // 
            // Column_Linie
            // 
            this.Column_Linie.HeaderText = "Linie";
            this.Column_Linie.Name = "Column_Linie";
            this.Column_Linie.Width = 200;
            // 
            // Column_Reisezeit
            // 
            this.Column_Reisezeit.HeaderText = "Reisezeit";
            this.Column_Reisezeit.Name = "Column_Reisezeit";
            // 
            // lbl_Verbindungen
            // 
            this.lbl_Verbindungen.AutoSize = true;
            this.lbl_Verbindungen.ForeColor = System.Drawing.Color.Black;
            this.lbl_Verbindungen.Location = new System.Drawing.Point(493, 183);
            this.lbl_Verbindungen.Name = "lbl_Verbindungen";
            this.lbl_Verbindungen.Size = new System.Drawing.Size(127, 15);
            this.lbl_Verbindungen.TabIndex = 10;
            this.lbl_Verbindungen.Text = "Nächste Verbindungen";
            // 
            // lbl_Abfahrtstafel
            // 
            this.lbl_Abfahrtstafel.AutoSize = true;
            this.lbl_Abfahrtstafel.Location = new System.Drawing.Point(515, 423);
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
            this.dgv_Abfahrstafel.Location = new System.Drawing.Point(290, 441);
            this.dgv_Abfahrstafel.Name = "dgv_Abfahrstafel";
            this.dgv_Abfahrstafel.RowTemplate.Height = 25;
            this.dgv_Abfahrstafel.Size = new System.Drawing.Size(520, 173);
            this.dgv_Abfahrstafel.TabIndex = 12;
            this.dgv_Abfahrstafel.TabStop = false;
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
            this.Column_Abfahrtstafel_Linie.HeaderText = "Zug(A)/Bus(B)";
            this.Column_Abfahrtstafel_Linie.Name = "Column_Abfahrtstafel_Linie";
            // 
            // Column_Number
            // 
            this.Column_Number.HeaderText = "Nummer";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.Width = 75;
            // 
            // dtp_Zeit
            // 
            this.dtp_Zeit.CustomFormat = "HH:mm";
            this.dtp_Zeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Zeit.Location = new System.Drawing.Point(549, 55);
            this.dtp_Zeit.Name = "dtp_Zeit";
            this.dtp_Zeit.ShowUpDown = true;
            this.dtp_Zeit.Size = new System.Drawing.Size(200, 23);
            this.dtp_Zeit.TabIndex = 2;
            this.dtp_Zeit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Endstation_KeyDown);
            // 
            // cbo_Startstation
            // 
            this.cbo_Startstation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbo_Startstation.FormattingEnabled = true;
            this.cbo_Startstation.Location = new System.Drawing.Point(180, 58);
            this.cbo_Startstation.Name = "cbo_Startstation";
            this.cbo_Startstation.Size = new System.Drawing.Size(295, 23);
            this.cbo_Startstation.TabIndex = 0;
            this.cbo_Startstation.Text = "Einsteigestation eingeben";
            this.cbo_Startstation.TextChanged += new System.EventHandler(this.cbo_Startstation_TextChanged);
            this.cbo_Startstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_Startstation_KeyDown);
            this.cbo_Startstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbo_Startstation_KeyUp);
            // 
            // cbo_Endstation
            // 
            this.cbo_Endstation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbo_Endstation.FormattingEnabled = true;
            this.cbo_Endstation.Location = new System.Drawing.Point(180, 116);
            this.cbo_Endstation.Name = "cbo_Endstation";
            this.cbo_Endstation.Size = new System.Drawing.Size(295, 23);
            this.cbo_Endstation.TabIndex = 1;
            this.cbo_Endstation.Text = "Ausstegiestation eingeben";
            this.cbo_Endstation.TextChanged += new System.EventHandler(this.cbo_Endstation_TextChanged);
            this.cbo_Endstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Endstation_KeyDown);
            this.cbo_Endstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbo_Endstation_KeyUp);
            // 
            // lbl_Zeit
            // 
            this.lbl_Zeit.AutoSize = true;
            this.lbl_Zeit.Location = new System.Drawing.Point(577, 34);
            this.lbl_Zeit.Name = "lbl_Zeit";
            this.lbl_Zeit.Size = new System.Drawing.Size(27, 15);
            this.lbl_Zeit.TabIndex = 14;
            this.lbl_Zeit.Text = "Zeit";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.Location = new System.Drawing.Point(778, 55);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(164, 84);
            this.btn_Suchen.TabIndex = 4;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = true;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            this.btn_Suchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Endstation_KeyDown);
            // 
            // MySwisstransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 626);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.lbl_Zeit);
            this.Controls.Add(this.cbo_Endstation);
            this.Controls.Add(this.cbo_Startstation);
            this.Controls.Add(this.dtp_Zeit);
            this.Controls.Add(this.dgv_Abfahrstafel);
            this.Controls.Add(this.lbl_Abfahrtstafel);
            this.Controls.Add(this.lbl_Verbindungen);
            this.Controls.Add(this.dgv_Verbindungen);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_Endstation);
            this.Controls.Add(this.lbl_Startstation);
            this.Controls.Add(this.dtp_Datum);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MySwisstransportApp";
            this.Text = "MySwisstransportApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abfahrstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtp_Datum;
        private Label lbl_Startstation;
        private Label lbl_Endstation;
        private Label lbl_Datum;
        private DataGridView dgv_Verbindungen;
        private Label lbl_Verbindungen;
        private Label lbl_Abfahrtstafel;
        private DataGridView dgv_Abfahrstafel;
        private DateTimePicker dtp_Zeit;
        private ComboBox cbo_Startstation;
        private ComboBox cbo_Endstation;
        private Label lbl_Zeit;
        private Button btn_Suchen;
        private DataGridViewTextBoxColumn Column_Abfahrt;
        private DataGridViewTextBoxColumn Column_Ankunft;
        private DataGridViewTextBoxColumn Column_Linie;
        private DataGridViewTextBoxColumn Column_Reisezeit;
        private DataGridViewTextBoxColumn Column_Zeit;
        private DataGridViewTextBoxColumn Column_Nach;
        private DataGridViewTextBoxColumn Column_Abfahrtstafel_Linie;
        private DataGridViewTextBoxColumn Column_Number;
    }
}