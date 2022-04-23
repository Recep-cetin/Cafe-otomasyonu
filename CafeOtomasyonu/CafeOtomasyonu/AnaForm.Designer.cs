namespace CafeOtomasyonu
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTanimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.listelerToolStripMenuItem,
            this.satışlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTanımToolStripMenuItem,
            this.ürünTanimToolStripMenuItem,
            this.firmaTanımToolStripMenuItem,
            this.personelTanımToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // müşteriTanımToolStripMenuItem
            // 
            this.müşteriTanımToolStripMenuItem.Name = "müşteriTanımToolStripMenuItem";
            this.müşteriTanımToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.müşteriTanımToolStripMenuItem.Text = "Müşteri Tanım";
            this.müşteriTanımToolStripMenuItem.Click += new System.EventHandler(this.müşteriTanımToolStripMenuItem_Click);
            // 
            // ürünTanimToolStripMenuItem
            // 
            this.ürünTanimToolStripMenuItem.Name = "ürünTanimToolStripMenuItem";
            this.ürünTanimToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ürünTanimToolStripMenuItem.Text = "Ürün Tanim";
            this.ürünTanimToolStripMenuItem.Click += new System.EventHandler(this.ürünTanimToolStripMenuItem_Click);
            // 
            // firmaTanımToolStripMenuItem
            // 
            this.firmaTanımToolStripMenuItem.Name = "firmaTanımToolStripMenuItem";
            this.firmaTanımToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.firmaTanımToolStripMenuItem.Text = "Firma Tanım";
            this.firmaTanımToolStripMenuItem.Click += new System.EventHandler(this.firmaTanımToolStripMenuItem_Click);
            // 
            // personelTanımToolStripMenuItem
            // 
            this.personelTanımToolStripMenuItem.Name = "personelTanımToolStripMenuItem";
            this.personelTanımToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personelTanımToolStripMenuItem.Text = "Personel Tanım";
            this.personelTanımToolStripMenuItem.Click += new System.EventHandler(this.personelTanımToolStripMenuItem_Click);
            // 
            // listelerToolStripMenuItem
            // 
            this.listelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem1,
            this.UrunListesiToolStripMenuItem,
            this.firmaListesiToolStripMenuItem,
            this.personelListesiToolStripMenuItem,
            this.faturaListesiToolStripMenuItem});
            this.listelerToolStripMenuItem.Name = "listelerToolStripMenuItem";
            this.listelerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.listelerToolStripMenuItem.Text = "Listeler";
            // 
            // müşteriListesiToolStripMenuItem1
            // 
            this.müşteriListesiToolStripMenuItem1.Name = "müşteriListesiToolStripMenuItem1";
            this.müşteriListesiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.müşteriListesiToolStripMenuItem1.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem1.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem1_Click);
            // 
            // UrunListesiToolStripMenuItem
            // 
            this.UrunListesiToolStripMenuItem.Name = "UrunListesiToolStripMenuItem";
            this.UrunListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UrunListesiToolStripMenuItem.Text = "Ürün Listesi";
            this.UrunListesiToolStripMenuItem.Click += new System.EventHandler(this.UrunListesiToolStripMenuItem_Click);
            // 
            // firmaListesiToolStripMenuItem
            // 
            this.firmaListesiToolStripMenuItem.Name = "firmaListesiToolStripMenuItem";
            this.firmaListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaListesiToolStripMenuItem.Text = "Firma Listesi";
            this.firmaListesiToolStripMenuItem.Click += new System.EventHandler(this.firmaListesiToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saToolStripMenuItem,
            this.faturaSatışToolStripMenuItem});
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.satışlarToolStripMenuItem.Text = "Satışlar";
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saToolStripMenuItem.Text = "Masa Satış";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // faturaSatışToolStripMenuItem
            // 
            this.faturaSatışToolStripMenuItem.Name = "faturaSatışToolStripMenuItem";
            this.faturaSatışToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.faturaSatışToolStripMenuItem.Text = "Fatura Satış";
            this.faturaSatışToolStripMenuItem.Click += new System.EventHandler(this.faturaSatışToolStripMenuItem_Click);
            // 
            // faturaListesiToolStripMenuItem
            // 
            this.faturaListesiToolStripMenuItem.Name = "faturaListesiToolStripMenuItem";
            this.faturaListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturaListesiToolStripMenuItem.Text = "Fatura Listesi";
            this.faturaListesiToolStripMenuItem.Click += new System.EventHandler(this.faturaListesiToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTanimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UrunListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaListesiToolStripMenuItem;
    }
}

