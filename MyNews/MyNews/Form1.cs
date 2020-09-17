using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Url = $"https://www.igromania.ru/news/sale/";
            var htmlActiv = new HtmlAgilityPack.HtmlWeb();
            var htmlDoc = htmlActiv.Load(Url);
            var NameNews = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='aubli_data']").ToList(); 
            //var NameNews = htmlDoc.DocumentNode.SelectNodes($"//div[@class='text_block_in']").ToList();
            foreach (var item in NameNews)
            {
                var splittedWords = Regex.Split(item.InnerText, "\n");
                var words = splittedWords
                    .Where(x => !x.Contains("&nbsp;") && !string.IsNullOrEmpty(x.Trim()))
                    .ToList();
                richTextBox1.AppendText($"{words[0]}");
                //label1.Text = 
            }
        }
    }
}
