using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ONUR GOZ
namespace CekilisProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnCekilis_Click(object sender, EventArgs e)
        {

            dgvListe.Rows.Clear();//Data Grid View'i Tmizleyip Devam Eder
            CekilisHesapla();
        }
        private void CekilisHesapla()
        {
           
            int CekilisSayisi = Convert.ToInt32(nbxSayi.Text);//Numeric'deki sayı değişkene atılıyor.
            List<string> ListAdaylar = new List<string>(rtxbListe.Text.Split('\n'));//Listemizin neye göre oluşturulacağını belirtiyoruz.
            if (rtxbListe.Text == "")//Eğer veri yoksa mesaj gönderiyoruz.
            {
                MessageBox.Show("Adayları Girmelisiniz.");
            }
            else
            {
                Random uret = new Random();//Random tanımlanıyor.

                for (int i = 0; i < CekilisSayisi; i++)//Numeric'den aldığımız değer kadar döndürülüyor.
                {
                    int KazananAday = uret.Next(0, ListAdaylar.Count);//Listeden miktar çekliyor.
                    dgvListe.Rows.Add(i + 1, ListAdaylar[KazananAday]);//Data Grid View'e kazanan aday yazılıyor.
                    ListAdaylar.Remove(ListAdaylar[KazananAday]);//Kazanan aday listeden siliniyor.
                }
            }
            
        }

        private void rtxbListe_TextChanged(object sender, EventArgs e)
        {
            //Listedeki satır sayısı label'a aktarılıyor.
            lblSayi.Text = rtxbListe.Lines.Count().ToString();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Grid View listemizi burada oluşturuyoruz.
            dgvListe.ColumnCount = 2;
            dgvListe.Columns[0].Name = "Sıra No";
            dgvListe.Columns[1].Name = "Ad Soyad";
        }

        private void btnYeniCekilis_Click(object sender, EventArgs e)
        {
            //Formdaki bilgileri temizleme işlemlerini hallediyoruz.
            rtxbListe.Clear();
            dgvListe.Rows.Clear();
            nbxSayi.Value = 1;
            

        }

        private void nbxSayi_ValueChanged(object sender, EventArgs e)
        {
            //Numeric kısmının alacağı değerler sınırlandırılıyor.
            if (rtxbListe.Lines.Count() == 0)
            {
                nbxSayi.Minimum = 0;
            }
            else if (rtxbListe.Lines.Count()==1)
             {
                nbxSayi.Maximum = 1;
            }
            else
                nbxSayi.Maximum = rtxbListe.Lines.Count()-1;
        }
    }
}
