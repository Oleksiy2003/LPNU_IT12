using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

using System.Windows.Forms;

namespace Lessons
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
          

            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            All();
        }
        public async void All()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data");
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data\Default");
            IWebDriver Browser = new ChromeDriver(options);
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.instagram.com/");
            System.Threading.Thread.Sleep(4000);

            //Search input profile name field

            IWebElement userNameInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(2) > div > label > input"));
            userNameInput.SendKeys("oleksiy_lopatskiy03");
            IWebElement passInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(3) > div > label > input"));
            passInput.SendKeys("Oleksiy.lopatskiy2003");
            IWebElement LogInButton = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(4) > button"));
            LogInButton.Click();
           System.Threading.Thread.Sleep(4000);
             IWebElement saveInfo = Browser.FindElement(By.CssSelector("#react-root > section > main > div > div > div > div > button"));
          saveInfo.Click();
            System.Threading.Thread.Sleep(4000);
            IWebElement NotNow = Browser.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.mt3GC > button.aOOlW.HoLwm"));
            NotNow.Click();

            IWebElement Direct = Browser.FindElement(By.CssSelector("#react-root > section > nav > div._8MQSO.Cx7Bp > div > div > div.ctQZg > div > div:nth-child(2) > a"));
            Direct.Click();

            System.Threading.Thread.Sleep(5000);

            List<IWebElement> ChooseChat = new List<IWebElement>();



            // IWebElement scroll = Browser.FindElement(By.CssSelector("#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.oNO81 > div.Igw0E.IwRSH.eGOV_._4EzTm.i0EQd > div > div > div"));

            System.Threading.Thread.Sleep(4000);
           /* for (int i = 1; i < 100; i++)
            {
                IWebElement path = Browser.FindElement(By.XPath($"//*[@id='react-root']/section/div/div[2]/div/div/div[1]/div[2]/div/div/div/div/div[{i}]"));
                path.Click();
                System.Threading.Thread.Sleep(1000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
                js.ExecuteScript("document.querySelector('#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.oNO81 > div.Igw0E.IwRSH.eGOV_._4EzTm.i0EQd > div > div > div').scrollTop+=72");

            }*/
            for (int i = 0; i < 100; i++)
            {
                IWebElement Parent = Browser.FindElement(By.CssSelector("#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.oNO81 > div.Igw0E.IwRSH.eGOV_._4EzTm.i0EQd > div > div > div > div"));
                ChooseChat = Parent.FindElements(By.XPath("*")).ToList();

                ChooseChat[i].Click();
                if (i > 11) i -= 1; 
                //System.Threading.Thread.Sleep(500);


                IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
                js.ExecuteScript("document.querySelector('#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.oNO81 > div.Igw0E.IwRSH.eGOV_._4EzTm.i0EQd > div > div > div').scrollTop+=72");

                



            }


            // for (int i = 0; i < ChooseChat.Count; i++)
            // {
            //   System.Threading.Thread.Sleep(4000);


            // IWebElement ClickToMessage = Browser.FindElement(By.CssSelector("#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.DPiy6.Igw0E.IwRSH.eGOV_.vwCYk > div.uueGX > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.Igw0E.IwRSH.eGOV_.vwCYk.ItkAi > textarea"));
            //ClickToMessage.SendKeys("А Gazon чізас");
            //IWebElement Send = Browser.FindElement(By.CssSelector("#react-root > section > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.DPiy6.Igw0E.IwRSH.eGOV_.vwCYk > div.uueGX > div > div.Igw0E.IwRSH.eGOV_._4EzTm > div > div > div.Igw0E.IwRSH.eGOV_._4EzTm.JI_ht > button"));
            //Send.Click();*
            // }*/




            /* for (int i = 0; i < 20; i++)
             {*/

            /*  */
            /* }*/



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {
           
        }

       

       
    }
   
        
}
