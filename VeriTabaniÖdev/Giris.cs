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
using System.Data.OleDb;

namespace VeriTabaniÖdev
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E32BK4C;Initial Catalog=STAJ;Integrated Security=True");




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGSveYG F2 = new DGSveYG();
            F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StajDegerlendirme form = new StajDegerlendirme();
            form.Show();
        }

        private void tamamlaBTN_Click(object sender, EventArgs e)
        {
          

         
            if (Convert.ToInt16(tplamgünTB.Text) >= 15)
                 {
                baglanti.Open();
                if (Convert.ToInt16(tplamgünTB.Text) < 25 || Convert.ToInt16(sınıfBilgiTB.Text) != 2)
                {
                    if (Convert.ToInt16(tplamgünTB.Text) < 41)
                    {

                        SqlCommand komut = new SqlCommand("insert into Ogrenci(Numara,Ad,Soyad,Ögretim,KurumAd,Sehir,BaslamaTarih,BitisTarih,ToplamGün,StajKonusu,SınıfBilgisi,KabulEdilenGün,MülakatTarihi,Sonuc) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", baglanti);

                        komut.Parameters.AddWithValue("@p1", önuTB.Text);
                        komut.Parameters.AddWithValue("@p2", adTB.Text);
                        komut.Parameters.AddWithValue("@p3", soyadTB.Text);
                        komut.Parameters.AddWithValue("@p4", öTB.Text);
                        komut.Parameters.AddWithValue("@p5", KurumCB.Text);
                        komut.Parameters.AddWithValue("@p6", SehirCB.Text);
                        komut.Parameters.AddWithValue("@p7", dateTimePicker1.Text);
                        komut.Parameters.AddWithValue("@p8", dateTimePicker2.Text);
                        komut.Parameters.AddWithValue("@p9", tplamgünTB.Text);
                        komut.Parameters.AddWithValue("@p10", stajKonusuTB.Text);
                        komut.Parameters.AddWithValue("@p11", sınıfBilgiTB.Text);
                        komut.Parameters.AddWithValue("@p12",kabuledilenTB.Text);
                        komut.Parameters.AddWithValue("@p13", MulakatTTB.Text);
                        komut.Parameters.AddWithValue("@p14", stajsonucuTB.Text);
                        komut.ExecuteNonQuery();

                /*        baglanti.Open();      bir staj yerinde toplam 40 günden fazla , olayı.

                        string sorgu = "select * from Ogrenci";

                        SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
                        DataTable dt = new DataTable(sorgu);
                        adptr.Fill(dt); // datatable dolduruldu..
                        int toplamYG = 0;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i][4].ToString() == KurumCB.Text)
                           {
                                toplamYG += Convert.ToInt16(dt.Rows[i][10]);
                                if (toplamYG >= 40)
                                {

                                    MessageBox.Show("Bir kurumda toplam staj günü 40 günden fazla olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                        baglanti.Close(); */

                        MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (stajKonusuTB.Text == "Arge")
                    {

                        SqlCommand komut = new SqlCommand("insert into Ogrenci(Numara,Ad,Soyad,Ögretim,KurumAd,Sehir,BaslamaTarih,BitisTarih,ToplamGün,StajKonusu,SınıfBilgisi,KabulEdilenGün,MülakatTarihi,Sonuc) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", baglanti);
                        if (Convert.ToInt16(tplamgünTB.Text) < 61)
                        {   
                            komut.Parameters.AddWithValue("@p1", önuTB.Text);
                            komut.Parameters.AddWithValue("@p2", adTB.Text);
                            komut.Parameters.AddWithValue("@p3", soyadTB.Text);
                            komut.Parameters.AddWithValue("@p4", öTB.Text);
                            komut.Parameters.AddWithValue("@p5", KurumCB.Text);
                            komut.Parameters.AddWithValue("@p6", SehirCB.Text);
                            komut.Parameters.AddWithValue("@p7", dateTimePicker1.Text);
                            komut.Parameters.AddWithValue("@p8", dateTimePicker2.Text);
                            komut.Parameters.AddWithValue("@p9", tplamgünTB.Text);
                            komut.Parameters.AddWithValue("@p10", stajKonusuTB.Text);
                            komut.Parameters.AddWithValue("@p11", sınıfBilgiTB.Text);
                            komut.Parameters.AddWithValue("@p12", kabuledilenTB.Text);
                            komut.Parameters.AddWithValue("@p13", MulakatTTB.Text);
                            komut.Parameters.AddWithValue("@p14", stajsonucuTB.Text);
                            komut.ExecuteNonQuery();

                            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Arge'de 60 günden fazla staj yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir staj yerinde 40 günden fazla staj yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("2.Sınıf öğrencilerin staj süresi 25 günden fazla olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
              }
            else
            {
                MessageBox.Show("Staj Süresi 15 günden az olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }}
        private void button3_Click(object sender, EventArgs e)
        {



            baglanti.Open();
            string dgskn = önuTB.Text;
            string sorgu = "select * from Ogrenci";
            //   string sorgu2 = "select * from Ogrenci where numara=@p1";


            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable(sorgu);
            adptr.Fill(dt); // datatable dolduruldu..
            int toplam = 0;
            int k = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == önuTB.Text)
                {
                    listBox1.Items.Add(dt.Rows[i][0].ToString() + "  " + dt.Rows[i][1].ToString() + "  " + dt.Rows[i][2].ToString() + "  " + dt.Rows[i][3].ToString() + ".Öğretim  " + dt.Rows[i][4].ToString() + "/" + dt.Rows[i][5].ToString() + "  " + dt.Rows[i][6].ToString()
                        + "--" + dt.Rows[i][7].ToString() + "  " + dt.Rows[i][8].ToString() + " Gün. Staj Konusu:  " + dt.Rows[i][9].ToString() + "  Sınıfı:" +
                               dt.Rows[i][10].ToString() + "  Kabul Edilen Gün Sayısı:" + dt.Rows[i][11].ToString() +" Mülakat Tarihi:"+dt.Rows[i][12].ToString()+ " Staj Tamamlama Durumu: " + dt.Rows[i][13].ToString());
                    k++;
                    toplam += Convert.ToInt16(dt.Rows[i][11]);

                }
                adTB.Text = dt.Rows[0][1].ToString();
                soyadTB.Text = dt.Rows[0][2].ToString();
                öTB.Text = dt.Rows[0][3].ToString();

            }
           
            if (k == 0)
            {
               
                adTB.Text = "";
                soyadTB.Text = "";
                öTB.Text = "";
                MessageBox.Show("Aradığınız numarada kayıt bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RedPB.Visible = false;
                GreenPB.Visible = false;
            }
            stajsonucuTB.Text =toplam.ToString() ;


            if (toplam > 57)
            {
                RedPB.Visible = false;
                GreenPB.Visible = true;
              MessageBox.Show(önuTB.Text+" Numaralı öğrenci stajını Tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand günc = new SqlCommand("update Ogrenci set Sonuc='TAMAMLANDI' where Numara=@p1 ", baglanti);

                günc.Parameters.AddWithValue("@p1", önuTB.Text);
                günc.ExecuteNonQuery();
                MessageBox.Show(önuTB.Text+" Numaralı öğrenci stajını tamamladığı için Staj Durumu güncellenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();

            }
            else { GreenPB.Visible = false;
                RedPB.Visible = true;

                SqlCommand günc = new SqlCommand("update Ogrenci set Sonuc='TAMAMLANMADI' where Numara=@p1", baglanti);

                günc.Parameters.AddWithValue("@p1", önuTB.Text);
                günc.ExecuteNonQuery();
                MessageBox.Show(önuTB.Text + " Numaralı öğrenci stajını tamamlamadığı için Staj Durumu güncellenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();



            }
            baglanti.Close();

        }

        private void kayitsilBTN_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Ogrenci where Numara=@k1", baglanti);
        

            sil.Parameters.AddWithValue("@k1", önuTB.Text);
          


            sil.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Kayıt Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ListeTemizleButon_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void YeniEkleBTN_Click(object sender, EventArgs e)
        {
            önuTB.Text="";
            adTB.Text="";
            soyadTB.Text="";
            öTB.Text="";
            KurumCB.Text="";
            SehirCB.Text="";
            tplamgünTB.Text="";
            stajKonusuTB.Text="";
            sınıfBilgiTB.Text="";
            kabuledilenTB.Text="";
            stajsonucuTB.Text="";
            önuTB.Focus();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select KurumAd from Ogrenci ", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                KurumCB.Items.Add(oku[0].ToString());

            }

            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StajKomisyonu stj = new StajKomisyonu();
            stj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Raporlar rpr = new Raporlar();
            rpr.Show();
        }
    }
}
