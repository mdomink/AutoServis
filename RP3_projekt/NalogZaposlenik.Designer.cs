namespace RP3_projekt
{
    partial class NalogZaposlenik
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NalogZaposlenik));
            this.bazaPodatakaDataSet = new RP3_projekt.BazaPodatakaDataSet();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposleniciTableAdapter = new RP3_projekt.BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter();
            this.tableAdapterManager = new RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager();
            this.zaposleniciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kolekcijaSlika = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(18, 176);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(28, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(208, 176);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(48, 13);
            prezimeLabel.TabIndex = 3;
            prezimeLabel.Text = "Prezime:";
            // 
            // bazaPodatakaDataSet
            // 
            this.bazaPodatakaDataSet.DataSetName = "BazaPodatakaDataSet";
            this.bazaPodatakaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.bazaPodatakaDataSet;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DijeloviTableAdapter = null;
            this.tableAdapterManager.PovijestTableAdapter = null;
            this.tableAdapterManager.ServisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VozilaTableAdapter = null;
            this.tableAdapterManager.ZaposleniciTableAdapter = this.zaposleniciTableAdapter;
            // 
            // zaposleniciDataGridView
            // 
            this.zaposleniciDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zaposleniciDataGridView.AutoGenerateColumns = false;
            this.zaposleniciDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.zaposleniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.zaposleniciDataGridView.DataSource = this.zaposleniciBindingSource;
            this.zaposleniciDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.zaposleniciDataGridView.Location = new System.Drawing.Point(12, 12);
            this.zaposleniciDataGridView.Name = "zaposleniciDataGridView";
            this.zaposleniciDataGridView.Size = new System.Drawing.Size(570, 143);
            this.zaposleniciDataGridView.TabIndex = 1;
            this.zaposleniciDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zaposleniciDataGridView_CellClick);
            this.zaposleniciDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zaposleniciDataGridView_CellClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Broj mobitela";
            this.dataGridViewTextBoxColumn5.HeaderText = "Broj mobitela";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(52, 173);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(116, 21);
            this.imeTextBox.TabIndex = 2;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(262, 173);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(116, 21);
            this.prezimeTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.kolekcijaSlika;
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "      Nazad";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.kolekcijaSlika;
            this.button2.Location = new System.Drawing.Point(482, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dalje";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NalogZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.zaposleniciDataGridView);
            this.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(610, 300);
            this.Name = "NalogZaposlenik";
            this.Text = "AutoServis d.o.o. - Nalog za zaposlenika";
            this.Load += new System.EventHandler(this.NalogZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaPodatakaDataSet bazaPodatakaDataSet;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zaposleniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList kolekcijaSlika;
    }
}