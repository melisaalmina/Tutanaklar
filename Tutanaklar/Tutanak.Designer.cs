
namespace Tutanaklar
{
    partial class Tutanak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutanak));
            this.txtTutanakno = new DevExpress.XtraEditors.TextEdit();
            this.lblTutanakNo = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tutanakDBDataSet = new Tutanaklar.TutanakDBDataSet();
            this.birimFiyatTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimFiyatTblTableAdapter = new Tutanaklar.TutanakDBDataSetTableAdapters.BirimFiyatTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutanakno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutanakDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimFiyatTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTutanakno
            // 
            this.txtTutanakno.Location = new System.Drawing.Point(85, 24);
            this.txtTutanakno.Name = "txtTutanakno";
            this.txtTutanakno.Size = new System.Drawing.Size(185, 20);
            this.txtTutanakno.TabIndex = 5;
            // 
            // lblTutanakNo
            // 
            this.lblTutanakNo.Location = new System.Drawing.Point(24, 27);
            this.lblTutanakNo.Name = "lblTutanakNo";
            this.lblTutanakNo.Size = new System.Drawing.Size(55, 13);
            this.lblTutanakNo.TabIndex = 3;
            this.lblTutanakNo.Text = "Tutanak No";
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarih.Location = new System.Drawing.Point(657, 37);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(185, 21);
            this.txtTarih.TabIndex = 6;
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.Location = new System.Drawing.Point(623, 40);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(28, 13);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(24, 488);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 200);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.Text = "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAciklama.Location = new System.Drawing.Point(24, 459);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(45, 13);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(722, 694);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 37);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 492);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 196);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // tutanakDBDataSet
            // 
            this.tutanakDBDataSet.DataSetName = "TutanakDBDataSet";
            this.tutanakDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birimFiyatTblBindingSource
            // 
            this.birimFiyatTblBindingSource.DataMember = "BirimFiyatTbl";
            this.birimFiyatTblBindingSource.DataSource = this.tutanakDBDataSet;
            // 
            // birimFiyatTblTableAdapter
            // 
            this.birimFiyatTblTableAdapter.ClearBeforeFill = true;
            // 
            // Tutanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 743);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtTutanakno);
            this.Controls.Add(this.lblTutanakNo);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblTarih);
            this.Name = "Tutanak";
            this.Text = "Tutanak";
            this.Load += new System.EventHandler(this.Tutanak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutanakno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutanakDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimFiyatTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTutanakno;
        private DevExpress.XtraEditors.LabelControl lblTutanakNo;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TutanakDBDataSet tutanakDBDataSet;
        private System.Windows.Forms.BindingSource birimFiyatTblBindingSource;
        private TutanakDBDataSetTableAdapters.BirimFiyatTblTableAdapter birimFiyatTblTableAdapter;
    }
}