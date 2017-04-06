using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Speech.Recognition;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MedacProject
{
    public partial class Medline : Form
    {

        string conteudo = "";

        public Medline()
        {
            InitializeComponent();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            string urlfinal = Properties.Settings.Default.Setting_url + boxsearch.Text + "&retmax=" + Properties.Settings.Default.Setting_retmax;

            var result = new WebClient();
            result.DownloadStringAsync(new Uri(urlfinal));
            result.DownloadStringCompleted += Result_DownloadStringCompleted;
        }

        private void Result_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {

            listView1.View = View.Details;

            listView1.Columns.Add("Ranks");
            listView1.Columns.Add("Title");


            conteudo = e.Result;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(conteudo);


            XmlNodeList titles = doc.SelectNodes("//document/content[@name='title']");
            if (titles.Count == 0)
                MessageBox.Show("No results....");

            XmlNodeList ranks = doc.SelectNodes("//document/@rank");
            if (ranks.Count == 0)
                MessageBox.Show("No results....");


            string rankItem = "";
            foreach (XmlNode rank in ranks)
            {
                rankItem += rank.InnerText + " ";
            }

            int i = 0;
            string[] rankItems = rankItem.Split(' ');
            foreach (XmlNode title in titles)
            {

                String result = Regex.Replace(title.InnerText, @"<[^>]*>", String.Empty);
                ListViewItem linha = new ListViewItem(rankItems[i], 0);
                linha.SubItems.Add(result);

                listView1.Items.Add(linha);

                i++;
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            browsertitle.Navigate("about:blank");
            listBox1.Items.Clear();
            boxurl.Clear();
            summarybrowser.Navigate("about:blank");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            ListView.SelectedListViewItemCollection title = listView1.SelectedItems;


            string titulo = "";
            string rank = "";
            foreach (ListViewItem item in title)
            {
                titulo += item.SubItems[1].Text;
                rank = item.SubItems[0].Text;
            }

            browsertitle.DocumentText = titulo;




            XmlDocument doc = new XmlDocument();
            doc.LoadXml(conteudo);

            XmlNodeList altTitles = doc.SelectNodes(String.Format("//document[@rank='" + rank + "']/content[@name='altTitle']"));

            string altTitulo = "";
            foreach (XmlNode item in altTitles)
            {
                altTitulo = Regex.Replace(item.InnerText, @"<[^>]*>", String.Empty);
                listBox1.Items.Add(altTitulo);
            }


            XmlNodeList urls = doc.SelectNodes(String.Format("//document[@rank='" + rank + "']/@url"));

            string url = "";
            foreach (XmlNode item in urls)
            {
                url += item.InnerText;
                boxurl.Text = url;
            }


            XmlNodeList fullSummarys = doc.SelectNodes(String.Format("//document[@rank='" + rank + "']/content[@name='FullSummary']"));

            string fullSummary = "";
            foreach (XmlNode item in fullSummarys)
            {
                fullSummary = Regex.Replace(item.InnerText, @"<[^>]*>", String.Empty);
                summarybrowser.DocumentText = fullSummary;
            }

        }
        private void Medline_Load(object sender, EventArgs e)
        {
            SpeechRecognizer recognizer = new SpeechRecognizer();

            Choices colors = new Choices();

            colors.Add(new string[] { "Go", "Clear" });

            GrammarBuilder gb = new GrammarBuilder();

            gb.Append(colors);

            Grammar g = new Grammar(gb);

            recognizer.LoadGrammar(g);

            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            sr_SpeechRecognizer(sender, e);
        }

        void sr_SpeechRecognizer(object sender, SpeechRecognizedEventArgs e)
        {

            if (e.Result.Text.Equals("Go"))
                buttonGO_Click(sender, e);

            if (e.Result.Text.Equals("Clear"))
                btnClear_Click(sender, e);
        }
    }
}
