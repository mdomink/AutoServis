namespace RP3_projekt
{
    partial class NalogVozilo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ime_vlasnikaLabel;
            System.Windows.Forms.Label prezime_vlasnikaLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label voziloLabel;
            System.Windows.Forms.Label registracijaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NalogVozilo));
            this.bazaPodatakaDataSet = new RP3_projekt.BazaPodatakaDataSet();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozilaTableAdapter = new RP3_projekt.BazaPodatakaDataSetTableAdapters.VozilaTableAdapter();
            this.tableAdapterManager = new RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager();
            this.vozilaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_vlasnikaTextBox = new System.Windows.Forms.TextBox();
            this.prezime_vlasnikaTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.voziloTextBox = new System.Windows.Forms.TextBox();
            this.registracijaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kolekcijaSlika = new System.Windows.Forms.ImageList(this.components);
            ime_vlasnikaLabel = new System.Windows.Forms.Label();
            prezime_vlasnikaLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            registracijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ime_vlasnikaLabel
            // 
            ime_vlasnikaLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            ime_vlasnikaLabel.AutoSize = true;
            ime_vlasnikaLabel.Location = new System.Drawing.Point(21, 311);
            ime_vlasnikaLabel.Name = "ime_vlasnikaLabel";
            ime_vlasnikaLabel.Size = new System.Drawing.Size(69, 13);
            ime_vlasnikaLabel.TabIndex = 1;
            ime_vlasnikaLabel.Text = "Ime vlasnika:";
            // 
            // prezime_vlasnikaLabel
            // 
            prezime_vlasnikaLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            prezime_vlasnikaLabel.AutoSize = true;
            prezime_vlasnikaLabel.Location = new System.Drawing.Point(254, 311);
            prezime_vlasnikaLabel.Name = "prezime_vlasnikaLabel";
            prezime_vlasnikaLabel.Size = new System.Drawing.Size(89, 13);
            prezime_vlasnikaLabel.TabIndex = 3;
            prezime_vlasnikaLabel.Text = "Prezime vlasnika:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            kontaktLabel.AutoSize = true;
            kontaktLabel.Location = new System.Drawing.Point(502, 311);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(50, 13);
            kontaktLabel.TabIndex = 5;
            kontaktLabel.Text = "Kontakt:";
            // 
            // voziloLabel
            // 
            voziloLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(21, 363);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(41, 13);
            voziloLabel.TabIndex = 7;
            voziloLabel.Text = "Vozilo:";
            // 
            // registracijaLabel
            // 
            registracijaLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            registracijaLabel.AutoSize = true;
            registracijaLabel.Location = new System.Drawing.Point(254, 363);
            registracijaLabel.Name = "registracijaLabel";
            registracijaLabel.Size = new System.Drawing.Size(64, 13);
            registracijaLabel.TabIndex = 9;
            registracijaLabel.Text = "Registracija:";
            // 
            // bazaPodatakaDataSet
            // 
            this.bazaPodatakaDataSet.DataSetName = "BazaPodatakaDataSet";
            this.bazaPodatakaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataMember = "Vozila";
            this.vozilaBindingSource.DataSource = this.bazaPodatakaDataSet;
            // 
            // vozilaTableAdapter
            // 
            this.vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DijeloviTableAdapter = null;
            this.tableAdapterManager.PovijestTableAdapter = null;
            this.tableAdapterManager.ServisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VozilaTableAdapter = this.vozilaTableAdapter;
            this.tableAdapterManager.ZaposleniciTableAdapter = null;
            // 
            // vozilaDataGridView
            // 
            this.vozilaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vozilaDataGridView.AutoGenerateColumns = false;
            this.vozilaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.vozilaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozilaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vozilaDataGridView.DataSource = this.vozilaBindingSource;
            this.vozilaDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.vozilaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vozilaDataGridView.Name = "vozilaDataGridView";
            this.vozilaDataGridView.Size = new System.Drawing.Size(685, 251);
            this.vozilaDataGridView.TabIndex = 1;
            this.vozilaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vozilaDataGridView_CellClick);
            this.vozilaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vozilaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime vlasnika";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime vlasnika";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime vlasnika";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime vlasnika";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kontakt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kontakt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vozilo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vozilo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Registracija";
            this.dataGridViewTextBoxColumn6.HeaderText = "Registracija";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ime_vlasnikaTextBox
            // 
            this.ime_vlasnikaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ime_vlasnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Ime vlasnika", true));
            this.ime_vlasnikaTextBox.Location = new System.Drawing.Point(96, 308);
            this.ime_vlasnikaTextBox.Name = "ime_vlasnikaTextBox";
            this.ime_vlasnikaTextBox.Size = new System.Drawing.Size(116, 21);
            this.ime_vlasnikaTextBox.TabIndex = 2;
            // 
            // prezime_vlasnikaTextBox
            // 
            this.prezime_vlasnikaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prezime_vlasnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Prezime vlasnika", true));
            this.prezime_vlasnikaTextBox.Location = new System.Drawing.Point(349, 308);
            this.prezime_vlasnikaTextBox.Name = "prezime_vlasnikaTextBox";
            this.prezime_vlasnikaTextBox.Size = new System.Drawing.Size(116, 21);
            this.prezime_vlasnikaTextBox.TabIndex = 4;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(558, 308);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(116, 21);
            this.kontaktTextBox.TabIndex = 6;
            // 
            // voziloTextBox
            // 
            this.voziloTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.voziloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Vozilo", true));
            this.voziloTextBox.Location = new System.Drawing.Point(96, 360);
            this.voziloTextBox.Name = "voziloTextBox";
            this.voziloTextBox.Size = new System.Drawing.Size(116, 21);
            this.voziloTextBox.TabIndex = 8;
            // 
            // registracijaTextBox
            // 
            this.registracijaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registracijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Registracija", true));
            this.registracijaTextBox.Location = new System.Drawing.Point(349, 360);
            this.registracijaTextBox.Name = "registracijaTextBox";
            this.registracijaTextBox.Size = new System.Drawing.Size(116, 21);
            this.registracijaTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.kolekcijaSlika;
            this.button1.Location = new System.Drawing.Point(574, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dalje";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolekcijaSlika
            // 
            this.kolekcijaSlika.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kolekcijaSlika.ImageStream")));
            this.kolekcijaSlika.TransparentColor = System.Drawing.Color.Transparent;
            this.kolekcijaSlika.Images.SetKeyName(0, "backIcon.ico");
            this.kolekcijaSlika.Images.SetKeyName(1, "deleteIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(2, "newIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(3, "nextIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(4, "refreshIcon.ico");
            this.kolekcijaSlika.Images.SetKeyName(5, "saveIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(6, "searchIcon.png");
            // 
            // NalogVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(709, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(ime_vlasnikaLabel);
            this.Controls.Add(this.ime_vlasnikaTextBox);
            this.Controls.Add(prezime_vlasnikaLabel);
            this.Controls.Add(this.prezime_vlasnikaTextBox);
            this.Controls.Add(kontaktLabel);
            this.Controls.Add(this.kontaktTextBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloTextBox);
            this.Controls.Add(registracijaLabel);
            this.Controls.Add(this.registracijaTextBox);
            this.Controls.Add(this.vozilaDataGridView);
            this.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(725, 450);
            this.Name = "NalogVozilo";
            this.Text = "AutoServis d.o.o. - Nalog za vozilo";
            this.Load += new System.EventHandler(this.NalogVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaPodatakaDataSet bazaPodatakaDataSet;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private BazaPodatakaDataSetTableAdapters.VozilaTableAdapter vozilaTableAdapter;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vozilaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ime_vlasnikaTextBox;
        private System.Windows.Forms.TextBox prezime_vlasnikaTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox voziloTextBox;
        private System.Windows.Forms.TextBox registracijaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList kolekcijaSlika;
    }
}