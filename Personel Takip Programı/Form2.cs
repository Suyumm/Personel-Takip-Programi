using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;



namespace Personel_Takip_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection Fiydan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=personel.accdb");

        private void kullanicilari_goster()
        {
            try
            {
                Fiydan.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select tcno AS [TC KİMLİK NO],, ad AS[ADI],soyad AS [SOYADI],yetki AS [YETKİ],kullaniciadi AS [KULLANICI ADI],parola AS [PAROLA] from kullanicilar Order By ad ASC",Fiydan);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                Fiydan.Close();

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Fiydan.Close();
            }
        }

        private void personelleri_goster()
        {
            try
            {
                Fiydan.Open();
                OleDbDataAdapter personelleri_listele = new OleDbDataAdapter("select tcno AS [TC KİMLİK NO],, ad AS[ADI],soyad AS [SOYADI], cinsiyet AS [CİNSİYETİ], mezuniyet[MEZUNİYETİ], dogumtarihi AS [DOĞUM TARİHİ], gorevi AS [GÖREVİ], gorevyeri AS [GÖREV YERİ], maasi AS [MAAŞI] from personeller Oreder By ad ASC", Fiydan);
                DataSet dshafiza = new DataSet();
                personelleri_listele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                Fiydan.Close();

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Fiydan.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kullanicilari_goster();
            personelleri_goster();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
