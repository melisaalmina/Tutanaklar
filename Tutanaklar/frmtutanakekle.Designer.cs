
namespace Tutanaklar
{
    partial class frmTutanakEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutanakEkle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTutanakno = new DevExpress.XtraEditors.TextEdit();
            this.lblTutanakNo = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblSebep = new DevExpress.XtraEditors.LabelControl();
            this.lblisverenhkdsdrm = new DevExpress.XtraEditors.LabelControl();
            this.txtSebep = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.txtisverenhkdsdrm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutanakno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSebep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisverenhkdsdrm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTutanakno);
            this.groupControl1.Controls.Add(this.lblTutanakNo);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.lblAciklama);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.lblSebep);
            this.groupControl1.Controls.Add(this.lblisverenhkdsdrm);
            this.groupControl1.Controls.Add(this.txtSebep);
            this.groupControl1.Controls.Add(this.lblTarih);
            this.groupControl1.Controls.Add(this.txtisverenhkdsdrm);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(287, 633);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtTutanakno
            // 
            this.txtTutanakno.Location = new System.Drawing.Point(73, 49);
            this.txtTutanakno.Name = "txtTutanakno";
            this.txtTutanakno.Size = new System.Drawing.Size(185, 20);
            this.txtTutanakno.TabIndex = 1;
            // 
            // lblTutanakNo
            // 
            this.lblTutanakNo.Location = new System.Drawing.Point(12, 52);
            this.lblTutanakNo.Name = "lblTutanakNo";
            this.lblTutanakNo.Size = new System.Drawing.Size(55, 13);
            this.lblTutanakNo.TabIndex = 0;
            this.lblTutanakNo.Text = "Tutanak No";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(73, 154);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(185, 235);
            this.txtAciklama.TabIndex = 3;
            this.txtAciklama.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(73, 395);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(185, 44);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(22, 154);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(45, 13);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(73, 75);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(185, 21);
            this.txtTarih.TabIndex = 2;
            // 
            // lblSebep
            // 
            this.lblSebep.Location = new System.Drawing.Point(37, 105);
            this.lblSebep.Name = "lblSebep";
            this.lblSebep.Size = new System.Drawing.Size(30, 13);
            this.lblSebep.TabIndex = 0;
            this.lblSebep.Text = "Sebep";
            // 
            // lblisverenhkdsdrm
            // 
            this.lblisverenhkdsdrm.Location = new System.Drawing.Point(30, 131);
            this.lblisverenhkdsdrm.Name = "lblisverenhkdsdrm";
            this.lblisverenhkdsdrm.Size = new System.Drawing.Size(37, 13);
            this.lblisverenhkdsdrm.TabIndex = 0;
            this.lblisverenhkdsdrm.Text = "Durumu";
            // 
            // txtSebep
            // 
            this.txtSebep.Location = new System.Drawing.Point(73, 102);
            this.txtSebep.Name = "txtSebep";
            this.txtSebep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSebep.Properties.Items.AddRange(new object[] {
            "Ana Firma Revizyonu",
            "İşveren Proje Revizyonu",
            "İşveren Saha Revizyonu",
            "İşçilik Hatası"});
            this.txtSebep.Size = new System.Drawing.Size(185, 20);
            this.txtSebep.TabIndex = 1;
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(39, 78);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(28, 13);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtisverenhkdsdrm
            // 
            this.txtisverenhkdsdrm.Location = new System.Drawing.Point(73, 128);
            this.txtisverenhkdsdrm.Name = "txtisverenhkdsdrm";
            this.txtisverenhkdsdrm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtisverenhkdsdrm.Properties.Items.AddRange(new object[] {
            "Birim Fiyatlı Metraj",
            "İş Bazlı Tek Fiyat",
            "Adam Saat",
            "Bedelsiz"});
            this.txtisverenhkdsdrm.Size = new System.Drawing.Size(185, 20);
            this.txtisverenhkdsdrm.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(287, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 633);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmTutanakEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 633);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTutanakEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutanak Ekle";
            this.Load += new System.EventHandler(this.frmTutanakEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutanakno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSebep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisverenhkdsdrm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private DevExpress.XtraEditors.TextEdit txtTutanakno;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.LabelControl lblTutanakNo;
        private DevExpress.XtraEditors.LabelControl lblSebep;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblisverenhkdsdrm;
        private DevExpress.XtraEditors.ComboBoxEdit txtSebep;
        private DevExpress.XtraEditors.ComboBoxEdit txtisverenhkdsdrm;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}