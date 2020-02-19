using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Core
{
    class CheckLoading
    {
        public void TrueLoading()
        {
            bool status = false;
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.chromeDriver;

            do
            {
                status = js.ExecuteScript("return document.readyState").ToString().Equals("complate");
            } while (status == true);
        }
    }
}
