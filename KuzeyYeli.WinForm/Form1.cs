using KuzeyYeli.ORM.Entity;
using KuzeyYeli.ORM.Fascade;
using System;
using System.Windows.Forms;

namespace KuzeyYeli.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun entity = new Urun();
            entity.UrunAdi = textBox1.Text;
            entity.Fiyat = numericUpDown1.Value;
            entity.Stok = (short)numericUpDown2.Value;
            if (!Urunler.Ekle(entity))
                MessageBox.Show("Ürün Eklenemedi");

            dataGridView1.DataSource = Urunler.Listele();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Urunler.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            Urun silinecek = new Urun();
            silinecek.UrunId = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
            if(!Urunler.Sil(silinecek))
                MessageBox.Show("Silinemedi");
            dataGridView1.DataSource = Urunler.Listele();
        }
    }
}
