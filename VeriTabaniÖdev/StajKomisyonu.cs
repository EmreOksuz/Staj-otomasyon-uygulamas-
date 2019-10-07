﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniÖdev
{
    public partial class StajKomisyonu : Form
    {
        public StajKomisyonu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E32BK4C;Initial Catalog=STAJ;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void skEkleBTN_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into StajKo(Ad,Soyad,Ünvan,Komisyon) values(@p1,@p2,@p3,@p4)", baglanti);

            komut.Parameters.AddWithValue("@p1", skAdTB.Text);
            komut.Parameters.AddWithValue("@p2", sksoyadTB.Text);
            komut.Parameters.AddWithValue("@p3", skünvanTB.Text);
            komut.Parameters.AddWithValue("@p4", skkomisyonTB.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            skLB.Items.Clear();

            string sorgu = "select * from StajKo";


            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable(sorgu);
            adptr.Fill(dt); // datatable dolduruldu..
            int k = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                skLB.Items.Add(dt.Rows[k][2].ToString() + " " + dt.Rows[k][0].ToString() + "  " + dt.Rows[k][1].ToString() + "   Staj Komisyon Grubu:" + dt.Rows[k][3].ToString());
                k++;


            }

            baglanti.Close();




        }

        private void StajKomisyonu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from StajKo";


            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable(sorgu);
            adptr.Fill(dt); // datatable dolduruldu..
            int k = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              
                    skLB.Items.Add(dt.Rows[k][2].ToString() + " " + dt.Rows[k][0].ToString() + "  " + dt.Rows[k][1].ToString() + "   Staj Komisyon Grubu:" + dt.Rows[k][3].ToString());
                    k++;

                
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from StajKo where Ad=@k1", baglanti);
           
           
                    
          sil.Parameters.AddWithValue("@k1", skAdTB.Text);

         sil.ExecuteNonQuery();


            string sorgu = "select * from StajKo";
            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable(sorgu);
            adptr.Fill(dt); // datatable dolduruldu..
            int k = 0;



            skLB.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                skLB.Items.Add(dt.Rows[k][2].ToString() + " " + dt.Rows[k][0].ToString() + "  " + dt.Rows[k][1].ToString() + "   Staj Komisyon Grubu:" + dt.Rows[k][3].ToString());
                k++;


            }


            baglanti.Close();
            MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
