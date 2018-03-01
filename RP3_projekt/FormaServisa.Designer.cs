namespace RP3_projekt
{
    partial class FormaServisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServisa));
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDataSet = new RP3_projekt.BazaPodatakaDataSet();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozilaTableAdapter = new RP3_projekt.BazaPodatakaDataSetTableAdapters.VozilaTableAdapter();
            this.tableAdapterManager = new RP3_projekt.BazaPodatakaDataSetTableAdapters.TableAdapterManager();
            this.kolekcijaSlika = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.servisTableAdapter = new RP3_projekt.BazaPodatakaDataSetTableAdapters.ServisTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "Servis";
            this.servisBindingSource.DataSource = this.bazaPodatakaDataSet;
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
            // kolekcijaSlika
            // 
            this.kolekcijaSlika.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kolekcijaSlika.ImageStream")));
            this.kolekcijaSlika.TransparentColor = System.Drawing.Color.Transparent;
            this.kolekcijaSlika.Images.SetKeyName(0, "deleteIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(1, "newIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(2, "refreshIcon.ico");
            this.kolekcijaSlika.Images.SetKeyName(3, "saveIcon.png");
            this.kolekcijaSlika.Images.SetKeyName(4, "searchIcon.png");
            // 
            // button2
            // 
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.kolekcijaSlika;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Novi nalog";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(527, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(130, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(853, 310);
            this.dataGridView2.TabIndex = 16;
            // 
            // FormaServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(984, 311);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 350);
            this.Name = "FormaServisa";
            this.Text = "AutoServis d.o.o. - Servisi";
            this.Load += new System.EventHandler(this.FormaServisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BazaPodatakaDataSet bazaPodatakaDataSet;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private BazaPodatakaDataSetTableAdapters.VozilaTableAdapter vozilaTableAdapter;
        private BazaPodatakaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ImageList kolekcijaSlika;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private BazaPodatakaDataSetTableAdapters.ServisTableAdapter servisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}