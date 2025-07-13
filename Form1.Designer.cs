namespace FirmaXML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnXmlSpeichern = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvHMitarbeiter = new DataGridView();
            hVorname = new DataGridViewTextBoxColumn();
            hNachname = new DataGridViewTextBoxColumn();
            hTelefonnummer = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnHinzufuegen = new Button();
            txtVName = new TextBox();
            txtNName = new TextBox();
            txtTNummer = new TextBox();
            tabPage2 = new TabPage();
            btnDLesen = new Button();
            dgvMitarbeiter = new DataGridView();
            VName = new DataGridViewTextBoxColumn();
            NName = new DataGridViewTextBoxColumn();
            TNummer = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHMitarbeiter).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMitarbeiter).BeginInit();
            SuspendLayout();
            // 
            // btnXmlSpeichern
            // 
            btnXmlSpeichern.Location = new Point(636, 478);
            btnXmlSpeichern.Name = "btnXmlSpeichern";
            btnXmlSpeichern.Size = new Size(185, 29);
            btnXmlSpeichern.TabIndex = 9;
            btnXmlSpeichern.Text = "XML-Datei Schreiben";
            btnXmlSpeichern.UseVisualStyleBackColor = true;
            btnXmlSpeichern.Click += btnXmlSpeichern_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(166, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(866, 556);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(dgvHMitarbeiter);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnXmlSpeichern);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnHinzufuegen);
            tabPage1.Controls.Add(txtVName);
            tabPage1.Controls.Add(txtNName);
            tabPage1.Controls.Add(txtTNummer);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(858, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "XML Datei Hinzufuegen";
            // 
            // dgvHMitarbeiter
            // 
            dgvHMitarbeiter.AllowUserToAddRows = false;
            dgvHMitarbeiter.AllowUserToDeleteRows = false;
            dgvHMitarbeiter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHMitarbeiter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHMitarbeiter.Columns.AddRange(new DataGridViewColumn[] { hVorname, hNachname, hTelefonnummer });
            dgvHMitarbeiter.Location = new Point(47, 220);
            dgvHMitarbeiter.Name = "dgvHMitarbeiter";
            dgvHMitarbeiter.ReadOnly = true;
            dgvHMitarbeiter.RowHeadersWidth = 51;
            dgvHMitarbeiter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHMitarbeiter.Size = new Size(774, 252);
            dgvHMitarbeiter.TabIndex = 13;
            // 
            // hVorname
            // 
            hVorname.HeaderText = "Vorname";
            hVorname.MinimumWidth = 6;
            hVorname.Name = "hVorname";
            hVorname.ReadOnly = true;
            // 
            // hNachname
            // 
            hNachname.HeaderText = "Nachname";
            hNachname.MinimumWidth = 6;
            hNachname.Name = "hNachname";
            hNachname.ReadOnly = true;
            // 
            // hTelefonnummer
            // 
            hTelefonnummer.HeaderText = "Telefonnummer";
            hTelefonnummer.MinimumWidth = 6;
            hTelefonnummer.Name = "hTelefonnummer";
            hTelefonnummer.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 127);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 12;
            label8.Text = "Telefonnummer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 91);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 11;
            label7.Text = "Nachname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 60);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 10;
            label6.Text = "Vorname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 24);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Mitarbeiter";
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Location = new Point(210, 160);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(173, 29);
            btnHinzufuegen.TabIndex = 8;
            btnHinzufuegen.Text = "Hinzufuegen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // txtVName
            // 
            txtVName.Location = new Point(210, 60);
            txtVName.Name = "txtVName";
            txtVName.Size = new Size(173, 27);
            txtVName.TabIndex = 4;
            // 
            // txtNName
            // 
            txtNName.Location = new Point(210, 93);
            txtNName.Name = "txtNName";
            txtNName.Size = new Size(173, 27);
            txtNName.TabIndex = 5;
            // 
            // txtTNummer
            // 
            txtTNummer.Location = new Point(210, 127);
            txtTNummer.Name = "txtTNummer";
            txtTNummer.Size = new Size(173, 27);
            txtTNummer.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(btnDLesen);
            tabPage2.Controls.Add(dgvMitarbeiter);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(858, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "XML Datei Lesen";
            // 
            // btnDLesen
            // 
            btnDLesen.Location = new Point(77, 42);
            btnDLesen.Name = "btnDLesen";
            btnDLesen.Size = new Size(128, 29);
            btnDLesen.TabIndex = 1;
            btnDLesen.Text = "Datei Einlesen";
            btnDLesen.UseVisualStyleBackColor = true;
            btnDLesen.Click += btnDLesen_Click;
            // 
            // dgvMitarbeiter
            // 
            dgvMitarbeiter.AllowUserToAddRows = false;
            dgvMitarbeiter.AllowUserToDeleteRows = false;
            dgvMitarbeiter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMitarbeiter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMitarbeiter.Columns.AddRange(new DataGridViewColumn[] { VName, NName, TNummer });
            dgvMitarbeiter.Location = new Point(77, 77);
            dgvMitarbeiter.Name = "dgvMitarbeiter";
            dgvMitarbeiter.ReadOnly = true;
            dgvMitarbeiter.RowHeadersWidth = 51;
            dgvMitarbeiter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMitarbeiter.Size = new Size(707, 396);
            dgvMitarbeiter.TabIndex = 0;
            // 
            // VName
            // 
            VName.HeaderText = "Vorname";
            VName.MinimumWidth = 6;
            VName.Name = "VName";
            VName.ReadOnly = true;
            // 
            // NName
            // 
            NName.HeaderText = "Nachname";
            NName.MinimumWidth = 6;
            NName.Name = "NName";
            NName.ReadOnly = true;
            // 
            // TNummer
            // 
            TNummer.HeaderText = "Telefonnummer";
            TNummer.MinimumWidth = 6;
            TNummer.Name = "TNummer";
            TNummer.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 162);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 208);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 119);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1189, 773);
            Controls.Add(tabControl1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHMitarbeiter).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMitarbeiter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnXmlSpeichern;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnHinzufuegen;
        private TextBox txtVName;
        private TextBox txtNName;
        private TextBox txtTNummer;
        private TabPage tabPage2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private DataGridView dgvMitarbeiter;
        private DataGridViewTextBoxColumn VName;
        private DataGridViewTextBoxColumn NName;
        private DataGridViewTextBoxColumn TNummer;
        private Button btnDLesen;
        private DataGridView dgvHMitarbeiter;
        private DataGridViewTextBoxColumn hVorname;
        private DataGridViewTextBoxColumn hNachname;
        private DataGridViewTextBoxColumn hTelefonnummer;
    }
}
