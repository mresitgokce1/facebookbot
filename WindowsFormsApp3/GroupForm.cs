using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GroupForm : DevExpress.XtraEditors.XtraForm
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        Thread thread;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Browser.chromeDriver.Navigate().GoToUrl(textEdit1.Text);

            thread = new Thread(ArkadasiAcikMi);
            //thread.Start();



            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.chromeDriver;
            int degisken = 1;
            string degisken2 = "";

            do
            {
                degisken = 1;
                try
                {
                    degisken2 = Browser.chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[2]")).Text;
                }
                catch (Exception)
                {
                    js.ExecuteScript("window.scrollBy(0,1000)");
                    degisken = 0;
                }

            } while (degisken == 0); //Arkadaşlık sayfasını en alta indirir.

            List<string> list = new List<string>();
            bool kontrol = true;
            degisken = 1;

            for (int i = 1; kontrol; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    degisken = 1;
                    try
                    {
                        list.Add(Browser.chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[1]/div[2]/div/ul[" + i + "]/li[" + j + "]/div/a")).GetAttribute("href"));
                    }
                    catch (Exception)
                    {
                        kontrol = false;
                    }
                }
            } //Tüm Arkadaşların profil yolları alındı.

            ArkadasGez(list);





        }

        private void ArkadasGez(List<string> list)
        {
            foreach (var item in list)
            {
                Browser.chromeDriver.Navigate().GoToUrl(item);
                Thread.Sleep(1000);
                try
                {
                    listBoxControl1.Items.Add(Browser.chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[2]/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div/div/div[2]/div/div/div[2]/div/span[1]/span/a/abbr/span")).Text);
                }
                catch (Exception)
                {

                }
                Thread.Sleep(100);
                try
                {
                    Browser.chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[3]/div/div[1]/label/input")).Click();
                }
                catch (Exception)
                {
                    Browser.chromeDriver.Navigate().Back();

                }

                Thread.Sleep(1000);
            }

            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[2]/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div/div/div[2]/div/div/div[2]/div/span[1]/span/a/abbr/span" --> Son Paylaşımda Bulunduğu Tarih
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[1]/div/div" --> İsmi

            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[2]/div[3]/ul/li[2]/a" --> Hakkında Butonu
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/div[2]/div/ul/li[2]/div/div[1]/div/div/div/a[2]" --> İş ve Eğitim (Lise,Üniversite,i.ö.o)
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/div[2]/div/ul/li[2]/div/div[1]/div/div/div/a[3]" --> Yaşadığı Yer (bir şehir listesi ile karşılaştırılıp text içerisinde arama yaptırılıp ona göre işlem yapılır)
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/div[2]/div/ul/li[2]/div/div[1]/div/div/div/a[4]" --> Kadın/Erkek/Doğum Tarihi(bu yazı görününce sağındaki d.tarihi çekilebilir)
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/div[2]/div/ul/li[2]/div/div[1]/div/div/div/a[5]" --> Evlimi Bekar mı? İlişkisi var/İlişkisi yok/Evli/
            // "/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/div[2]/div/ul/li[2]/div/div[2]" --> Soldaki butonların sağdaki açıklama kısmı

            // "/html/body/div[1]/div[3]/div[1]/div/div[1]/div/div[2]/h2" --> Text "Şu anda bu özelliği kullanamazsın." ise click 
            // "/html/body/div[1]/div[3]/div[1]/div/div[3]/div/div[1]/label/input" --> yukarıdaki şart butonunun click kısmı
        }

        private void ArkadasiAcikMi()
        {
            Browser.chromeDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[2]/div[3]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            Core.CheckLoading checkLoading = new Core.CheckLoading();
        }
    }
}
