using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.IO;

namespace AppSoftWares
{
    public partial class FrMain : MetroFramework.Forms.MetroForm
    {
        public FrMain()
        {
            InitializeComponent();
        }
        public class CryptoEngine
        {
            public static string Encrypt(string input, string key)
            {
                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }

            public static string Decrypt(string input, string key)
            {
                byte[] inputArray = Convert.FromBase64String(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrDriver frdriver = new FrDriver();
                frdriver.Show();
            }
            catch { }
        }
        PersianCalendar pr = new PersianCalendar();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                label1.Text = "  امروز : " + pr.GetYear(DateTime.Now).ToString() + "/" + pr.GetMonth(DateTime.Now).ToString("0,0") + "/" + pr.GetDayOfMonth(DateTime.Now).ToString("0,0");
                label1.Text += "  ساعت : " + pr.GetHour(DateTime.Now).ToString("0,0") + ":" + pr.GetMinute(DateTime.Now).ToString("0,0") + ":" + pr.GetSecond(DateTime.Now).ToString("0,0");
                label2.Text = " Today : " + DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void ماشینحسابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc");
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void تغییرنامکاربریوگذرواژهعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrChangeUser frchangeuser = new FrChangeUser();
                frchangeuser.ShowDialog();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void FrMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditDriver fr = new FrEditDriver();
                fr.ShowDialog();
            }
            catch
            {

            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportDriver fr = new FrReportDriver();
                fr.Show();
            }
            catch
            {

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrFactors fr = new FrFactors();
                fr.Show();
            }
            catch
            {

            }
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text=Factors.SelectCompany();
                string folder = System.Windows.Forms.Application.StartupPath + @"\";
                string fileName = "config.txt";
                string fullPath = folder + fileName;

                string txt2 = File.ReadAllText(fullPath);
                txt2 = txt2.Trim(' ', '\r', '\n');

                string cpuInfo = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }

                if (txt2 == CryptoEngine.Encrypt(cpuInfo, "abcd-12934-efg7h"))
                {
                    //MessageBox.Show("نرم افزار قبلا فعال شده است", "گزارش");
                    menuStrip1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("فعال سازی نرم افزار به پایان رسیده است لطفا نسبت به فعال سازی نرم افزار اقدام فرمایید", "گزارش");
                    menuStrip1.Enabled = false;
                    FrActive fr = new FrActive();
                    fr.Show();
                }


            }
            catch
            {

            }
        }

        private void مشخصاتشرکتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditCompany fr = new FrEditCompany();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ثبتاطلاعاتشرکتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrProduct fr = new FrProduct();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ویرایشاطلاعاتشرکتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditProduct fr = new FrEditProduct();
                fr.Show();
            }
            catch
            {

            }
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frme fr = new Frme();
                fr.Show();
            }
            catch
            {

            }
        }

        private void دربارهنرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrSoftware fr = new FrSoftware();
                fr.Show();
            }
            catch
            {

            }
        }

        private void راهنمایفعالسازینرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrAboutActive fr = new FrAboutActive();
                fr.Show();
            }
            catch
            {

            }
        }

        private void فعالسازینرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrActive fr = new FrActive();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ایجادصندوقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrCash fr = new FrCash();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ویرایشحذفصندوقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditCash fr = new FrEditCash();
                fr.Show();
            }
            catch
            {

            }
        }

        private void گزارشصندوقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportCash fr = new FrReportCash();
                fr.Show();
            }
            catch
            {

            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrCast fr = new FrCast();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ویرایشحذفهزینههایجاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditCost fr = new FrEditCost();
                fr.Show();
            }
            catch
            {

            }
        }

        private void گزارشهزینههایجاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportCost fr = new FrReportCost();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ویرایشحذفپیشفاکتورخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditFactorBuy fr = new FrEditFactorBuy();
                fr.Show();
            }
            catch
            {

            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditFactorSell fr = new FrEditFactorSell();
                fr.Show();
            }
            catch
            {

            }
        }

        private void گزارشپیشفاتورفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportFactorBuy fr = new FrReportFactorBuy();
                fr.Show();
            }
            catch
            {

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportFactorSell fr = new FrReportFactorSell();
                fr.Show();
            }
            catch
            {

            }
        }

        private void خروجازکارخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrExit fr = new FrExit();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ورودازکارخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                FrEnter fr = new FrEnter();
                fr.Show();
            }
            catch
            {

            }

        }

        private void ویرایشورودازکارخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditEnter fr = new FrEditEnter();
                fr.Show();
            }
            catch
            {

            }
        }

        private void گزارشورودازکارخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportEnter fr = new FrReportEnter();
                fr.Show();
            }
            catch
            {

            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrEditExit fr = new FrEditExit();
                fr.Show();
            }
            catch
            {

            }

        }

        private void گزارشصادراتازمرزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportExit fr = new FrReportExit();
                fr.Show();
            }
            catch
            {

            }
        }

        private void گزارشخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrReportEN fr = new FrReportEN();
                fr.Show();
            }
            catch
            {

            }
        }
    }
}
