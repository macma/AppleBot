using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AppleBot
{
    public partial class UCPhone : UserControl
    {
        private IWebDriver driver;
        private Phone phone;
        public UCPhone(IWebDriver dr, Phone p)
        {
            this.driver = dr;
            this.phone = p;
            InitializeComponent();
        }

        private void btnCopyClipBoard_Click(object sender, EventArgs e)
        {
            IWebElement query;
            SelectElement selector;
            //R207 MG3E2CL/A
            //IWebElement 
            try
            {
                query = driver.FindElement(By.Name("selectedStoreNumber"));
                selector = new SelectElement(query);
                selector.SelectByIndex(phone.storeIndex + 1);
            }
            catch (Exception ex) { }

            Clipboard.Clear();
            Clipboard.SetText(tbJs.Text);

        }
    }
}
