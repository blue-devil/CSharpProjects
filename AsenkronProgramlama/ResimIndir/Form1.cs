using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;           //FromStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;                //WebClient için
using System.IO;                //MemoryStream için

namespace ResimIndir
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded bu BlueDeviL // SCT\n04.05.2017","[SCT]C# ile Asenkron İndirme");
        }

        private void btnSenkron_Click(object sender, EventArgs e)
        {
            SenkronIndir();
            txtSenkron.Text = "İndirme başarılı";

        }

        private void SenkronIndir()
        {
            WebClient indirmeIstemcisi = new WebClient();
            byte[] resimVerisi = indirmeIstemcisi.DownloadData("http://www.sctzine.com/wp-content/uploads/cheatsheet19201200.png");
            pictSenkron.Image = Image.FromStream(new MemoryStream(resimVerisi));
        }

        private void btnAsenkron_Click(object sender, EventArgs e)
        {
            AsenkronIndir();                                //fonksiyonu çağıaracak
            txtAsenkron.Text = "İndiriliyor.............";  //fonksiyon çağrıldı bitti ama indirme devam edecek
                                                            //o yüzden bu komutu çağıracak
        }

          //async ve await tanımlamaları ile fonksiyonumuzu asenkron yaptık.
        private async void AsenkronIndir()
        {
            WebClient aIndirmeIstemcisi = new WebClient();
            byte[] aResimVerisi = await aIndirmeIstemcisi.DownloadDataTaskAsync("http://www.sctzine.com/wp-content/uploads/cheatsheet19201200.png");
            pictAsenkron.Image = Image.FromStream(new MemoryStream(aResimVerisi));
            txtAsenkron.Text = "İndirme Başarılı";          //indirme bittiğinde ise bu satır çalışacak
        }

          private void menuQuit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
     }
}
