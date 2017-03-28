using System.IO;
using System.Timers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;

namespace AppleBot
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private string strCountry = "HK";
        private string strLang = "en_HK";
        //private string strCountry = "AU";
        //private string strLang = "en_AU";
        private bool enablePopup = true;
        private DateTime dtLastPopup;
        private int intervalPopup = 600;//unit in second, popup every 10 minutes
        private int intervalCheck = 30000;//unit in millisecond, check the source every 1 minute
        private string strStoreJsonURL;

        System.Timers.Timer timerAvailability;



        List<Store> storeList;
        //1. Apple ID; 
        //2. 密碼；
        //3. 網頁驗證碼；
        ////4. 選擇分店；
        ////5. 選擇 iPhone 6 或 iPhone 6 Plus；
        ////6. 選擇淨機或上台；
        ////7. 選擇顏色；
        ////8. 選擇容量；
        ////9. 選擇數量；
        //10. 填寫個人資料（包括人名及身份證號碼）；
        ////11. 選擇取機時間。 
        //12. Mobile number
        //13. Mobile verify code
        //(852)64500366
        public Form1()
        {
            InitializeComponent();
            //initComponent();
            initComponentAuto();
        }

        private void initComponentAuto()
        {
            string strTest = @"Bi-gram
8.00:
3.00:file is
2.00:line is
2.00:text file
1.00:(end of";
            storeList = new List<Store>();
            strStoreJsonURL = string.Format(@"https://reserve.cdn-apple.com/{0}/{1}/reserve/iPhone/stores.json", strCountry, strLang);
            dtLastPopup = new DateTime(2014, 1, 1);
        }

        void OnTimerAvailabilityElapsed(object sender, System.Timers.ElapsedEventArgs args) { checkStoreAvailability(); }
        void startThreadCheckAvailability()
        {
            timerAvailability = new System.Timers.Timer();
            timerAvailability.Interval = intervalCheck;
            timerAvailability.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimerAvailabilityElapsed);
            timerAvailability.Start();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            //checkStoreAvailability();
            Thread tCheckStoreAvailability = new Thread(new ThreadStart(startThreadCheckAvailability));
            tCheckStoreAvailability.Start();
            //openBrowser();

            //Thread t = new Thread(new ThreadStart(openBrowser));
            //t.Start();
        }

        private void openBrowser()
        {
            driver = new FirefoxDriver();
            //http://chromedriver.storage.googleapis.com/index.html
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", Path.GetDirectoryName(Application.ExecutablePath) + "\\chromedriver.exe");
            //driver = new ChromeDriver();
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\my\Desktop\AppleBot-master\AppleBot-master\AppleBot\bin\Debug\IEDriverServer.exe");
            //driver = new InternetExplorerDriver();
            //driver.Navigate().GoToUrl("https://reserve-hk.apple.com/HK/zh_HK/reserve/iPhone/availability");
            //driver.Navigate().GoToUrl("http://store.apple.com/hk-zh/buy-iphone/iphone6");
            //driver.Navigate().GoToUrl("https://secure1.store.apple.com/hk-zh/sign_in?c=aHR0cDovL3N0b3JlLmFwcGxlLmNvbS9oay16aC9idXktaXBob25lL2lwaG9uZTZ8MWFvczc4NmQzZDZlZGVkYjk2MjQ0Y2QxYTQ0ZWI5NDc1NGQyNjRlMTYyNzk&r=SCDHYHP7CY4H9XK2H&s=aHR0cDovL3N0b3JlLmFwcGxlLmNvbS9oay16aC9idXktaXBob25lL2lwaG9uZTZ8MWFvczc4NmQzZDZlZGVkYjk2MjQ0Y2QxYTQ0ZWI5NDc1NGQyNjRlMTYyNzk&t=S99KKATD9FP9FHCP4");
            //driver.Navigate().GoToUrl(@"file:///C:/Projects/POC/AppleBot/AppleBot/bin/Debug/test1.html");
            //driver.Navigate().GoToUrl(string.Format(@"file:///{0}/test1.html", Path.GetDirectoryName(Application.ExecutablePath).Replace(@"\bin\Debug", "")));
            //driver.Navigate().GoToUrl(System.Configuration.ConfigurationSettings.AppSettings["URL"].ToString());
            //driver.Navigate().GoToUrl(@"C:\Users\my\Desktop\20140919\New3.html");



            driver.Navigate().GoToUrl(string.Format(@"https://reserve.cdn-apple.com/{0}/{1}/reserve/iPhone/availability", strCountry, strLang));

            //driver.Navigate().GoToUrl("https://secure2.store.apple.com/hk/sign_in/order?c=aHR0cHM6Ly9zZWN1cmUyLnN0b3JlLmFwcGxlLmNvbS9oay9hY2NvdW50L2hvbWV8MWFvczc3YjM3YjkxNWI4MTI3ODJiNGI1ZTFkNmI2ZmViZTUxMDJmNWU3NjQ&r=SCKFUHKXACXX7DYHYT9JT7JJTAPAXHFKH&s=aHR0cHM6Ly9zZWN1cmUyLnN0b3JlLmFwcGxlLmNvbS9oay9vcmRlci9saXN0P2hpc3Q9OTB8MWFvc2UyMTNjNzhjNGRmNGQzY2EzNWQyN2U1NjkyMjMzNjZkZjZhMWRjN2E&t=SXYD4UDAPXU7P7KXF");

            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#


            // Find the text input element by its name
            //IWebElement query = driver.FindElement(By.Name("Email"));
            ////driver.SwitchTo();

            //// Enter something to search for
            //query.SendKeys("");
            //query = driver.FindElement(By.Name("Passwd"));
            //query.SendKeys("");


            // Now submit the form. WebDriver will find the form for us from the element
            //query.Submit();

            //// Google's search is rendered dynamically with JavaScript.
            //// Wait for the page to load, timeout after 10 seconds
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until((d) => { return d.Title.ToLower().StartsWith("cheese"); });

            //// Should see: "Cheese - Google Search"
            //System.Console.WriteLine("Page title is: " + driver.Title);

            ////Close the browser
            ////driver.Quit();

        }


        private void btnPage3_Click(object sender, EventArgs e)
        {
            IWebElement query;
            SelectElement selector;
            //R207 MG3E2CL/A
            //IWebElement 
            //try
            //{
            //    query = driver.FindElement(By.Name("selectedStoreNumber"));
            //    selector = new SelectElement(query);
            //    selector.SelectByIndex(0);
            //}
            //catch (Exception ex) { }
            //Thread.Sleep(1000);
            //driver.FindElements(By.Name("product"))[0].Click();//0 for iphone6, 1 for iphone6Plus
            //Thread.Sleep(1000);
            //try { 
            //driver.FindElements(By.Name("selectedContractType"))[0].Click();//0 for non-contract
            //}
            //catch (Exception ex) { 
            //}
            ////need to pay attention to:
            //driver.FindElements(By.Name("color"))[1].Click();//0 for plus silver, 1 for silver, 2 for plus gold, 3 for gold, 4 for plus black, 5 for black
            ////driver.FindElements(By.Name("selectedPartNumber"))[1].Click();//0 for 16Gb, 1 for 64Gb, 2 for 128Gb
            //driver.FindElement(By.XPath("//input[@value='MG482ZP/A']")).Click();//

            try
            {
                query = driver.FindElement(By.Name("selectedQuantity"));
                selector = new SelectElement(query);
                selector.SelectByIndex(1);
            }
            catch (Exception ex) { }

            try
            {
                if (strCountry == "HK")
                {
                    query = driver.FindElement(By.Name("firstName"));
                    query.Clear();
                    query.SendKeys("Chao");
                    query = driver.FindElement(By.Name("lastName"));
                    query.Clear();
                    query.SendKeys("Ma");
                    query = driver.FindElement(By.Name("email"));
                    query.Clear();
                    query.SendKeys("macryant@msn.com");
                    query = driver.FindElement(By.Name("phoneNumber"));
                    query.Clear();
                    query.SendKeys("000085296466206");
                }
                else
                {
                    query = driver.FindElement(By.Name("firstName"));
                    query.Clear();
                    query.SendKeys("Apple");
                    query = driver.FindElement(By.Name("lastName"));
                    query.Clear();
                    query.SendKeys("Test");
                    query = driver.FindElement(By.Name("email"));
                    query.Clear();
                    query.SendKeys("appletestact1@gmail.com");
                    query = driver.FindElement(By.Name("phoneNumber"));
                    query.Clear();
                    query.SendKeys("000085212345678");
                }
            }
            catch (Exception ex) { }

            try
            {
                query = driver.FindElement(By.Name("selectedGovtIdType"));
                selector = new SelectElement(query);
                selector.SelectByIndex(1);

                query = driver.FindElement(By.Name("govtId"));
                query.Clear();
                query.SendKeys("R383857(8)");
            }
            catch (Exception ex) { }
            seleteTimeSlot(11);
            //try { 
            //    query = driver.FindElement(By.Name("selectedTimeSlotId"));
            //    selector = new SelectElement(query);
            //    selector.SelectByIndex(6);
            //}
            //catch (Exception ex) { }
        }

        private void seleteTimeSlot(int index)
        {
            try
            {
                IWebElement query = driver.FindElement(By.Name("selectedTimeSlotId"));
                SelectElement selector = new SelectElement(query);
                selector.SelectByIndex(index);
            }
            catch (Exception ex) { seleteTimeSlot(index - 1); }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IWebElement query = driver.SwitchTo().ActiveElement();
            //IWebElement query = driver.FindElement(By.Name("input-text"));
            if (strCountry == "HK")
            {
                query.Clear();
                query.SendKeys("***@msn.com");
                query = driver.FindElement(By.Name("accountPassword"));
                query.Clear();
                query.SendKeys("***");
            }
            else
            {
                query.Clear();
                query.SendKeys("***@gmail.com");
                query = driver.FindElement(By.Name("accountPassword"));
                query.Clear();
                query.SendKeys("****");
            }
            query = driver.FindElement(By.Name("captchaInput"));
            query.Clear();
            query.SendKeys(tbCapcha.Text);

            query.Submit();

        }


        private void checkStoreAvailability()
        {
            this.BeginInvoke((Action)(() => panel1.Controls.Clear()));
            //            document.getElementsByName('product')[1].checked = true;
            //document.getElementsByName('selectedContractType')[0].checked = true;
            //string strStoreJsonURL = @"https://reserve.cdn-apple.com/HK/en_HK/reserve/iPhone/stores.json";
            //string strAvailableJsonURL = @"https://reserve.cdn-apple.com/HK/en_HK/reserve/iPhone/availability.json";
            string strAvailableJsonURL = string.Format(@"https://reserve.cdn-apple.com/{0}/{1}/reserve/iPhone/availability.json", strCountry, strLang);
            var strStoreJson = "[" + new WebClient().DownloadString(strStoreJsonURL) + "]";
            var strAvailableJson = "[" + new WebClient().DownloadString(strAvailableJsonURL) + "]";
            //var strStoreJson = StoreAvailability.strStoreJson;
            //var strAvailableJson = StoreAvailability.strAvailabilityJson;
            JArray jaStore = JsonConvert.DeserializeObject<JArray>(strStoreJson);
            JArray jaStoreAvailable = JsonConvert.DeserializeObject<JArray>(strAvailableJson);
            if (jaStoreAvailable[0]["updated"] == null)
            {
                txtAvailable.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                return;
            }
            txtAvailable.Text = jaStoreAvailable[0]["updated"].ToString() + "----" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            string[] strModelNumber = new string[Constraints.strModelNumberGen.Count()];
            int[] iProductType = Constraints.iProductTypeGen;
            int[] iMemSize = Constraints.iMemSizeGen;
            int[] iColor = Constraints.iColorGen;
            for (int i = 0; i < Constraints.strModelNumberGen.Count(); i++)
            {
                switch (strCountry)
                {
                    case "AU":
                        strModelNumber[i] = Constraints.strModelNumberGen[i] + "X/A";
                        break;
                    case "HK":
                        strModelNumber[i] = Constraints.strModelNumberGen[i] + "ZP/A";
                        break;
                    case "DE":
                    case "FR":
                        strModelNumber[i] = Constraints.strModelNumberGen[i] + "ZD/A";
                        break;
                    case "CA":
                        strModelNumber[i] = Constraints.strModelNumberCA[i];
                        break;
                    case "JP":
                        strModelNumber[i] = Constraints.strModelNumberGen[i] + "2J/A";
                        break;
                }
            }
            int[] iPriority = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };
            StringBuilder sbLabelPlus = new StringBuilder();
            StringBuilder sbLabelNormal = new StringBuilder();
            bool appendLine = false;
            int storeCount = 0;
            if (jaStore[0]["stores"] != null) { storeCount = jaStore[0]["stores"].Count(); }
            List<Phone> phoneOrderedList = new List<Phone>();
            for (int i = 0; i < storeCount; i++)
            {
                Store s = new Store();
                s.storeName = jaStore[0]["stores"][i]["storeName"].ToString();
                s.storeNumber = jaStore[0]["stores"][i]["storeNumber"].ToString();
                for (int j = 0; j < 18; j++)
                {
                    //jaStoreAvailable[0]["R207"]["MG9R2CL/A"]
                    
                    s.phoneList[j] = new Phone();
                    s.phoneList[j].storeIndex = i;
                    s.phoneList[j].productType = iProductType[j];
                    switch (s.phoneList[j].productType)
                    {
                        case 0: s.phoneList[j].productTypeName = "iphone 6";
                            break;
                        case 1: s.phoneList[j].productTypeName = "iphone 6 Plus";
                            break;
                    }
                    s.phoneList[j].color = iColor[j];
                    switch (s.phoneList[j].color)
                    {
                        case 0: s.phoneList[j].colorName = "silver";
                            break;
                        case 1: s.phoneList[j].colorName = "gold";
                            break;
                        case 2: s.phoneList[j].colorName = "grey";
                            break;
                    }
                    s.phoneList[j].memorySize = iMemSize[j];
                    s.phoneList[j].availability = (jaStoreAvailable[0][s.storeNumber][strModelNumber[j]].ToString().ToLower() == "true");
                    s.phoneList[j].priority = j;// iPriority[j];
                    s.phoneList[j].storeName = s.storeName;
                    s.phoneList[j].storeNumber = s.storeNumber;
                    if (s.phoneList[j].availability)
                    {
                        phoneOrderedList.Add(s.phoneList[j]);
                        //if (s.phoneList[j].productType == 1) sbLabelPlus.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}\t", s.phoneList[j].productTypeName, s.storeName, s.phoneList[j].colorName, s.phoneList[j].memorySize));
                        //else sbLabelNormal.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}\t", s.phoneList[j].productTypeName, s.storeName, s.phoneList[j].colorName, s.phoneList[j].memorySize));
                    }
                    //s.phoneList[j].
                }
                // var store  =  from a in jaStoreAvailable where a;
            }
            var li = (from a in phoneOrderedList where a.availability == true select a).OrderByDescending(a => a.priority).ToList();
            int posCount = 0;
            for (int i = 0; i < li.Count; i++)
            {
                StringBuilder sbJs = new StringBuilder();
                //MessageBox.Show()
                UCPhone ucp = new UCPhone(driver, li[i]);
                ucp.Location = new System.Drawing.Point(0, posCount*25);
                ucp.Name = "ucPhone";
                ucp.Size = new System.Drawing.Size(672, 23);
                //this.panel1.Controls.Add(ucp);
                //panel1.Controls.Add(ucp);
                posCount++;
                ucp.tbDesc.Text = string.Format("{0}\t{1}\t{2}\t{3}\t", li[i].productTypeName,
                    li[i].storeName, li[i].colorName, li[i].memorySize);
                //sbJs.AppendLine(string.Format("document.getElementsByName('selectedStoreNumber')[0].value = '{0}'",
                //    li[i].storeNumber));
                //sbJs.AppendLine(string.Format("document.getElementsByName('selectedStoreNumber')[0].selectedIndex = {0};", (li[i].storeIndex + 1).ToString()));
                //ucp.TabIndex = 1;
                sbJs.AppendLine(string.Format("document.getElementsByName('product')[{0}].click();", li[i].productType));
                sbJs.AppendLine("document.getElementsByName('selectedContractType')[0].click();");
                if (li[i].productType == 0)
                {
                    sbJs.Append(string.Format("document.getElementsByName('color')[{0}].click();",
                        (li[i].color*2) + 1));
                }
                else
                {
                    sbJs.Append(string.Format("document.getElementsByName('color')[{0}].click();",
                        li[i].color*2));
                }
                //switch (li[i].memorySize)
                //{
                //    case 16:
                //        sbJs.AppendLine("document.getElementsByName('selectedPartNumber')[0].click();");
                //        break;
                //    case 64:
                //        sbJs.AppendLine("document.getElementsByName('selectedPartNumber')[1].click();");
                //        break;
                //    case 128:
                //        sbJs.AppendLine("document.getElementsByName('selectedPartNumber')[2].click();");
                //        break;
                //}
                ucp.tbJs.Text = sbJs.ToString();

                //if (
                //    (li[i].storeNumber == "R405") && li[i].color == 2 && li[i].productType ==
                //    1 && li[i].memorySize == 128)

                this.BeginInvoke((Action) (() =>
                {
                    //perform on the UI thread
                    //this.Controls.Add(l);

                    panel1.Controls.Add(ucp);
                }));
                if (enablePopup)
                {
                    if (i == li.Count - 1)
                    {
                        if ((DateTime.Now - dtLastPopup).TotalSeconds > intervalPopup)
                        {
                            dtLastPopup = DateTime.Now;
                            MessageBox.Show(sbJs.ToString());
                        }
                    }
                }
                //driver.FindElement(By.XPath("//input[@value='MG482ZP/A']")).Click();//

            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            checkStoreAvailability();
        }

        private void btnGenJs_Click(object sender, EventArgs e)
        {
            IWebElement query;
            SelectElement selector;
            //R207 MG3E2CL/A
            //IWebElement 
            try
            {
                query = driver.FindElement(By.Name("selectedStoreNumber"));
                selector = new SelectElement(query);
                selector.SelectByIndex(0);
            }
            catch (Exception ex) { }
            //string strLabelJs =
            // sbLabelJs.ToString();


            //tbJs.Text = strLabelJs;
            //Thread.Sleep(1000);

        }
    }
}

