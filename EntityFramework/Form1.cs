using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext ctx = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            GridiLamdaKullanarakDoldur();

            cmbkategori.DisplayMember = "KategoriAdi";
            cmbkategori.ValueMember = "KategoriID";
            cmbkategori.DataSource = ctx.Kategorilers;

            cmbtedarikci.DisplayMember = "SirketAdi";
            cmbtedarikci.ValueMember = "TedarikciID";
            cmbtedarikci.DataSource = ctx.Tedarikcilers;


            GridiLİnqSorgusuİleDoldur();

            cmbkategori.DisplayMember = "KategoriAdi";
            cmbkategori.ValueMember = "KategoriID";
            cmbkategori.DataSource = ctx.Kategorilers;

            cmbtedarikci.DisplayMember = "SirketAdi";
            cmbtedarikci.ValueMember = "TedarikciID";
            cmbtedarikci.DataSource = ctx.Tedarikcilers;

        }

        private void GridiLİnqSorgusuİleDoldur()
        {
            var sonuc = from u in ctx.Urunlers
                        join k in ctx.Kategorilers on u.KategoriID equals k.KategoriID
                        join t in ctx.Tedarikcilers on u.TedarikciID equals t.TedarikciID
                        where u.Sonlandi == false
                        select new
                        {
                            ÜrünID = u.UrunID,
                            ÜrünAdı = u.UrunAdi,
                            u.Fiyat,
                            u.Stok,
                            k.KategoriID,
                            u.TedarikciID,
                            k.KategoriAdi,
                            ŞirketAdı= t.SirketAdi
                        };

            var sonuc2 = from u in ctx.Urunlers join sd in ctx.SatisDetays on u.UrunID equals sd.UrunID
                         join s in ctx.Satislars on sd.SatisID equals s.SatisID
                         join m in ctx.Musterilers on s.MusteriID equals m.MusteriID
                         orderby u.UrunAdi ascending
                         group sd by u.UrunAdi into grup //yukarıdaki sorguya isim verdik

                         select new
                         {
                             ÜrünAdı = grup.Key, //group by da yazılan da grubun key i olu. Onu çağırıyoruz.
                             SatışAdet = grup.Count(), //hangi üründen kaç tane alınmış onu görmek için
                             SatışToplamTutar = grup.Sum(x => x.Adet * x.Fiyat)
                           //u.UrunAdi,
                           //sd.Fiyat,
                           //sd.Adet,
                           //m.MusteriAdi,
                           //u.Stok,
                           //u.TedarikciID,
                           //u.KategoriID
                       };

            // kolonları joinlemenin bir başka yöntemi de böyle yöntemin adı lamda expression
            var sonuc3 = ctx.Urunlers.Join(ctx.Kategorilers, u => u.KategoriID, k => k.KategoriID,
                (u,k) => new{ u.UrunAdi, k.KategoriAdi }).OrderBy(x => x.UrunAdi).Take(10);

            //dataGridView1.DataSource = sonuc;
            dataGridView1.DataSource = sonuc2;
            //dataGridView1.DataSource = sonuc3;
        }

        private void GridiLamdaKullanarakDoldur()
        {
            dataGridView1.DataSource = ctx.Urunlers;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["Kategoriler"].Visible = false;
            dataGridView1.Columns["Tedarikciler"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nudfiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["Fiyat"].Value;
            nudstok.Value = (short)dataGridView1.CurrentRow.Cells["Stok"].Value;

            if(dataGridView1.CurrentRow.Cells["KategoriID"].Value != null)
            cmbkategori.SelectedValue = dataGridView1.CurrentRow.Cells["KategoriID"];

            if (dataGridView1.CurrentRow.Cells["TedarikciID"].Value != null)
                cmbtedarikci.SelectedValue = dataGridView1.CurrentRow.Cells["TedarikciID"];

            txturunAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txturunAdi.Text;
            u.Fiyat = nudfiyat.Value;
            u.Stok = (short)nudstok.Value;
            u.TedarikciID = (int)cmbtedarikci.SelectedValue;
            u.KategoriID = (int)cmbtedarikci.SelectedValue;
            ctx.Urunlers.InsertOnSubmit(u);
            ctx.SubmitChanges();
            ctx = new DataClasses1DataContext();
            dataGridView1.DataSource = ctx.Urunlers;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = (int)txturunAdi.Tag;
            Urunler u = ctx.Urunlers.SingleOrDefault(x => x.UrunID == id);
            u.UrunAdi = txturunAdi.Text;
            u.Fiyat = nudfiyat.Value;
            u.Stok = (short)nudstok.Value;
            u.TedarikciID = (int)cmbtedarikci.SelectedValue;
            u.KategoriID = (int)cmbkategori.SelectedValue;
            ctx.SubmitChanges();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = (int)txturunAdi.Tag;

            Urunler u = ctx.Urunlers.SingleOrDefault(x => x.UrunID == id);
            ctx.Urunlers.DeleteOnSubmit(u);
            ctx.SubmitChanges();
            dataGridView1.DataSource = ctx.Urunlers.Where(x=>x.Sonlandi == false);
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            ctx = new DataClasses1DataContext();
            dataGridView1.DataSource = ctx.Urunlers.Where(x => x.UrunAdi.Contains(txtara.Text) && x.Sonlandi==false);
        }

       
    }
}
