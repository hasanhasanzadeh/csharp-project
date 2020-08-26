using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using System.IO;

namespace AppSoftWares
{
    public partial class FrActive : MetroFramework.Forms.MetroForm
    {
        public FrActive()
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
        private void FrActive_Load(object sender, EventArgs e)
        {
            try
            {
                string folder = System.Windows.Forms.Application.StartupPath + @"\";
                string fileName = "config.txt";  
                string fullPath = folder + fileName;
                textBox2.Text = File.ReadAllText(fullPath);
                textBox2.Text= textBox2.Text.Trim(' ', '\r', '\n');
                string cpuInfo = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
                textBox1.Text = cpuInfo;

                if (textBox2.Text == CryptoEngine.Encrypt(cpuInfo, "abcd-12934-efg7h"))
                {
                    MessageBox.Show("نرم افزار قبلا فعال شده است", "گزارش");
                    textBox2.Enabled = false;
                    metroButton2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("فعال سازی نرم افزار به پایان رسیده است لطفا نسبت به فعال سازی نرم افزار اقدام فرمایید", "گزارش");
                    textBox2.Enabled = true;
                    metroButton2.Enabled = true;
                }


            }
            catch
            {

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("کد فعال سازی نباید خالی باشد","گزارش");
                }
                else
                {
                    if (textBox2.Text == CryptoEngine.Encrypt(textBox1.Text, "abcd-12934-efg7h"))
                    {
                        string folder = System.Windows.Forms.Application.StartupPath + @"\"; 
                        string fileName = "config.txt";
                        string fullPath = folder + fileName;
                        string[] authors =textBox2.Text.Split('a');   
                        File.WriteAllLines(fullPath, authors);  
                        MessageBox.Show("برنامه با موفقیت فعال شد");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("کد فعال سازی اشتباه می باشد ", "گزارش");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
