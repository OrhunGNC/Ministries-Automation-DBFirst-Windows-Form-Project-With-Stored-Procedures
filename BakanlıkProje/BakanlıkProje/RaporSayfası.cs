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
    public partial class RaporSayfası : Form
    {
        public RaporSayfası()
        {
            InitializeComponent();
        }
        BakanlıklarEntities coon = new BakanlıklarEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.BakanlıkSearch().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.VatandasSearch().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.VergiSearch().ToList();
        }
    }
}
