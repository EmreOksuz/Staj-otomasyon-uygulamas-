namespace VeriTabaniÖdev
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.öTB = new System.Windows.Forms.TextBox();
            this.soyadTB = new System.Windows.Forms.TextBox();
            this.adTB = new System.Windows.Forms.TextBox();
            this.önuTB = new System.Windows.Forms.TextBox();
            this.Öögretim = new System.Windows.Forms.Label();
            this.ÖSoyad = new System.Windows.Forms.Label();
            this.ÖAd = new System.Windows.Forms.Label();
            this.Önumara = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MulakatTTB = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.KurumCB = new System.Windows.Forms.ComboBox();
            this.YeniEkleBTN = new System.Windows.Forms.Button();
            this.ListeTemizleButon = new System.Windows.Forms.Button();
            this.tplamgünTB = new System.Windows.Forms.TextBox();
            this.kayitsilBTN = new System.Windows.Forms.Button();
            this.tamamlaBTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.stajsonucuTB = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SehirCB = new System.Windows.Forms.ComboBox();
            this.kabuledilenTB = new System.Windows.Forms.TextBox();
            this.stajKonusuTB = new System.Windows.Forms.TextBox();
            this.sınıfBilgiTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GreenPB = new System.Windows.Forms.PictureBox();
            this.RedPB = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RedPB);
            this.groupBox1.Controls.Add(this.GreenPB);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.öTB);
            this.groupBox1.Controls.Add(this.soyadTB);
            this.groupBox1.Controls.Add(this.adTB);
            this.groupBox1.Controls.Add(this.önuTB);
            this.groupBox1.Controls.Add(this.stajsonucuTB);
            this.groupBox1.Controls.Add(this.Öögretim);
            this.groupBox1.Controls.Add(this.ÖSoyad);
            this.groupBox1.Controls.Add(this.ÖAd);
            this.groupBox1.Controls.Add(this.Önumara);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Staj Komisyonu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Raporlar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Staj Değerlendirme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "DGS veya YG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // öTB
            // 
            this.öTB.Location = new System.Drawing.Point(155, 134);
            this.öTB.Name = "öTB";
            this.öTB.Size = new System.Drawing.Size(114, 23);
            this.öTB.TabIndex = 7;
            // 
            // soyadTB
            // 
            this.soyadTB.Location = new System.Drawing.Point(155, 99);
            this.soyadTB.Name = "soyadTB";
            this.soyadTB.Size = new System.Drawing.Size(114, 23);
            this.soyadTB.TabIndex = 6;
            // 
            // adTB
            // 
            this.adTB.Location = new System.Drawing.Point(155, 70);
            this.adTB.Name = "adTB";
            this.adTB.Size = new System.Drawing.Size(114, 23);
            this.adTB.TabIndex = 5;
            // 
            // önuTB
            // 
            this.önuTB.Location = new System.Drawing.Point(155, 39);
            this.önuTB.Name = "önuTB";
            this.önuTB.Size = new System.Drawing.Size(114, 23);
            this.önuTB.TabIndex = 4;
            // 
            // Öögretim
            // 
            this.Öögretim.AutoSize = true;
            this.Öögretim.Location = new System.Drawing.Point(70, 137);
            this.Öögretim.Name = "Öögretim";
            this.Öögretim.Size = new System.Drawing.Size(61, 15);
            this.Öögretim.TabIndex = 3;
            this.Öögretim.Text = "Öğretim:";
            // 
            // ÖSoyad
            // 
            this.ÖSoyad.AutoSize = true;
            this.ÖSoyad.Location = new System.Drawing.Point(83, 102);
            this.ÖSoyad.Name = "ÖSoyad";
            this.ÖSoyad.Size = new System.Drawing.Size(51, 15);
            this.ÖSoyad.TabIndex = 2;
            this.ÖSoyad.Text = "Soyad:";
            // 
            // ÖAd
            // 
            this.ÖAd.AutoSize = true;
            this.ÖAd.Location = new System.Drawing.Point(106, 73);
            this.ÖAd.Name = "ÖAd";
            this.ÖAd.Size = new System.Drawing.Size(28, 15);
            this.ÖAd.TabIndex = 1;
            this.ÖAd.Text = "Ad:";
            // 
            // Önumara
            // 
            this.Önumara.AutoSize = true;
            this.Önumara.Location = new System.Drawing.Point(7, 42);
            this.Önumara.Name = "Önumara";
            this.Önumara.Size = new System.Drawing.Size(126, 15);
            this.Önumara.TabIndex = 0;
            this.Önumara.Text = "Öğrenci Numarası:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MulakatTTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.KurumCB);
            this.groupBox2.Controls.Add(this.YeniEkleBTN);
            this.groupBox2.Controls.Add(this.ListeTemizleButon);
            this.groupBox2.Controls.Add(this.tplamgünTB);
            this.groupBox2.Controls.Add(this.kayitsilBTN);
            this.groupBox2.Controls.Add(this.tamamlaBTN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.SehirCB);
            this.groupBox2.Controls.Add(this.kabuledilenTB);
            this.groupBox2.Controls.Add(this.stajKonusuTB);
            this.groupBox2.Controls.Add(this.sınıfBilgiTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(331, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staj Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MulakatTTB
            // 
            this.MulakatTTB.Location = new System.Drawing.Point(122, 173);
            this.MulakatTTB.Mask = "00/00/0000 90:00";
            this.MulakatTTB.Name = "MulakatTTB";
            this.MulakatTTB.Size = new System.Drawing.Size(114, 23);
            this.MulakatTTB.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mülakat Tarihi:";
            // 
            // KurumCB
            // 
            this.KurumCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.KurumCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.KurumCB.FormattingEnabled = true;
            this.KurumCB.Location = new System.Drawing.Point(121, 42);
            this.KurumCB.Name = "KurumCB";
            this.KurumCB.Size = new System.Drawing.Size(222, 23);
            this.KurumCB.TabIndex = 24;
            // 
            // YeniEkleBTN
            // 
            this.YeniEkleBTN.Location = new System.Drawing.Point(461, 239);
            this.YeniEkleBTN.Name = "YeniEkleBTN";
            this.YeniEkleBTN.Size = new System.Drawing.Size(86, 23);
            this.YeniEkleBTN.TabIndex = 23;
            this.YeniEkleBTN.Text = "Yeni Kayıt";
            this.YeniEkleBTN.UseVisualStyleBackColor = true;
            this.YeniEkleBTN.Click += new System.EventHandler(this.YeniEkleBTN_Click);
            // 
            // ListeTemizleButon
            // 
            this.ListeTemizleButon.Location = new System.Drawing.Point(461, 206);
            this.ListeTemizleButon.Name = "ListeTemizleButon";
            this.ListeTemizleButon.Size = new System.Drawing.Size(178, 23);
            this.ListeTemizleButon.TabIndex = 22;
            this.ListeTemizleButon.Text = "Liste Temizle";
            this.ListeTemizleButon.UseVisualStyleBackColor = true;
            this.ListeTemizleButon.Click += new System.EventHandler(this.ListeTemizleButon_Click);
            // 
            // tplamgünTB
            // 
            this.tplamgünTB.Location = new System.Drawing.Point(122, 106);
            this.tplamgünTB.Name = "tplamgünTB";
            this.tplamgünTB.Size = new System.Drawing.Size(114, 23);
            this.tplamgünTB.TabIndex = 21;
            // 
            // kayitsilBTN
            // 
            this.kayitsilBTN.Location = new System.Drawing.Point(553, 173);
            this.kayitsilBTN.Name = "kayitsilBTN";
            this.kayitsilBTN.Size = new System.Drawing.Size(86, 23);
            this.kayitsilBTN.TabIndex = 20;
            this.kayitsilBTN.Text = "Kayıt Sil";
            this.kayitsilBTN.UseVisualStyleBackColor = true;
            this.kayitsilBTN.Click += new System.EventHandler(this.kayitsilBTN_Click);
            // 
            // tamamlaBTN
            // 
            this.tamamlaBTN.Location = new System.Drawing.Point(461, 173);
            this.tamamlaBTN.Name = "tamamlaBTN";
            this.tamamlaBTN.Size = new System.Drawing.Size(86, 23);
            this.tamamlaBTN.TabIndex = 19;
            this.tamamlaBTN.Text = "Tamamla";
            this.tamamlaBTN.UseVisualStyleBackColor = true;
            this.tamamlaBTN.Click += new System.EventHandler(this.tamamlaBTN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "*Staj Tamamlanması için yapılması gerek gün sayısı: 60";
            // 
            // stajsonucuTB
            // 
            this.stajsonucuTB.AutoSize = true;
            this.stajsonucuTB.Location = new System.Drawing.Point(152, 173);
            this.stajsonucuTB.Name = "stajsonucuTB";
            this.stajsonucuTB.Size = new System.Drawing.Size(15, 15);
            this.stajsonucuTB.TabIndex = 17;
            this.stajsonucuTB.Text = "0";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(461, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // SehirCB
            // 
            this.SehirCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SehirCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SehirCB.FormattingEnabled = true;
            this.SehirCB.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak "});
            this.SehirCB.Location = new System.Drawing.Point(461, 42);
            this.SehirCB.Name = "SehirCB";
            this.SehirCB.Size = new System.Drawing.Size(129, 23);
            this.SehirCB.TabIndex = 13;
            // 
            // kabuledilenTB
            // 
            this.kabuledilenTB.Enabled = false;
            this.kabuledilenTB.Location = new System.Drawing.Point(461, 135);
            this.kabuledilenTB.Name = "kabuledilenTB";
            this.kabuledilenTB.Size = new System.Drawing.Size(129, 23);
            this.kabuledilenTB.TabIndex = 12;
            // 
            // stajKonusuTB
            // 
            this.stajKonusuTB.Location = new System.Drawing.Point(461, 106);
            this.stajKonusuTB.Name = "stajKonusuTB";
            this.stajKonusuTB.Size = new System.Drawing.Size(130, 23);
            this.stajKonusuTB.TabIndex = 11;
            // 
            // sınıfBilgiTB
            // 
            this.sınıfBilgiTB.Location = new System.Drawing.Point(122, 138);
            this.sınıfBilgiTB.Name = "sınıfBilgiTB";
            this.sınıfBilgiTB.Size = new System.Drawing.Size(114, 23);
            this.sınıfBilgiTB.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "*Staj Sonucu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kabul Edilen Gün:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sınıf Bilgisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Staj Konusu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Gün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlama Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurum Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(14, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1041, 272);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 14F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(17, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1023, 234);
            this.listBox1.TabIndex = 0;
            // 
            // GreenPB
            // 
            this.GreenPB.Image = ((System.Drawing.Image)(resources.GetObject("GreenPB.Image")));
            this.GreenPB.Location = new System.Drawing.Point(184, 166);
            this.GreenPB.Name = "GreenPB";
            this.GreenPB.Size = new System.Drawing.Size(28, 24);
            this.GreenPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GreenPB.TabIndex = 18;
            this.GreenPB.TabStop = false;
            this.GreenPB.Visible = false;
            // 
            // RedPB
            // 
            this.RedPB.Image = ((System.Drawing.Image)(resources.GetObject("RedPB.Image")));
            this.RedPB.Location = new System.Drawing.Point(218, 166);
            this.RedPB.Name = "RedPB";
            this.RedPB.Size = new System.Drawing.Size(28, 24);
            this.RedPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedPB.TabIndex = 19;
            this.RedPB.TabStop = false;
            this.RedPB.Visible = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 618);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GreenPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox öTB;
        private System.Windows.Forms.TextBox soyadTB;
        private System.Windows.Forms.TextBox adTB;
        private System.Windows.Forms.TextBox önuTB;
        private System.Windows.Forms.Label Öögretim;
        private System.Windows.Forms.Label ÖSoyad;
        private System.Windows.Forms.Label ÖAd;
        private System.Windows.Forms.Label Önumara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox SehirCB;
        private System.Windows.Forms.TextBox kabuledilenTB;
        private System.Windows.Forms.TextBox stajKonusuTB;
        private System.Windows.Forms.TextBox sınıfBilgiTB;
        private System.Windows.Forms.Label stajsonucuTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tamamlaBTN;
        private System.Windows.Forms.Button kayitsilBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tplamgünTB;
        private System.Windows.Forms.Button ListeTemizleButon;
        private System.Windows.Forms.Button YeniEkleBTN;
        private System.Windows.Forms.ComboBox KurumCB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox MulakatTTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox RedPB;
        private System.Windows.Forms.PictureBox GreenPB;
    }
}

