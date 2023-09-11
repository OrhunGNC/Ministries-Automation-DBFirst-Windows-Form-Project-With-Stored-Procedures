namespace BakanlıkProje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bakanlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vergilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatandaşlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakanlikAdi = new System.Windows.Forms.Label();
            this.daireBaskanlik = new System.Windows.Forms.Label();
            this.Ciro = new System.Windows.Forms.Label();
            this.Merkez = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.VergiAdi = new System.Windows.Forms.Label();
            this.vergiTipi = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.faiz = new System.Windows.Forms.Label();
            this.Tcno = new System.Windows.Forms.Label();
            this.Meslek = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.vergisondaniki = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.vergison = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bakanlıkToolStripMenuItem,
            this.vergilerToolStripMenuItem,
            this.vatandaşlarToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bakanlıkToolStripMenuItem
            // 
            this.bakanlıkToolStripMenuItem.Name = "bakanlıkToolStripMenuItem";
            this.bakanlıkToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bakanlıkToolStripMenuItem.Text = "Bakanlık";
            this.bakanlıkToolStripMenuItem.Click += new System.EventHandler(this.bakanlıkToolStripMenuItem_Click);
            // 
            // vergilerToolStripMenuItem
            // 
            this.vergilerToolStripMenuItem.Name = "vergilerToolStripMenuItem";
            this.vergilerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.vergilerToolStripMenuItem.Text = "Vergiler";
            this.vergilerToolStripMenuItem.Click += new System.EventHandler(this.vergilerToolStripMenuItem_Click);
            // 
            // vatandaşlarToolStripMenuItem
            // 
            this.vatandaşlarToolStripMenuItem.Name = "vatandaşlarToolStripMenuItem";
            this.vatandaşlarToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.vatandaşlarToolStripMenuItem.Text = "Vatandaşlar";
            this.vatandaşlarToolStripMenuItem.Click += new System.EventHandler(this.vatandaşlarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 267);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // bakanlikAdi
            // 
            this.bakanlikAdi.AutoSize = true;
            this.bakanlikAdi.Location = new System.Drawing.Point(537, 37);
            this.bakanlikAdi.Name = "bakanlikAdi";
            this.bakanlikAdi.Size = new System.Drawing.Size(69, 13);
            this.bakanlikAdi.TabIndex = 2;
            this.bakanlikAdi.Text = "Bakanlık Adı:";
            // 
            // daireBaskanlik
            // 
            this.daireBaskanlik.AutoSize = true;
            this.daireBaskanlik.Location = new System.Drawing.Point(537, 88);
            this.daireBaskanlik.Name = "daireBaskanlik";
            this.daireBaskanlik.Size = new System.Drawing.Size(86, 13);
            this.daireBaskanlik.TabIndex = 3;
            this.daireBaskanlik.Text = "Daire Başkanlığı:";
            // 
            // Ciro
            // 
            this.Ciro.AutoSize = true;
            this.Ciro.Location = new System.Drawing.Point(537, 149);
            this.Ciro.Name = "Ciro";
            this.Ciro.Size = new System.Drawing.Size(28, 13);
            this.Ciro.TabIndex = 4;
            this.Ciro.Text = "Ciro:";
            // 
            // Merkez
            // 
            this.Merkez.AutoSize = true;
            this.Merkez.Location = new System.Drawing.Point(537, 207);
            this.Merkez.Name = "Merkez";
            this.Merkez.Size = new System.Drawing.Size(45, 13);
            this.Merkez.TabIndex = 5;
            this.Merkez.Text = "Merkez:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(636, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(636, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(636, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(636, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // VergiAdi
            // 
            this.VergiAdi.AutoSize = true;
            this.VergiAdi.Location = new System.Drawing.Point(537, 37);
            this.VergiAdi.Name = "VergiAdi";
            this.VergiAdi.Size = new System.Drawing.Size(52, 13);
            this.VergiAdi.TabIndex = 10;
            this.VergiAdi.Text = "Vergi Adı:";
            // 
            // vergiTipi
            // 
            this.vergiTipi.AutoSize = true;
            this.vergiTipi.Location = new System.Drawing.Point(537, 88);
            this.vergiTipi.Name = "vergiTipi";
            this.vergiTipi.Size = new System.Drawing.Size(54, 13);
            this.vergiTipi.TabIndex = 11;
            this.vergiTipi.Text = "Vergi Tipi:";
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Location = new System.Drawing.Point(537, 149);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(35, 13);
            this.tutar.TabIndex = 12;
            this.tutar.Text = "Tutar:";
            // 
            // faiz
            // 
            this.faiz.AutoSize = true;
            this.faiz.Location = new System.Drawing.Point(537, 207);
            this.faiz.Name = "faiz";
            this.faiz.Size = new System.Drawing.Size(29, 13);
            this.faiz.TabIndex = 13;
            this.faiz.Text = "Faiz:";
            // 
            // Tcno
            // 
            this.Tcno.AutoSize = true;
            this.Tcno.Location = new System.Drawing.Point(537, 37);
            this.Tcno.Name = "Tcno";
            this.Tcno.Size = new System.Drawing.Size(41, 13);
            this.Tcno.TabIndex = 14;
            this.Tcno.Text = "TC No:";
            // 
            // Meslek
            // 
            this.Meslek.AutoSize = true;
            this.Meslek.Location = new System.Drawing.Point(537, 88);
            this.Meslek.Name = "Meslek";
            this.Meslek.Size = new System.Drawing.Size(44, 13);
            this.Meslek.TabIndex = 15;
            this.Meslek.Text = "Meslek:";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(537, 145);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(37, 13);
            this.adres.TabIndex = 16;
            this.adres.Text = "Adres:";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(537, 207);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(46, 13);
            this.telefon.TabIndex = 17;
            this.telefon.Text = "Telefon:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(537, 267);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(29, 13);
            this.mail.TabIndex = 18;
            this.mail.Text = "Mail:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(636, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(291, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(49, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Kaydet";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(164, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(291, 341);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 28;
            this.button9.Text = "Sil";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // vergisondaniki
            // 
            this.vergisondaniki.AutoSize = true;
            this.vergisondaniki.Location = new System.Drawing.Point(537, 267);
            this.vergisondaniki.Name = "vergisondaniki";
            this.vergisondaniki.Size = new System.Drawing.Size(65, 13);
            this.vergisondaniki.TabIndex = 29;
            this.vergisondaniki.Text = "Bakanlık ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(636, 312);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 30;
            // 
            // vergison
            // 
            this.vergison.AutoSize = true;
            this.vergison.Location = new System.Drawing.Point(537, 315);
            this.vergison.Name = "vergison";
            this.vergison.Size = new System.Drawing.Size(69, 13);
            this.vergison.TabIndex = 31;
            this.vergison.Text = "Vatandas ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(476, 267);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(476, 267);
            this.dataGridView3.TabIndex = 33;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.vergison);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.vergisondaniki);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.Meslek);
            this.Controls.Add(this.Tcno);
            this.Controls.Add(this.faiz);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.vergiTipi);
            this.Controls.Add(this.VergiAdi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Merkez);
            this.Controls.Add(this.Ciro);
            this.Controls.Add(this.daireBaskanlik);
            this.Controls.Add(this.bakanlikAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bakanlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vergilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatandaşlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label bakanlikAdi;
        private System.Windows.Forms.Label daireBaskanlik;
        private System.Windows.Forms.Label Ciro;
        private System.Windows.Forms.Label Merkez;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label VergiAdi;
        private System.Windows.Forms.Label vergiTipi;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Label faiz;
        private System.Windows.Forms.Label Tcno;
        private System.Windows.Forms.Label Meslek;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label vergisondaniki;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label vergison;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

