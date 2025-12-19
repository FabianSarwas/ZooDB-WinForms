namespace ZooDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_AktualisierenKontinent = new System.Windows.Forms.Button();
            this.btn_SpeichernKon = new System.Windows.Forms.Button();
            this.lb_Kontinent = new System.Windows.Forms.ListBox();
            this.tb_KonBez = new System.Windows.Forms.TextBox();
            this.tb_KonNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LöschenKon = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_AktualisierenGehege = new System.Windows.Forms.Button();
            this.lb_Gehege = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Speichern_Gehege = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_GehegeKontinent = new System.Windows.Forms.ComboBox();
            this.tb_Gehege = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_AktualisierenTiere = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_XmlSchreiben = new System.Windows.Forms.Button();
            this.lb_TierImp = new System.Windows.Forms.ListBox();
            this.tb_TierID = new System.Windows.Forms.TextBox();
            this.TierID = new System.Windows.Forms.Label();
            this.cb_TierArt = new System.Windows.Forms.ComboBox();
            this.btn_LöschenTiere = new System.Windows.Forms.Button();
            this.btn_SpeichernTiere = new System.Windows.Forms.Button();
            this.lb_Tiere = new System.Windows.Forms.ListBox();
            this.tb_TierGeb = new System.Windows.Forms.TextBox();
            this.tb_TierGewicht = new System.Windows.Forms.TextBox();
            this.tb_TierName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Gehege = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_AktualisierenTierart = new System.Windows.Forms.Button();
            this.tb_TierArtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_LöschenTierart = new System.Windows.Forms.Button();
            this.btn_SpeichernTierart = new System.Windows.Forms.Button();
            this.lb_Tierart = new System.Windows.Forms.ListBox();
            this.tb_Art = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_LöschenPfleger = new System.Windows.Forms.Button();
            this.btn_SpeichernPfleger = new System.Windows.Forms.Button();
            this.lb_Pfleger = new System.Windows.Forms.ListBox();
            this.tb_Pfleger = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_LöschenFutter = new System.Windows.Forms.Button();
            this.btn_SpeichernFutter = new System.Windows.Forms.Button();
            this.lb_Futter = new System.Windows.Forms.ListBox();
            this.tb_Futter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_Einheit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1320, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1312, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übersicht";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1309, 617);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_AktualisierenKontinent);
            this.tabPage2.Controls.Add(this.btn_SpeichernKon);
            this.tabPage2.Controls.Add(this.lb_Kontinent);
            this.tabPage2.Controls.Add(this.tb_KonBez);
            this.tabPage2.Controls.Add(this.tb_KonNr);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_LöschenKon);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1312, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kontinent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_AktualisierenKontinent
            // 
            this.btn_AktualisierenKontinent.Location = new System.Drawing.Point(291, 203);
            this.btn_AktualisierenKontinent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AktualisierenKontinent.Name = "btn_AktualisierenKontinent";
            this.btn_AktualisierenKontinent.Size = new System.Drawing.Size(244, 28);
            this.btn_AktualisierenKontinent.TabIndex = 8;
            this.btn_AktualisierenKontinent.Text = "Update";
            this.btn_AktualisierenKontinent.UseVisualStyleBackColor = true;
            this.btn_AktualisierenKontinent.Click += new System.EventHandler(this.btn_AktualisierenKontinent_Click);
            // 
            // btn_SpeichernKon
            // 
            this.btn_SpeichernKon.Location = new System.Drawing.Point(13, 89);
            this.btn_SpeichernKon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SpeichernKon.Name = "btn_SpeichernKon";
            this.btn_SpeichernKon.Size = new System.Drawing.Size(100, 28);
            this.btn_SpeichernKon.TabIndex = 7;
            this.btn_SpeichernKon.Text = "Speichern";
            this.btn_SpeichernKon.UseVisualStyleBackColor = true;
            this.btn_SpeichernKon.Click += new System.EventHandler(this.btn_SpeichernKon_Click_1);
            // 
            // lb_Kontinent
            // 
            this.lb_Kontinent.FormattingEnabled = true;
            this.lb_Kontinent.ItemHeight = 16;
            this.lb_Kontinent.Location = new System.Drawing.Point(291, 14);
            this.lb_Kontinent.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Kontinent.Name = "lb_Kontinent";
            this.lb_Kontinent.Size = new System.Drawing.Size(243, 180);
            this.lb_Kontinent.TabIndex = 6;
            // 
            // tb_KonBez
            // 
            this.tb_KonBez.Location = new System.Drawing.Point(76, 57);
            this.tb_KonBez.Margin = new System.Windows.Forms.Padding(4);
            this.tb_KonBez.Name = "tb_KonBez";
            this.tb_KonBez.Size = new System.Drawing.Size(144, 22);
            this.tb_KonBez.TabIndex = 5;
            // 
            // tb_KonNr
            // 
            this.tb_KonNr.Location = new System.Drawing.Point(76, 14);
            this.tb_KonNr.Margin = new System.Windows.Forms.Padding(4);
            this.tb_KonNr.Name = "tb_KonNr";
            this.tb_KonNr.ReadOnly = true;
            this.tb_KonNr.Size = new System.Drawing.Size(144, 22);
            this.tb_KonNr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "KonBez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "KonNr";
            // 
            // btn_LöschenKon
            // 
            this.btn_LöschenKon.Location = new System.Drawing.Point(121, 89);
            this.btn_LöschenKon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LöschenKon.Name = "btn_LöschenKon";
            this.btn_LöschenKon.Size = new System.Drawing.Size(100, 28);
            this.btn_LöschenKon.TabIndex = 1;
            this.btn_LöschenKon.Text = "Löschen";
            this.btn_LöschenKon.UseVisualStyleBackColor = true;
            this.btn_LöschenKon.Click += new System.EventHandler(this.btn_LöschenKon_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_AktualisierenGehege);
            this.tabPage3.Controls.Add(this.lb_Gehege);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btn_Speichern_Gehege);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cb_GehegeKontinent);
            this.tabPage3.Controls.Add(this.tb_Gehege);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1312, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gehege";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_AktualisierenGehege
            // 
            this.btn_AktualisierenGehege.Location = new System.Drawing.Point(400, 226);
            this.btn_AktualisierenGehege.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AktualisierenGehege.Name = "btn_AktualisierenGehege";
            this.btn_AktualisierenGehege.Size = new System.Drawing.Size(244, 28);
            this.btn_AktualisierenGehege.TabIndex = 10;
            this.btn_AktualisierenGehege.Text = "Update";
            this.btn_AktualisierenGehege.UseVisualStyleBackColor = true;
            // 
            // lb_Gehege
            // 
            this.lb_Gehege.FormattingEnabled = true;
            this.lb_Gehege.ItemHeight = 16;
            this.lb_Gehege.Location = new System.Drawing.Point(400, 38);
            this.lb_Gehege.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Gehege.Name = "lb_Gehege";
            this.lb_Gehege.Size = new System.Drawing.Size(243, 180);
            this.lb_Gehege.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Speichern_Gehege
            // 
            this.btn_Speichern_Gehege.Location = new System.Drawing.Point(133, 113);
            this.btn_Speichern_Gehege.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Speichern_Gehege.Name = "btn_Speichern_Gehege";
            this.btn_Speichern_Gehege.Size = new System.Drawing.Size(100, 28);
            this.btn_Speichern_Gehege.TabIndex = 7;
            this.btn_Speichern_Gehege.Text = "Speichern";
            this.btn_Speichern_Gehege.UseVisualStyleBackColor = true;
            this.btn_Speichern_Gehege.Click += new System.EventHandler(this.btn_Speichern_Gehege_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kontinent-Bezeichnung";
            // 
            // cb_GehegeKontinent
            // 
            this.cb_GehegeKontinent.FormattingEnabled = true;
            this.cb_GehegeKontinent.Location = new System.Drawing.Point(179, 80);
            this.cb_GehegeKontinent.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GehegeKontinent.Name = "cb_GehegeKontinent";
            this.cb_GehegeKontinent.Size = new System.Drawing.Size(160, 24);
            this.cb_GehegeKontinent.TabIndex = 2;
            // 
            // tb_Gehege
            // 
            this.tb_Gehege.Location = new System.Drawing.Point(179, 31);
            this.tb_Gehege.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Gehege.Name = "tb_Gehege";
            this.tb_Gehege.Size = new System.Drawing.Size(160, 22);
            this.tb_Gehege.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gehege-Bezeichnung";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_AktualisierenTiere);
            this.tabPage4.Controls.Add(this.btn_Import);
            this.tabPage4.Controls.Add(this.btn_XmlSchreiben);
            this.tabPage4.Controls.Add(this.lb_TierImp);
            this.tabPage4.Controls.Add(this.tb_TierID);
            this.tabPage4.Controls.Add(this.TierID);
            this.tabPage4.Controls.Add(this.cb_TierArt);
            this.tabPage4.Controls.Add(this.btn_LöschenTiere);
            this.tabPage4.Controls.Add(this.btn_SpeichernTiere);
            this.tabPage4.Controls.Add(this.lb_Tiere);
            this.tabPage4.Controls.Add(this.tb_TierGeb);
            this.tabPage4.Controls.Add(this.tb_TierGewicht);
            this.tabPage4.Controls.Add(this.tb_TierName);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.cb_Gehege);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1312, 620);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tiere";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_AktualisierenTiere
            // 
            this.btn_AktualisierenTiere.Location = new System.Drawing.Point(65, 241);
            this.btn_AktualisierenTiere.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AktualisierenTiere.Name = "btn_AktualisierenTiere";
            this.btn_AktualisierenTiere.Size = new System.Drawing.Size(244, 28);
            this.btn_AktualisierenTiere.TabIndex = 19;
            this.btn_AktualisierenTiere.Text = "Update";
            this.btn_AktualisierenTiere.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(1145, 447);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(100, 28);
            this.btn_Import.TabIndex = 18;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_XmlSchreiben
            // 
            this.btn_XmlSchreiben.Location = new System.Drawing.Point(785, 448);
            this.btn_XmlSchreiben.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XmlSchreiben.Name = "btn_XmlSchreiben";
            this.btn_XmlSchreiben.Size = new System.Drawing.Size(100, 28);
            this.btn_XmlSchreiben.TabIndex = 17;
            this.btn_XmlSchreiben.Text = "Export";
            this.btn_XmlSchreiben.UseVisualStyleBackColor = true;
            this.btn_XmlSchreiben.Click += new System.EventHandler(this.btn_XmlSchreiben_Click);
            // 
            // lb_TierImp
            // 
            this.lb_TierImp.FormattingEnabled = true;
            this.lb_TierImp.ItemHeight = 16;
            this.lb_TierImp.Location = new System.Drawing.Point(785, 23);
            this.lb_TierImp.Margin = new System.Windows.Forms.Padding(4);
            this.lb_TierImp.Name = "lb_TierImp";
            this.lb_TierImp.Size = new System.Drawing.Size(461, 404);
            this.lb_TierImp.TabIndex = 16;
            // 
            // tb_TierID
            // 
            this.tb_TierID.Location = new System.Drawing.Point(144, 42);
            this.tb_TierID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TierID.Name = "tb_TierID";
            this.tb_TierID.ReadOnly = true;
            this.tb_TierID.Size = new System.Drawing.Size(132, 22);
            this.tb_TierID.TabIndex = 15;
            // 
            // TierID
            // 
            this.TierID.AutoSize = true;
            this.TierID.Location = new System.Drawing.Point(76, 42);
            this.TierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TierID.Name = "TierID";
            this.TierID.Size = new System.Drawing.Size(44, 16);
            this.TierID.TabIndex = 14;
            this.TierID.Text = "TierID";
            // 
            // cb_TierArt
            // 
            this.cb_TierArt.FormattingEnabled = true;
            this.cb_TierArt.Location = new System.Drawing.Point(144, 175);
            this.cb_TierArt.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TierArt.Name = "cb_TierArt";
            this.cb_TierArt.Size = new System.Drawing.Size(160, 24);
            this.cb_TierArt.TabIndex = 13;
            // 
            // btn_LöschenTiere
            // 
            this.btn_LöschenTiere.Location = new System.Drawing.Point(472, 180);
            this.btn_LöschenTiere.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LöschenTiere.Name = "btn_LöschenTiere";
            this.btn_LöschenTiere.Size = new System.Drawing.Size(100, 28);
            this.btn_LöschenTiere.TabIndex = 12;
            this.btn_LöschenTiere.Text = "Löschen";
            this.btn_LöschenTiere.UseVisualStyleBackColor = true;
            this.btn_LöschenTiere.Click += new System.EventHandler(this.btn_LöschenTiere_Click);
            // 
            // btn_SpeichernTiere
            // 
            this.btn_SpeichernTiere.Location = new System.Drawing.Point(348, 180);
            this.btn_SpeichernTiere.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SpeichernTiere.Name = "btn_SpeichernTiere";
            this.btn_SpeichernTiere.Size = new System.Drawing.Size(100, 28);
            this.btn_SpeichernTiere.TabIndex = 11;
            this.btn_SpeichernTiere.Text = "Speichern";
            this.btn_SpeichernTiere.UseVisualStyleBackColor = true;
            this.btn_SpeichernTiere.Click += new System.EventHandler(this.btn_SpeichernTiere_Click);
            // 
            // lb_Tiere
            // 
            this.lb_Tiere.FormattingEnabled = true;
            this.lb_Tiere.ItemHeight = 16;
            this.lb_Tiere.Location = new System.Drawing.Point(348, 23);
            this.lb_Tiere.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Tiere.Name = "lb_Tiere";
            this.lb_Tiere.Size = new System.Drawing.Size(223, 148);
            this.lb_Tiere.TabIndex = 10;
            // 
            // tb_TierGeb
            // 
            this.tb_TierGeb.Location = new System.Drawing.Point(144, 143);
            this.tb_TierGeb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TierGeb.Name = "tb_TierGeb";
            this.tb_TierGeb.Size = new System.Drawing.Size(132, 22);
            this.tb_TierGeb.TabIndex = 8;
            // 
            // tb_TierGewicht
            // 
            this.tb_TierGewicht.Location = new System.Drawing.Point(144, 111);
            this.tb_TierGewicht.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TierGewicht.Name = "tb_TierGewicht";
            this.tb_TierGewicht.Size = new System.Drawing.Size(132, 22);
            this.tb_TierGewicht.TabIndex = 7;
            // 
            // tb_TierName
            // 
            this.tb_TierName.Location = new System.Drawing.Point(144, 75);
            this.tb_TierName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TierName.Name = "tb_TierName";
            this.tb_TierName.Size = new System.Drawing.Size(132, 22);
            this.tb_TierName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gehege";
            // 
            // cb_Gehege
            // 
            this.cb_Gehege.FormattingEnabled = true;
            this.cb_Gehege.Location = new System.Drawing.Point(144, 208);
            this.cb_Gehege.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Gehege.Name = "cb_Gehege";
            this.cb_Gehege.Size = new System.Drawing.Size(160, 24);
            this.cb_Gehege.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tier-Art";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tier-Geburtsdatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tier-Gewicht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tier-Name";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_AktualisierenTierart);
            this.tabPage5.Controls.Add(this.tb_TierArtID);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.btn_LöschenTierart);
            this.tabPage5.Controls.Add(this.btn_SpeichernTierart);
            this.tabPage5.Controls.Add(this.lb_Tierart);
            this.tabPage5.Controls.Add(this.tb_Art);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1312, 620);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tierart";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_AktualisierenTierart
            // 
            this.btn_AktualisierenTierart.Location = new System.Drawing.Point(287, 156);
            this.btn_AktualisierenTierart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AktualisierenTierart.Name = "btn_AktualisierenTierart";
            this.btn_AktualisierenTierart.Size = new System.Drawing.Size(160, 28);
            this.btn_AktualisierenTierart.TabIndex = 11;
            this.btn_AktualisierenTierart.Text = "Update";
            this.btn_AktualisierenTierart.UseVisualStyleBackColor = true;
            // 
            // tb_TierArtID
            // 
            this.tb_TierArtID.Location = new System.Drawing.Point(80, 32);
            this.tb_TierArtID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TierArtID.Name = "tb_TierArtID";
            this.tb_TierArtID.ReadOnly = true;
            this.tb_TierArtID.Size = new System.Drawing.Size(159, 22);
            this.tb_TierArtID.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "TierArtID";
            // 
            // btn_LöschenTierart
            // 
            this.btn_LöschenTierart.Location = new System.Drawing.Point(123, 105);
            this.btn_LöschenTierart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LöschenTierart.Name = "btn_LöschenTierart";
            this.btn_LöschenTierart.Size = new System.Drawing.Size(100, 28);
            this.btn_LöschenTierart.TabIndex = 4;
            this.btn_LöschenTierart.Text = "Löschen";
            this.btn_LöschenTierart.UseVisualStyleBackColor = true;
            this.btn_LöschenTierart.Click += new System.EventHandler(this.btn_LöschenTierart_Click);
            // 
            // btn_SpeichernTierart
            // 
            this.btn_SpeichernTierart.Location = new System.Drawing.Point(15, 105);
            this.btn_SpeichernTierart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SpeichernTierart.Name = "btn_SpeichernTierart";
            this.btn_SpeichernTierart.Size = new System.Drawing.Size(100, 28);
            this.btn_SpeichernTierart.TabIndex = 3;
            this.btn_SpeichernTierart.Text = "Speichern";
            this.btn_SpeichernTierart.UseVisualStyleBackColor = true;
            this.btn_SpeichernTierart.Click += new System.EventHandler(this.btn_SpeichernTierart_Click);
            // 
            // lb_Tierart
            // 
            this.lb_Tierart.FormattingEnabled = true;
            this.lb_Tierart.ItemHeight = 16;
            this.lb_Tierart.Location = new System.Drawing.Point(287, 32);
            this.lb_Tierart.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Tierart.Name = "lb_Tierart";
            this.lb_Tierart.Size = new System.Drawing.Size(159, 116);
            this.lb_Tierart.TabIndex = 2;
            // 
            // tb_Art
            // 
            this.tb_Art.Location = new System.Drawing.Point(80, 63);
            this.tb_Art.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Art.Name = "tb_Art";
            this.tb_Art.Size = new System.Drawing.Size(159, 22);
            this.tb_Art.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tierart";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_LöschenPfleger);
            this.tabPage6.Controls.Add(this.btn_SpeichernPfleger);
            this.tabPage6.Controls.Add(this.lb_Pfleger);
            this.tabPage6.Controls.Add(this.tb_Pfleger);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1312, 620);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Pfleger";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_LöschenPfleger
            // 
            this.btn_LöschenPfleger.Location = new System.Drawing.Point(161, 111);
            this.btn_LöschenPfleger.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LöschenPfleger.Name = "btn_LöschenPfleger";
            this.btn_LöschenPfleger.Size = new System.Drawing.Size(100, 28);
            this.btn_LöschenPfleger.TabIndex = 16;
            this.btn_LöschenPfleger.Text = "Löschen";
            this.btn_LöschenPfleger.UseVisualStyleBackColor = true;
            this.btn_LöschenPfleger.Click += new System.EventHandler(this.btn_LöschenPfleger_Click);
            // 
            // btn_SpeichernPfleger
            // 
            this.btn_SpeichernPfleger.Location = new System.Drawing.Point(53, 111);
            this.btn_SpeichernPfleger.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SpeichernPfleger.Name = "btn_SpeichernPfleger";
            this.btn_SpeichernPfleger.Size = new System.Drawing.Size(100, 28);
            this.btn_SpeichernPfleger.TabIndex = 15;
            this.btn_SpeichernPfleger.Text = "Speichern";
            this.btn_SpeichernPfleger.UseVisualStyleBackColor = true;
            this.btn_SpeichernPfleger.Click += new System.EventHandler(this.btn_SpeichernPfleger_Click);
            // 
            // lb_Pfleger
            // 
            this.lb_Pfleger.FormattingEnabled = true;
            this.lb_Pfleger.ItemHeight = 16;
            this.lb_Pfleger.Location = new System.Drawing.Point(297, 23);
            this.lb_Pfleger.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Pfleger.Name = "lb_Pfleger";
            this.lb_Pfleger.Size = new System.Drawing.Size(159, 116);
            this.lb_Pfleger.TabIndex = 14;
            // 
            // tb_Pfleger
            // 
            this.tb_Pfleger.Location = new System.Drawing.Point(90, 54);
            this.tb_Pfleger.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pfleger.Name = "tb_Pfleger";
            this.tb_Pfleger.Size = new System.Drawing.Size(159, 22);
            this.tb_Pfleger.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Pfleger";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.btn_LöschenFutter);
            this.tabPage7.Controls.Add(this.btn_SpeichernFutter);
            this.tabPage7.Controls.Add(this.lb_Futter);
            this.tabPage7.Controls.Add(this.tb_Futter);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.tb_Einheit);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1312, 620);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Futter";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 169);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Menge";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 163);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 21;
            // 
            // btn_LöschenFutter
            // 
            this.btn_LöschenFutter.Location = new System.Drawing.Point(226, 208);
            this.btn_LöschenFutter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LöschenFutter.Name = "btn_LöschenFutter";
            this.btn_LöschenFutter.Size = new System.Drawing.Size(100, 28);
            this.btn_LöschenFutter.TabIndex = 20;
            this.btn_LöschenFutter.Text = "Löschen";
            this.btn_LöschenFutter.UseVisualStyleBackColor = true;
            // 
            // btn_SpeichernFutter
            // 
            this.btn_SpeichernFutter.Location = new System.Drawing.Point(118, 208);
            this.btn_SpeichernFutter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SpeichernFutter.Name = "btn_SpeichernFutter";
            this.btn_SpeichernFutter.Size = new System.Drawing.Size(100, 28);
            this.btn_SpeichernFutter.TabIndex = 19;
            this.btn_SpeichernFutter.Text = "Speichern";
            this.btn_SpeichernFutter.UseVisualStyleBackColor = true;
            // 
            // lb_Futter
            // 
            this.lb_Futter.FormattingEnabled = true;
            this.lb_Futter.ItemHeight = 16;
            this.lb_Futter.Location = new System.Drawing.Point(373, 51);
            this.lb_Futter.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Futter.Name = "lb_Futter";
            this.lb_Futter.Size = new System.Drawing.Size(159, 116);
            this.lb_Futter.TabIndex = 18;
            // 
            // tb_Futter
            // 
            this.tb_Futter.Location = new System.Drawing.Point(118, 51);
            this.tb_Futter.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Futter.Name = "tb_Futter";
            this.tb_Futter.Size = new System.Drawing.Size(159, 22);
            this.tb_Futter.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Bezeichnung";
            // 
            // tb_Einheit
            // 
            this.tb_Einheit.Location = new System.Drawing.Point(118, 110);
            this.tb_Einheit.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Einheit.Name = "tb_Einheit";
            this.tb_Einheit.Size = new System.Drawing.Size(159, 22);
            this.tb_Einheit.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Einheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 649);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tb_KonBez;
        private System.Windows.Forms.TextBox tb_KonNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LöschenKon;
        private System.Windows.Forms.ListBox lb_Kontinent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_GehegeKontinent;
        private System.Windows.Forms.TextBox tb_Gehege;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_Gehege;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Speichern_Gehege;
        private System.Windows.Forms.Button btn_SpeichernKon;
        private System.Windows.Forms.TextBox tb_TierGeb;
        private System.Windows.Forms.TextBox tb_TierGewicht;
        private System.Windows.Forms.TextBox tb_TierName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Gehege;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_Tiere;
        private System.Windows.Forms.Button btn_LöschenTierart;
        private System.Windows.Forms.Button btn_SpeichernTierart;
        private System.Windows.Forms.ListBox lb_Tierart;
        private System.Windows.Forms.TextBox tb_Art;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_LöschenTiere;
        private System.Windows.Forms.Button btn_SpeichernTiere;
        private System.Windows.Forms.ComboBox cb_TierArt;
        private System.Windows.Forms.TextBox tb_TierArtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_TierID;
        private System.Windows.Forms.Label TierID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lb_TierImp;
        private System.Windows.Forms.Button btn_XmlSchreiben;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_AktualisierenKontinent;
        private System.Windows.Forms.Button btn_AktualisierenGehege;
        private System.Windows.Forms.Button btn_AktualisierenTiere;
        private System.Windows.Forms.Button btn_AktualisierenTierart;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_LöschenPfleger;
        private System.Windows.Forms.Button btn_SpeichernPfleger;
        private System.Windows.Forms.ListBox lb_Pfleger;
        private System.Windows.Forms.TextBox tb_Pfleger;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lb_Futter;
        private System.Windows.Forms.TextBox tb_Futter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_Einheit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_LöschenFutter;
        private System.Windows.Forms.Button btn_SpeichernFutter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}