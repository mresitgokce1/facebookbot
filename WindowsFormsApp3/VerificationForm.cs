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
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    public partial class VerificationForm : DevExpress.XtraEditors.XtraForm
    {
        public VerificationForm()
        {
            InitializeComponent();
        }

        private void VerificationForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Browser.chromeDriver.Url);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Thread thread = new Thread(verification);
            thread.Start();
        }

        private void verification()
        {
            Browser.chromeDriver.FindElement(By.XPath("//input[@id='approvals_code']")).SendKeys(textEdit1.Text);
            Thread.Sleep(1000);
            Browser.chromeDriver.FindElement(By.XPath("//button[@id='checkpointSubmitButton']")).Click();
            Thread.Sleep(1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Browser.chromeDriver.Url == "https://www.facebook.com/")
            {
                timer1.Stop();
                HomePageForm homePageForm = new HomePageForm();
                homePageForm.Show();
                this.Close();
            }
        }
    }
}
