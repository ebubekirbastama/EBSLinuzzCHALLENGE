using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBSLinuzzCHALLENGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EBSKomutaKontrolmrkz.EBSBrowser = new ChromiumWebBrowser(EBSKomutaKontrolmrkz.EBSurl);
            panel1.Controls.Add(EBSKomutaKontrolmrkz.EBSBrowser);
            EBSKomutaKontrolmrkz.EBSBrowser.Dock = DockStyle.Fill;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }
        private void mesajAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                adresegit(EBSKomutaKontrolmrkz.EBSSendderUrl, i);
                Thread.Sleep(5000);

                object EvaluateJavaScriptResult;
                var frame = EBSKomutaKontrolmrkz.EBSBrowser.GetMainFrame();
                var task = frame.EvaluateScriptAsync("(function() { return document.getElementsByClassName('_4sWnG')[0].click(); })();", null);

                task.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        var response = t.Result;
                        EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;

                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }

        }
        private void adresegit(string url, int i)
        {

            EBSKomutaKontrolmrkz.EBSBrowser.Load(url);

            Thread.Sleep(5000);
            object EvaluateJavaScriptResult;
            var frame = EBSKomutaKontrolmrkz.EBSBrowser.GetMainFrame();
            var task = frame.EvaluateScriptAsync("(function() { return document.getElementsByClassName('form-control')[0].value='" + listBox1.Items[i].ToString() + "'; })();", null);

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;

                }
            }, TaskScheduler.FromCurrentSynchronizationContext());

            object EvaluateJavaScriptResult1;
            var frame1 = EBSKomutaKontrolmrkz.EBSBrowser.GetMainFrame();
            var task1 = frame.EvaluateScriptAsync("(function() { return document.getElementsByClassName('form-control')[1].value='Yeni Numaram bu'; })();", null);

            task1.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    EvaluateJavaScriptResult1 = response.Success ? (response.Result ?? "null") : response.Message;

                }
            }, TaskScheduler.FromCurrentSynchronizationContext());


            object EvaluateJavaScriptResult11;
            var frame11 = EBSKomutaKontrolmrkz.EBSBrowser.GetMainFrame();
            var task11 = frame.EvaluateScriptAsync("(function() { return document.getElementsByClassName('btn btn-primary btn-lg btn-block')[0].click(); })();", null);

            task11.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    EvaluateJavaScriptResult11 = response.Success ? (response.Result ?? "null") : response.Message;

                }
            }, TaskScheduler.FromCurrentSynchronizationContext());

            Thread.Sleep(5000);
        }

        private void numaralarıOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EBSKomutaKontrolmrkz.op = new OpenFileDialog();
            EBSKomutaKontrolmrkz.op.Title = "Text dosyası Seçiniz..";
            EBSKomutaKontrolmrkz.op.Filter = "Txt Dosyası |*.txt";
            EBSKomutaKontrolmrkz.op.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (EBSKomutaKontrolmrkz.op.ShowDialog() == DialogResult.OK)
            {
                EBSKomutaKontrolmrkz.dosyaYolu = EBSKomutaKontrolmrkz.op.FileName;

            }
            try
            {
                StreamReader sr = new StreamReader(EBSKomutaKontrolmrkz.dosyaYolu);
                string line = sr.ReadLine();

                while (line != null)
                {
                    listBox1.Items.Add(line);
                    line = sr.ReadLine();
                }

            }
            catch
            {
                MessageBox.Show("Dosya seçmediniz!");
            }

        }
    }
}
