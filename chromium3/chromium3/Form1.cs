using CefSharp; //chromium libary
using CefSharp.Example.Handlers;
using CefSharp.WinForms; //chromium libary pro winform
using chromium3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace chromium3
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm //material form is open source ui framework if you wish to remove it just use "Form1 : Form"
    {




        public Form1()
        {
            InitializeComponent();
            


        }

        
        ChromiumWebBrowser chrome;
       

        public object ProgressBar1 { get; private set; } //download progressbar
        public static string SetValueForText1 { get; private set; }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            //ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
            {
                if (chrome.CanGoForward) //if can go foward
                    chrome.Forward(); //goes foward
            }
        }

        private void Form1_Load(object sender, EventArgs e)  
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to lunch", "Attention!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }

            CefSettings setting = new CefSettings();
            setting.CachePath = "cache";
            //Cef.Initialize(setting); dont know why but after update doest work, browser seems to work fine after removing this
            
            txtUrl.Text = ($"{Settings.Default.searchengine}");
            chrome = new ChromiumWebBrowser(txtUrl.Text); //url bar
            chrome.Parent = tabControl1.SelectedTab;
           
            //this.pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
            chrome.DownloadHandler = new DownloadHandler(bar);
           




        }






        private void Chrome_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
           {
               txtUrl.Text = e.Address;
           }));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)


                chrome.Load(txtUrl.Text); //loads address from textUrl
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
                chrome.Refresh();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //romiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
            {
                if (chrome.CanGoBack)  
                    chrome.Back(); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown(); //shut down 
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ecitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // exin in strip down menu
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Tomáš Kárník, tomaskarnik0@gmail.com\n" +
                "Version-06\n" +
                "1.6. 2020"); //about tab
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void whatsmybrowsercomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new Tabpage();
            tab.Text = "New page";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser("https://www.whatsmybrowser.org");
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            txtUrl.Text = "https://www.whatsmybrowser.org";
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void btnNewtab_Click(object sender, EventArgs e) //new tab button
        {
            TabPage tab = new Tabpage();
            tab.Text = "New page";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser ($"{Settings.Default.searchengine}");
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            txtUrl.Text = ($"{Settings.Default.searchengine}");
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;



        }

        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tabControl1.SelectedTab.Text = e.Title;
            }));
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(current_tab);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void speedtestToolStripMenuItem_Click(object sender, EventArgs e) //otevírání určité stránky
        {
            TabPage tab = new Tabpage();
            tab.Text = "New page";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser("http://www.speed-battle.com/speedtest_e.php");
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            txtUrl.Text = "http://www.speed-battle.com/speedtest_e.php";
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void deleteCookiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cef.GetGlobalCookieManager().DeleteCookies("", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void changeUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings();

            // Show settings form
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show($"{///////////////}");

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) //favourites tab (fav1)
        {
            TabPage tab = new Tabpage();
            tab.Text = "New page";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser ($"{Settings.Default.fav1}"); //stores favourite page in Settings.settings as fav1 you can add more,just add button and create fav2
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            txtUrl.Text = ($"{Settings.Default.fav1}");
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void materialBack_Click(object sender, EventArgs e)
        {
            if (chrome != null)
            {
                if (chrome.CanGoBack)  
                    chrome.Back(); 
            }
        }

        private void materialFoward_Click(object sender, EventArgs e)
        {
            if (chrome != null)
            {
                if (chrome.CanGoForward) 
                    chrome.Forward(); 
            }
        }
        //material buttons are from ui framework
        private void materialRefresh_Click(object sender, EventArgs e) 
        {
            if (chrome != null)
                chrome.Refresh();
        }

        private void materialGo_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)


                chrome.Load(txtUrl.Text); //načte adresu z pole textUrl
        }

        private void materialClosetab_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(current_tab);
        }

        private void materialNewtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new Tabpage();
            tab.Text = "New page";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser($"{Settings.Default.searchengine}");
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            txtUrl.Text = ($"{Settings.Default.searchengine}");
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;

        }
    }
}


// created by Tomáš Kárník, tomaskarnik0@gmail.com