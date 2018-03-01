namespace RP3_projekt
{
    partial class FormaZaposlenici
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
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_mobitelaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaZaposlenici));
            this.button3 = new System.Windows.Forms.Button();
            this.kolekcijaSlika = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.zaposleniciBindingSource2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.zaposleniciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDataSet2 = new RP3_projekt.BazaPodatakaDataSet();
            this.zaposleniciTableAdapter2 = new RP3_projekt.BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter();
            this.tableAdapterManager2 = new RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager();
            this.zaposleniciDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTextBox2 = new System.Windows.Forms.TextBox();
            this.prezimeTextBox2 = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_mobitelaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            broj_mobitelaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2BindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(20, 15);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(28, 13);
            imeLabel.TabIndex = 10;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(20, 41);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(48, 13);
            prezimeLabel.TabIndex = 12;
            prezimeLabel.Text = "Prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(20, 67);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(42, 13);
            adresaLabel.TabIndex = 14;
            adresaLabel.Text = "Adresa:";
            // 
            // broj_mobitelaLabel
            // 
            broj_mobitelaLabel.AutoSize = true;
            broj_mobitelaLabel.Location = new System.Drawing.Point(20, 93);
            broj_mobitelaLabel.Name = "broj_mobitelaLabel";
            broj_mobitelaLabel.Size = new System.Drawing.Size(74, 13);
            broj_mobitelaLabel.TabIndex = 16;
            broj_mobitelaLabel.Text = "Broj mobitela:";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.kolekcijaSlika;
            this.button3.Location = new System.Drawing.Point(23, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Spremi";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kolekcijaSlika
            // 
            this.kolekcijaSlika.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kolekcijaSlika.ImageStream")));
            this.kolekcijaSlika.TransparentColor = System.Drawing.Color.Transparent;
            this.kolekcijaSlika.Images.SetKeyName(0, "deleteIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(1, "saveIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(2, "refreshIcon.ico");
            this.kolekcijaSlika.Images.SetKeyName(3, "newIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(4, "doneIcon.png");
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.kolekcijaSlika;
            this.button2.Location = new System.Drawing.Point(23, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Izbriši";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zaposleniciBindingSource2BindingNavigator
            // 
            this.zaposleniciBindingSource2BindingNavigator.AddNewItem = null;
            this.zaposleniciBindingSource2BindingNavigator.BindingSource = this.zaposleniciBindingSource2;
            this.zaposleniciBindingSource2BindingNavigator.CountItem = null;
            this.zaposleniciBindingSource2BindingNavigator.DeleteItem = null;
            this.zaposleniciBindingSource2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zaposleniciBindingSource2BindingNavigator.MoveFirstItem = null;
            this.zaposleniciBindingSource2BindingNavigator.MoveLastItem = null;
            this.zaposleniciBindingSource2BindingNavigator.MoveNextItem = null;
            this.zaposleniciBindingSource2BindingNavigator.MovePreviousItem = null;
            this.zaposleniciBindingSource2BindingNavigator.Name = "zaposleniciBindingSource2BindingNavigator";
            this.zaposleniciBindingSource2BindingNavigator.PositionItem = null;
            this.zaposleniciBindingSource2BindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.zaposleniciBindingSource2BindingNavigator.TabIndex = 10;
            this.zaposleniciBindingSource2BindingNavigator.Text = "bindingNavigator1";
            // 
            // zaposleniciBindingSource2
            // 
            this.zaposleniciBindingSource2.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource2.DataSource = this.bazaPodatakaDataSet2;
            // 
            // bazaPodatakaDataSet2
            // 
            this.bazaPodatakaDataSet2.DataSetName = "BazaPodatakaDataSet";
            this.bazaPodatakaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciTableAdapter2
            // 
            this.zaposleniciTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.DijeloviTableAdapter = null;
            this.tableAdapterManager2.PovijestTableAdapter = null;
            this.tableAdapterManager2.ServisTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.VozilaTableAdapter = null;
            this.tableAdapterManager2.ZaposleniciTableAdapter = this.zaposleniciTableAdapter2;
            // 
            // zaposleniciDataGridView1
            // 
            this.zaposleniciDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zaposleniciDataGridView1.AutoGenerateColumns = false;
            this.zaposleniciDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.zaposleniciDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.zaposleniciDataGridView1.DataSource = this.zaposleniciBindingSource2;
            this.zaposleniciDataGridView1.EnableHeadersVisualStyles = false;
            this.zaposleniciDataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.zaposleniciDataGridView1.Location = new System.Drawing.Point(263, 0);
            this.zaposleniciDataGridView1.Name = "zaposleniciDataGridView1";
            this.zaposleniciDataGridView1.Size = new System.Drawing.Size(571, 311);
            this.zaposleniciDataGridView1.TabIndex = 10;
            this.zaposleniciDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zaposleniciDataGridView1_CellClick);
            this.zaposleniciDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zaposleniciDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Broj mobitela";
            this.dataGridViewTextBoxColumn8.HeaderText = "Broj mobitela";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // imeTextBox2
            // 
            this.imeTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource2, "Ime", true));
            this.imeTextBox2.Location = new System.Drawing.Point(96, 12);
            this.imeTextBox2.Name = "imeTextBox2";
            this.imeTextBox2.Size = new System.Drawing.Size(100, 21);
            this.imeTextBox2.TabIndex = 11;
            this.imeTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imeTextBox2_KeyDown);
            // 
            // prezimeTextBox2
            // 
            this.prezimeTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource2, "Prezime", true));
            this.prezimeTextBox2.Location = new System.Drawing.Point(96, 38);
            this.prezimeTextBox2.Name = "prezimeTextBox2";
            this.prezimeTextBox2.Size = new System.Drawing.Size(100, 21);
            this.prezimeTextBox2.TabIndex = 13;
            this.prezimeTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prezimeTextBox2_KeyDown);
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource2, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(96, 64);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 21);
            this.adresaTextBox.TabIndex = 15;
            this.adresaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adresaTextBox_KeyDown);
            // 
            // broj_mobitelaTextBox
            // 
            this.broj_mobitelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource2, "Broj mobitela", true));
            this.broj_mobitelaTextBox.Location = new System.Drawing.Point(96, 90);
            this.broj_mobitelaTextBox.Name = "broj_mobitelaTextBox";
            this.broj_mobitelaTextBox.Size = new System.Drawing.Size(100, 21);
            this.broj_mobitelaTextBox.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.kolekcijaSlika;
            this.button4.Location = new System.Drawing.Point(129, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "Radni nalozi";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.kolekcijaSlika;
            this.button5.Location = new System.Drawing.Point(129, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 19;
            this.button5.Text = "Osvježi";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Polja označena sa * su obavezna";
            // 
            // button6
            // 
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.kolekcijaSlika;
            this.button6.Location = new System.Drawing.Point(23, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 23;
            this.button6.Text = "Odradi nalog";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormaZaposlenici
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox2);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox2);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(broj_mobitelaLabel);
            this.Controls.Add(this.broj_mobitelaTextBox);
            this.Controls.Add(this.zaposleniciDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 350);
            this.Name = "FormaZaposlenici";
            this.Text = "AutoServis d.o.o. - Zaposlenici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2BindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaPodatakaDataSet bazaPodatakaDataSet;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private BazaPodatakaDataSet bazaPodatakaDataSet1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource1;
        private BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter1;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator zaposleniciBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton zaposleniciBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imeTextBox1;
        private System.Windows.Forms.TextBox prezimeTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView zaposleniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private BazaPodatakaDataSet bazaPodatakaDataSet2;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource2;
        private BazaPodatakaDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter2;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager2;

        private System.Windows.Forms.BindingNavigator zaposleniciBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView zaposleniciDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox imeTextBox2;
        private System.Windows.Forms.TextBox prezimeTextBox2;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_mobitelaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList kolekcijaSlika;
        private System.Windows.Forms.Button button6;
    }
}

