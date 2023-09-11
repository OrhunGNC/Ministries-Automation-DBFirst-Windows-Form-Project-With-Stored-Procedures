using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakanlıkProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BakanlıklarEntities coon = new BakanlıklarEntities();
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void bakanlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            bakanlikAdi.Visible = true;
            daireBaskanlik.Visible = true;
            Ciro.Visible = true;
            Merkez.Visible = true;
            VergiAdi.Visible = false;
            vergiTipi.Visible = false;
            tutar.Visible = false;
            faiz.Visible = false;
            Tcno.Visible = false;
            Meslek.Visible = false;
            adres.Visible = false;
            telefon.Visible = false;
            mail.Visible = false;
            vergisondaniki.Visible = false;
            vergison.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            dataGridView1.DataSource = coon.BakanlikList().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            bakanlikAdi.Visible = false;
            daireBaskanlik.Visible = false;
            Ciro.Visible = false;
            Merkez.Visible = false;
            VergiAdi.Visible = false;
            vergiTipi.Visible = false;
            tutar.Visible = false;
            faiz.Visible = false;
            Tcno.Visible = false;
            Meslek.Visible = false;
            adres.Visible = false;
            telefon.Visible = false;
            mail.Visible = false;
            vergisondaniki.Visible = false;
            vergison.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            
        }

        private void vergilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            bakanlikAdi.Visible = false;
            daireBaskanlik.Visible = false;
            Ciro.Visible = false;
            Merkez.Visible = false;
            VergiAdi.Visible = true;
            vergiTipi.Visible = true;
            tutar.Visible = true;
            faiz.Visible = true;
            Tcno.Visible = false;
            Meslek.Visible = false;
            adres.Visible = false;
            telefon.Visible = false;
            mail.Visible = false;
            vergisondaniki.Visible = true;
            vergison.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            dataGridView2.DataSource = coon.VergiList().ToList();
        }

        private void vatandaşlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            bakanlikAdi.Visible = false;
            daireBaskanlik.Visible = false;
            Ciro.Visible = false;
            Merkez.Visible = false;
            VergiAdi.Visible = false;
            vergiTipi.Visible = false;
            tutar.Visible = false;
            faiz.Visible = false;
            Tcno.Visible = true;
            Meslek.Visible = true;
            adres.Visible = true;
            telefon.Visible = true;
            mail.Visible = true;
            vergisondaniki.Visible = false;
            vergison.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            dataGridView3.DataSource = coon.VatandasList().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bakanlık save = new Bakanlık();
            save.bakanlıkAdi = textBox1.Text;
            save.daireBaskanlik = textBox2.Text;
            save.Ciro = Convert.ToDecimal(textBox3.Text);
            save.Merkez = textBox4.Text;
            coon.BakanlikAdd(save.bakanlıkAdi, save.daireBaskanlik, save.Ciro, save.Merkez);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.BakanlikList().ToList();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vergiler save = new Vergiler();
            save.vergiAdi = textBox1.Text;
            save.vergiTipi= textBox2.Text;
            save.Tutar = Convert.ToDecimal(textBox3.Text);
            save.faiz = textBox4.Text;
            save.bakanlıkID = Convert.ToInt32(textBox5.Text);
            save.vatandasID = Convert.ToInt32(textBox6.Text);
            coon.VergiAdd(save.vergiAdi, save.vergiTipi, save.Tutar, save.faiz, save.bakanlıkID, save.vatandasID);
            coon.SaveChanges();
            dataGridView2.DataSource = coon.VergiList().ToList();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bakanlık save = new Bakanlık();
            save.bakanlıkID = Convert.ToInt32(textBox1.Tag);
            save.bakanlıkAdi = textBox1.Text;
            save.daireBaskanlik = textBox2.Text;
            save.Ciro = Convert.ToDecimal(textBox3.Text);
            save.Merkez = textBox4.Text;
            coon.BakanlikUpdate(save.bakanlıkID,save.bakanlıkAdi, save.daireBaskanlik, save.Ciro, save.Merkez);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.BakanlikList().ToList();
            Temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vergiler save = new Vergiler();
            save.vergiID = Convert.ToInt32(textBox1.Tag);
            save.vergiAdi = textBox1.Text;
            save.vergiTipi = textBox2.Text;
            save.Tutar = Convert.ToDecimal(textBox3.Text);
            save.faiz = textBox4.Text;
            save.bakanlıkID = Convert.ToInt32(textBox5.Text);
            save.vatandasID = Convert.ToInt32(textBox6.Text);
            coon.VergiUpdate(save.vergiID,save.vergiAdi, save.vergiTipi, save.Tutar, save.faiz, save.bakanlıkID, save.vatandasID);
            coon.SaveChanges();
            dataGridView2.DataSource = coon.VergiList().ToList();
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bakanlık delete = new Bakanlık();
            delete.bakanlıkID = Convert.ToInt32(textBox1.Tag);
            coon.BakanlikDel(delete.bakanlıkID);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.BakanlikList().ToList();
            Temizle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vatanda save = new Vatanda();
            save.TCNo = textBox1.Text;
            save.Meslek = textBox2.Text;
            save.Adres = textBox3.Text;
            save.telefon = textBox4.Text;
            save.mail = textBox5.Text;
            coon.VatandasAdd(save.TCNo, save.Meslek, save.Adres, save.telefon, save.mail);
            coon.SaveChanges();
            dataGridView3.DataSource = coon.VatandasList().ToList();
            Temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vatanda save = new Vatanda();
            save.vatandasID = Convert.ToInt32(textBox1.Tag);
            save.TCNo = textBox1.Text;
            save.Meslek = textBox2.Text;
            save.Adres = textBox3.Text;
            save.telefon = textBox4.Text;
            save.mail = textBox5.Text;
            coon.VatandasUpdate(save.vatandasID,save.TCNo, save.Meslek, save.Adres, save.telefon, save.mail);
            coon.SaveChanges();
            dataGridView3.DataSource = coon.VatandasList().ToList();
            Temizle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Vatanda delete = new Vatanda();
            delete.vatandasID = Convert.ToInt32(textBox1.Tag);
            coon.VatandasDel(delete.vatandasID);
            coon.SaveChanges();
            dataGridView3.DataSource = coon.VatandasList().ToList();
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vergiler delete = new Vergiler();
            delete.vergiID = Convert.ToInt32(textBox1.Tag);
            coon.VergiDel(delete.vergiID);
            coon.SaveChanges();
            dataGridView2.DataSource = coon.VergiList().ToList();
            Temizle();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView2.CurrentRow;
            textBox1.Tag = column.Cells["vergiID"].Value.ToString();
            textBox1.Text = column.Cells["vergiAdi"].Value.ToString();
            textBox2.Text = column.Cells["vergiTipi"].Value.ToString();
            textBox3.Text = column.Cells["Tutar"].Value.ToString();
            textBox4.Text = column.Cells["Faiz"].Value.ToString();
            textBox5.Text = column.Cells["bakanlıkID"].Value.ToString();
            textBox6.Text = column.Cells["vatandasID"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["bakanlıkID"].Value.ToString();
            textBox1.Text = column.Cells["bakanlıkAdi"].Value.ToString();
            textBox2.Text = column.Cells["daireBaskanlik"].Value.ToString();
            textBox3.Text = column.Cells["Ciro"].Value.ToString();
            textBox4.Text = column.Cells["Merkez"].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView3.CurrentRow;
            textBox1.Tag = column.Cells["vatandasID"].Value.ToString();
            textBox1.Text = column.Cells["TCNo"].Value.ToString();
            textBox2.Text = column.Cells["Meslek"].Value.ToString();
            textBox3.Text = column.Cells["Adres"].Value.ToString();
            textBox4.Text = column.Cells["telefon"].Value.ToString();
            textBox5.Text = column.Cells["mail"].Value.ToString();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporSayfası go = new RaporSayfası();
            go.Show();
            this.Hide();
        }
    }
}
