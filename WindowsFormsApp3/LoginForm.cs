using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        ChromeDriver chromeDriver = Browser.chromeDriver; 
        Thread thread;

        public LoginForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        string Url = "https://www.facebook.com/login/";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            thread = new Thread(girisYap);
            thread.Start();
        }

        private void girisYap()
        {
            chromeDriver.FindElement(By.XPath("//input[@id='email']")).SendKeys(textEdit1.Text);
            Thread.Sleep(500);
            chromeDriver.FindElement(By.XPath("//input[@id='pass']")).SendKeys(textEdit2.Text);
            Thread.Sleep(500);
            chromeDriver.FindElement(By.XPath("//button[@id='loginbutton']")).Click();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(load);
            thread.Start();
            timer1.Start();
        }

        private void load()
        {
            chromeDriver.Navigate().GoToUrl(Url);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chromeDriver.Url == "https://www.facebook.com/checkpoint/?next")
            {
                timer1.Stop();
                this.Hide();
                VerificationForm verificationForm = new VerificationForm();
                verificationForm.Show();
                
            }
            if (chromeDriver.Url == "https://www.facebook.com/")
            {
                timer1.Stop();
                this.Hide();
                HomePageForm homePageForm = new HomePageForm();
                homePageForm.Show();
            }
        }
    }
}
