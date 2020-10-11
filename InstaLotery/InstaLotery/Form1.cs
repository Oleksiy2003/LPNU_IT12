using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Windows.Input;
namespace InstaLotery
{
    public partial class Form1 : Form
    {
        List<IWebElement> followButtons = new List<IWebElement>();
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public  async void All()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data");
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data\Default");
            IWebDriver Browser = new ChromeDriver(options);
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.instagram.com/");
            System.Threading.Thread.Sleep(4000);

            IWebElement userNameInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(2) > div > label > input"));
            userNameInput.SendKeys(textBox1.Text);
            IWebElement passInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(3) > div > label > input"));
            passInput.SendKeys(textBox2.Text);
            IWebElement LogInButton = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(4) > button"));
            LogInButton.Click();
            System.Threading.Thread.Sleep(4000);
            /*IWebElement saveInfo = Browser.FindElement(By.CssSelector("#react-root > section > main > div > div > div > div > button"));
            saveInfo.Click();*/
            /*System.Threading.Thread.Sleep(4000);
            IWebElement NotNow = Browser.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.mt3GC > button.aOOlW.HoLwm"));
            NotNow.Click();*/
/*            System.Threading.Thread.Sleep(4000);*/
            Browser.Navigate().GoToUrl(textBox3.Text);
            System.Threading.Thread.Sleep(2000);
            IWebElement subscribe = Browser.FindElement(By.CssSelector("#react-root > section > main > div > header > section > div.nZSzR > div.Igw0E.IwRSH.eGOV_._4EzTm > span > span.vBF20._1OSdk > button"));
            
            if (!subscribe.Text.Equals("Follow"))
            {
                System.Threading.Thread.Sleep(100);
            }
            else
            {
                
                subscribe.Click();
            }
            System.Threading.Thread.Sleep(2000);
            IWebElement following = Browser.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a"));
            following.Click();
            System.Threading.Thread.Sleep(2000);
          
            label1.Text = followButtons.Count.ToString();

            Click(Browser);

        }
        public async void Click(IWebDriver browser)
        {
            IWebElement block = browser.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.isgrP > ul > div"));
            followButtons = block.FindElements(By.TagName("button")).ToList();

            for (int i = 0; i < followButtons.Count; i++)
            {

               

                if (!followButtons[i].Text.Equals("Follow"))
                {
                    

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    followButtons[i].Click();


                  /*  IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
                    js.ExecuteScript("document.querySelector('body > div.RnEpo.Yx5HN').scrollBy(0,500)");*/

                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        public async void Unfollow()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data");
            options.AddArgument(@"--user-data-dir=C:\Users\Oleksiy\AppData\Local\Google\Chrome\User Data\Default");
            IWebDriver Browser = new ChromeDriver(options);
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.instagram.com/");
            System.Threading.Thread.Sleep(4000);

            IWebElement userNameInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(2) > div > label > input"));
            userNameInput.SendKeys(textBox1.Text);
            IWebElement passInput = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(3) > div > label > input"));
            passInput.SendKeys(textBox2.Text);
            IWebElement LogInButton = Browser.FindElement(By.CssSelector("#react-root > section > main > article > div.rgFsT > div:nth-child(1) > div > form > div:nth-child(4) > button"));
            LogInButton.Click();
            System.Threading.Thread.Sleep(4000);
            /*IWebElement saveInfo = Browser.FindElement(By.CssSelector("#react-root > section > main > div > div > div > div > button"));
            saveInfo.Click();*/
            /*System.Threading.Thread.Sleep(4000);
            IWebElement NotNow = Browser.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.mt3GC > button.aOOlW.HoLwm"));
            NotNow.Click();*/
            /*            System.Threading.Thread.Sleep(4000);*/
            Browser.Navigate().GoToUrl(textBox3.Text);
            System.Threading.Thread.Sleep(2000);
           /* IWebElement subscribe = Browser.FindElement(By.CssSelector("#react-root > section > main > div > header > section > div.nZSzR > div.Igw0E.IwRSH.eGOV_._4EzTm > span > span.vBF20._1OSdk > button"));

            if (!subscribe.Text.Equals("Follow"))
            {
                System.Threading.Thread.Sleep(100);
            }
            else
            {

                subscribe.Click();
            }*/
            System.Threading.Thread.Sleep(2000);
            IWebElement following = Browser.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a"));
            following.Click();
            System.Threading.Thread.Sleep(2000);

            label1.Text = followButtons.Count.ToString();

            UnFollowClick(Browser);
        }
         public async void UnFollowClick(IWebDriver browser)
        {
             IWebElement block = browser.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.isgrP > ul > div"));
                followButtons = block.FindElements(By.TagName("button")).ToList();

            for (int i = 0; i < followButtons.Count; i++)
            {  

                if (!followButtons[i].Text.Equals("Following"))
                {

                    followButtons.RemoveAt(i);
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    followButtons[i].Click();
                    IWebElement finish = browser.FindElement(By.CssSelector("body > div:nth-child(19) > div > div > div > div.mt3GC > button.aOOlW.-Cab_"));
                    finish.Click();
                    


                    /*  IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
                      js.ExecuteScript("document.querySelector('body > div.RnEpo.Yx5HN').scrollBy(0,500)");*/

                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                All();
            }
            if (checkBox2.Checked == true)
            {
                Unfollow();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                button1.Enabled = true;
            }

            else { 
                button1.Enabled = false;
                checkBox2.Enabled = true;
             }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                button1.Enabled = true;
            }

            else
            {
                button1.Enabled = false;
                checkBox1.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
