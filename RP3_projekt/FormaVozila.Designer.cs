namespace RP3_projekt
{
    partial class FormaVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaVozila));
            this.button1 = new System.Windows.Forms.Button();
            this.kolekcijaSlika = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.vozilaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDataSet = new RP3_projekt.BazaPodatakaDataSet();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozilaTableAdapter = new RP3_projekt.BazaPodatakaDataSetTableAdapters.VozilaTableAdapter();
            this.tableAdapterManager = new RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager();
            this.vozilaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ime_vlasnikaLabel = new System.Windows.Forms.Label();
            prezime_vlasnikaLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            registracijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingNavigator)).BeginInit();
            this.vozilaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ime_vlasnikaLabel
            // 
            ime_vlasnikaLabel.AutoSize = true;
            ime_vlasnikaLabel.Location = new System.Drawing.Point(22, 19);
            ime_vlasnikaLabel.Name = "ime_vlasnikaLabel";
            ime_vlasnikaLabel.Size = new System.Drawing.Size(69, 13);
            ime_vlasnikaLabel.TabIndex = 15;
            ime_vlasnikaLabel.Text = "Ime vlasnika:";
            // 
            // prezime_vlasnikaLabel
            // 
            prezime_vlasnikaLabel.AutoSize = true;
            prezime_vlasnikaLabel.Location = new System.Drawing.Point(22, 45);
            prezime_vlasnikaLabel.Name = "prezime_vlasnikaLabel";
            prezime_vlasnikaLabel.Size = new System.Drawing.Size(89, 13);
            prezime_vlasnikaLabel.TabIndex = 17;
            prezime_vlasnikaLabel.Text = "Prezime vlasnika:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.AutoSize = true;
            kontaktLabel.Location = new System.Drawing.Point(22, 71);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(50, 13);
            kontaktLabel.TabIndex = 19;
            kontaktLabel.Text = "Kontakt:";
            // 
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(22, 97);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(41, 13);
            voziloLabel.TabIndex = 21;
            voziloLabel.Text = "Vozilo:";
            // 
            // registracijaLabel
            // 
            registracijaLabel.AutoSize = true;
            registracijaLabel.Location = new System.Drawing.Point(22, 123);
            registracijaLabel.Name = "registracijaLabel";
            registracijaLabel.Size = new System.Drawing.Size(64, 13);
            registracijaLabel.TabIndex = 23;
            registracijaLabel.Text = "Registracija:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.kolekcijaSlika;
            this.button1.Location = new System.Drawing.Point(26, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Spremi";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolekcijaSlika
            // 
            this.kolekcijaSlika.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kolekcijaSlika.ImageStream")));
            this.kolekcijaSlika.TransparentColor = System.Drawing.Color.Transparent;
            this.kolekcijaSlika.Images.SetKeyName(0, "deleteIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(1, "newIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(2, "refreshIcon.ico");
            this.kolekcijaSlika.Images.SetKeyName(3, "saveIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(4, "searchIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(5, "receiptIcon.png");
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.kolekcijaSlika;
            this.button2.Location = new System.Drawing.Point(132, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Pretraži";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vozilaBindingSource1
            // 
            this.vozilaBindingSource1.DataMember = "Vozila";
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
            // vozilaBindingNavigator
            // 
            this.vozilaBindingNavigator.AddNewItem = null;
            this.vozilaBindingNavigator.BindingSource = this.vozilaBindingSource;
            this.vozilaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vozilaBindingNavigator.DeleteItem = null;
            this.vozilaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vozilaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vozilaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vozilaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vozilaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vozilaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vozilaBindingNavigator.Name = "vozilaBindingNavigator";
            this.vozilaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vozilaBindingNavigator.Size = new System.Drawing.Size(1134, 25);
            this.vozilaBindingNavigator.TabIndex = 18;
            this.vozilaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.vozilaDataGridView.EnableHeadersVisualStyles = false;
            this.vozilaDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.vozilaDataGridView.Location = new System.Drawing.Point(312, 0);
            this.vozilaDataGridView.Name = "vozilaDataGridView";
            this.vozilaDataGridView.Size = new System.Drawing.Size(671, 341);
            this.vozilaDataGridView.TabIndex = 15;
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
            this.ime_vlasnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Ime vlasnika", true));
            this.ime_vlasnikaTextBox.Location = new System.Drawing.Point(133, 12);
            this.ime_vlasnikaTextBox.Name = "ime_vlasnikaTextBox";
            this.ime_vlasnikaTextBox.Size = new System.Drawing.Size(121, 21);
            this.ime_vlasnikaTextBox.TabIndex = 19;
            this.ime_vlasnikaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ime_vlasnikaTextBox_KeyDown);
            // 
            // prezime_vlasnikaTextBox
            // 
            this.prezime_vlasnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Prezime vlasnika", true));
            this.prezime_vlasnikaTextBox.Location = new System.Drawing.Point(133, 38);
            this.prezime_vlasnikaTextBox.Name = "prezime_vlasnikaTextBox";
            this.prezime_vlasnikaTextBox.Size = new System.Drawing.Size(121, 21);
            this.prezime_vlasnikaTextBox.TabIndex = 21;
            this.prezime_vlasnikaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prezime_vlasnikaTextBox_KeyDown);
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(133, 64);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(121, 21);
            this.kontaktTextBox.TabIndex = 23;
            this.kontaktTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kontaktTextBox_KeyDown);
            // 
            // voziloTextBox
            // 
            this.voziloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Vozilo", true));
            this.voziloTextBox.Location = new System.Drawing.Point(133, 90);
            this.voziloTextBox.Name = "voziloTextBox";
            this.voziloTextBox.Size = new System.Drawing.Size(121, 21);
            this.voziloTextBox.TabIndex = 25;
            this.voziloTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voziloTextBox_KeyDown);
            // 
            // registracijaTextBox
            // 
            this.registracijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Registracija", true));
            this.registracijaTextBox.Location = new System.Drawing.Point(133, 116);
            this.registracijaTextBox.Name = "registracijaTextBox";
            this.registracijaTextBox.Size = new System.Drawing.Size(121, 21);
            this.registracijaTextBox.TabIndex = 27;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.kolekcijaSlika;
            this.button3.Location = new System.Drawing.Point(132, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 28;
            this.button3.Text = "Osvježi";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Polja označena sa * su obavezna";
            // 
            // button4
            // 
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.kolekcijaSlika;
            this.button4.Location = new System.Drawing.Point(26, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 34;
            this.button4.Text = "Izbriši";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ImageIndex = 5;
            this.button5.ImageList = this.kolekcijaSlika;
            this.button5.Location = new System.Drawing.Point(26, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 35;
            this.button5.Text = "Ispiši račun";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(984, 341);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 380);
            this.Name = "FormaVozila";
            this.Text = "AutoServis d.o.o. - Vozila";
            this.Load += new System.EventHandler(this.FormaVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingNavigator)).EndInit();
            this.vozilaBindingNavigator.ResumeLayout(false);
            this.vozilaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BazaPodatakaDataSet bazaPodatakaDataSet;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private BazaPodatakaDataSetTableAdapters.VozilaTableAdapter vozilaTableAdapter;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vozilaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        //private BazaPodatakaDataSet1 bazaPodatakaDataSet1;
        private System.Windows.Forms.BindingSource vozilaBindingSource1;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList kolekcijaSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        // private BazaPodatakaDataSet1TableAdapters.VozilaTableAdapter vozilaTableAdapter1;
        //private BazaPodatakaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}