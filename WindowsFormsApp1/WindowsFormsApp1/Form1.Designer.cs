namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tOPWEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSHIRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHIRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOTTOMWEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lONGPANTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jEWELLRIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.daftargambartshirt = new System.Windows.Forms.ImageList(this.components);
            this.daftargambarshirt = new System.Windows.Forms.ImageList(this.components);
            this.daftargambarshorts = new System.Windows.Forms.ImageList(this.components);
            this.daftargambarlongpants = new System.Windows.Forms.ImageList(this.components);
            this.daftargambarjewell = new System.Windows.Forms.ImageList(this.components);
            this.daftargambarshoes = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOPWEARToolStripMenuItem,
            this.bOTTOMWEARToolStripMenuItem,
            this.aCCToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tOPWEARToolStripMenuItem
            // 
            this.tOPWEARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSHIRTToolStripMenuItem,
            this.sHIRTToolStripMenuItem});
            this.tOPWEARToolStripMenuItem.Name = "tOPWEARToolStripMenuItem";
            this.tOPWEARToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tOPWEARToolStripMenuItem.Text = "TOP WEAR";
            this.tOPWEARToolStripMenuItem.Click += new System.EventHandler(this.tOPWEARToolStripMenuItem_Click);
            // 
            // tSHIRTToolStripMenuItem
            // 
            this.tSHIRTToolStripMenuItem.Name = "tSHIRTToolStripMenuItem";
            this.tSHIRTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tSHIRTToolStripMenuItem.Text = "T-SHIRT";
            this.tSHIRTToolStripMenuItem.Click += new System.EventHandler(this.tSHIRTToolStripMenuItem_Click);
            // 
            // sHIRTToolStripMenuItem
            // 
            this.sHIRTToolStripMenuItem.Name = "sHIRTToolStripMenuItem";
            this.sHIRTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHIRTToolStripMenuItem.Text = "SHIRT";
            this.sHIRTToolStripMenuItem.Click += new System.EventHandler(this.sHIRTToolStripMenuItem_Click);
            // 
            // bOTTOMWEARToolStripMenuItem
            // 
            this.bOTTOMWEARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHORTToolStripMenuItem,
            this.lONGPANTSToolStripMenuItem});
            this.bOTTOMWEARToolStripMenuItem.Name = "bOTTOMWEARToolStripMenuItem";
            this.bOTTOMWEARToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.bOTTOMWEARToolStripMenuItem.Text = "BOTTOM WEAR";
            // 
            // sHORTToolStripMenuItem
            // 
            this.sHORTToolStripMenuItem.Name = "sHORTToolStripMenuItem";
            this.sHORTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHORTToolStripMenuItem.Text = "SHORT";
            this.sHORTToolStripMenuItem.Click += new System.EventHandler(this.sHORTToolStripMenuItem_Click);
            // 
            // lONGPANTSToolStripMenuItem
            // 
            this.lONGPANTSToolStripMenuItem.Name = "lONGPANTSToolStripMenuItem";
            this.lONGPANTSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lONGPANTSToolStripMenuItem.Text = "LONG PANTS";
            this.lONGPANTSToolStripMenuItem.Click += new System.EventHandler(this.lONGPANTSToolStripMenuItem_Click);
            // 
            // aCCToolStripMenuItem
            // 
            this.aCCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jEWELLRIESToolStripMenuItem,
            this.sHOESToolStripMenuItem});
            this.aCCToolStripMenuItem.Name = "aCCToolStripMenuItem";
            this.aCCToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aCCToolStripMenuItem.Text = "ACC";
            // 
            // jEWELLRIESToolStripMenuItem
            // 
            this.jEWELLRIESToolStripMenuItem.Name = "jEWELLRIESToolStripMenuItem";
            this.jEWELLRIESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jEWELLRIESToolStripMenuItem.Text = "JEWELLERIES";
            this.jEWELLRIESToolStripMenuItem.Click += new System.EventHandler(this.jEWELLRIESToolStripMenuItem_Click);
            // 
            // sHOESToolStripMenuItem
            // 
            this.sHOESToolStripMenuItem.Name = "sHOESToolStripMenuItem";
            this.sHOESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHOESToolStripMenuItem.Text = "SHOES";
            this.sHOESToolStripMenuItem.Click += new System.EventHandler(this.sHOESToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(314, 260);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(644, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(644, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SUB-TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 320);
            this.panel1.TabIndex = 7;
            // 
            // daftargambartshirt
            // 
            this.daftargambartshirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambartshirt.ImageStream")));
            this.daftargambartshirt.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambartshirt.Images.SetKeyName(0, "1.jpeg");
            this.daftargambartshirt.Images.SetKeyName(1, "2.jpeg");
            this.daftargambartshirt.Images.SetKeyName(2, "3.jpeg");
            // 
            // daftargambarshirt
            // 
            this.daftargambarshirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambarshirt.ImageStream")));
            this.daftargambarshirt.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambarshirt.Images.SetKeyName(0, "1.jpeg");
            this.daftargambarshirt.Images.SetKeyName(1, "2.jpeg");
            this.daftargambarshirt.Images.SetKeyName(2, "3.jpeg");
            // 
            // daftargambarshorts
            // 
            this.daftargambarshorts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambarshorts.ImageStream")));
            this.daftargambarshorts.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambarshorts.Images.SetKeyName(0, "1.jpeg");
            this.daftargambarshorts.Images.SetKeyName(1, "2.jpeg");
            this.daftargambarshorts.Images.SetKeyName(2, "3.jpeg");
            // 
            // daftargambarlongpants
            // 
            this.daftargambarlongpants.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambarlongpants.ImageStream")));
            this.daftargambarlongpants.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambarlongpants.Images.SetKeyName(0, "1.jpeg");
            this.daftargambarlongpants.Images.SetKeyName(1, "2.jpeg");
            this.daftargambarlongpants.Images.SetKeyName(2, "3.jpeg");
            // 
            // daftargambarjewell
            // 
            this.daftargambarjewell.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambarjewell.ImageStream")));
            this.daftargambarjewell.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambarjewell.Images.SetKeyName(0, "images (1).jpg");
            this.daftargambarjewell.Images.SetKeyName(1, "images.jpg");
            this.daftargambarjewell.Images.SetKeyName(2, "download.jpg");
            // 
            // daftargambarshoes
            // 
            this.daftargambarshoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftargambarshoes.ImageStream")));
            this.daftargambarshoes.TransparentColor = System.Drawing.Color.Transparent;
            this.daftargambarshoes.Images.SetKeyName(0, "nike-akuisisi-rtfkt-perusahaan-yang-membuat-desain-sepatu-untuk-metaverse65_700.j" +
        "pg");
            this.daftargambarshoes.Images.SetKeyName(1, "94261-sepatu-sneakers-jintu-99.jpg");
            this.daftargambarshoes.Images.SetKeyName(2, "data.jpeg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tOPWEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSHIRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHIRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOTTOMWEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lONGPANTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jEWELLRIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOESToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList daftargambartshirt;
        private System.Windows.Forms.ImageList daftargambarshirt;
        private System.Windows.Forms.ImageList daftargambarshorts;
        private System.Windows.Forms.ImageList daftargambarlongpants;
        private System.Windows.Forms.ImageList daftargambarjewell;
        private System.Windows.Forms.ImageList daftargambarshoes;
    }
}

