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


namespace VeriTabaniÖdev
{
    
    public partial class StajDegerlendirme : Form
    {
        public float KabulEdilen = 0;
        public string deger;

        public StajDegerlendirme()
        {
            InitializeComponent();
        }
       
        private void StajDegerlendirme_Load(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(ddTB.Text)>=0 && Convert.ToSingle(ddTB.Text)<=100 && Convert.ToSingle(ccTB.Text)<=100 && Convert.ToSingle(ccTB.Text)>=0 && Convert.ToSingle(ivyTB.Text)<=100 && Convert.ToSingle(ivyTB.Text)>=0 && Convert.ToSingle(akdTB.Text)<=100 && Convert.ToSingle(akdTB.Text)>=0 &&
                Convert.ToSingle(iaktTB.Text)<=100 && Convert.ToSingle(iaktTB.Text)>=0 && Convert.ToSingle(projeTB.Text)<=100 && Convert.ToSingle(projeTB.Text)>=0 && Convert.ToSingle(düzenTB.Text)<=100 && Convert.ToSingle(düzenTB.Text)>=0 && Convert.ToSingle(sunumTB.Text)<=100 && Convert.ToSingle(sunumTB.Text)>=0 &&
                Convert.ToSingle(icerikTB.Text)<=100 && Convert.ToSingle(icerikTB.Text)>=0 && Convert.ToSingle(mülakatTB.Text)<=100 && Convert.ToSingle(mülakatTB.Text) >= 0)
            {
                
                KabulEdilen = Convert.ToSingle(ddTB.Text) * 4 / 100 + Convert.ToSingle(ccTB.Text) * 4 / 100 + Convert.ToSingle(ivyTB.Text) * 4 / 100 + Convert.ToSingle(akdTB.Text) * 4 / 100 +
                    Convert.ToSingle(iaktTB.Text) * 4 / 100 + Convert.ToSingle(projeTB.Text) * 15 / 100 + Convert.ToSingle(düzenTB.Text) * 5 / 100 + Convert.ToSingle(sunumTB.Text) * 5 / 100 +
                    Convert.ToSingle(icerikTB.Text) * 15 / 100 + Convert.ToSingle(mülakatTB.Text) * 40 / 100;

               
            basarıLabel.Text = KabulEdilen.ToString();
               

             }
            else
            {
                MessageBox.Show("Geçersiz Değer Girdiniz.Lütfen 0-100 arasında değer giriniz.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
