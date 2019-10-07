using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VeriTabaniÖdev
{
    public partial class DGSveYG : Form
    {
        public DGSveYG()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E32BK4C;Initial Catalog=STAJ;Integrated Security=True");
        public string DosyaYolu;
        private object lblFile;

        private void DGKaydetBTN_Click(object sender, EventArgs e)
        {   
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into DGSveYG(Oad,OSoyad,Okul,StajKurumu,YapılanGünSayısı,KabulEdilenGün,StajPdf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", ÖadTB.Text);
            komut.Parameters.AddWithValue("@p2", ÖsoyadTB.Text);
            komut.Parameters.AddWithValue("@p3", eoaTB.Text);
            komut.Parameters.AddWithValue("@p4", sekTB.Text);
            komut.Parameters.AddWithValue("@p5", ysgTB.Text);
            komut.Parameters.AddWithValue("@p6", kegsTB.Text);
            komut.Parameters.AddWithValue("@p7", sdTB.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EkleBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Pdf Dosyası |*.pdf";
            file.ShowDialog();
            DosyaYolu = file.FileName;
            sdTB.Text = DosyaYolu;
            
        }
    }
}
