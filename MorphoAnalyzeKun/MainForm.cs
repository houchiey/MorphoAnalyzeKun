using NMeCab;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MorphoAnalyzeKun
{
    public partial class AnalyzeForm : Form
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                fileSelectTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ExecAnalyzeBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(fileSelectTextBox.Text))
            {
                ClearBtn_Click(sender, e);
                return;
            }

            string text = "";
            using (var reader = new StreamReader(fileSelectTextBox.Text, Encoding.UTF8))
            {
                text = reader.ReadToEnd();
            }

            HashSet<string> targetHinshi = new HashSet<string>();
            foreach(CheckBox item in HinshiGroupBox.Controls)
            {
                if (item.Checked)
                {
                    targetHinshi.Add(item.Text);
                }
            }

            var mecab = MeCabTagger.Create();
            var node = mecab.ParseToNode(text);

            var result = new HashSet<AnalyzeResult>();
            while(node != null)
            {
                if(targetHinshi.Contains(node.Feature.Split(',')[0]) 
                    && !string.IsNullOrWhiteSpace(node.Surface))
                {
                    var wordOriginal = node.Feature.Split(',')[6];
                    var exist = result.Where(elem => elem.原形 == wordOriginal);

                    if (exist.Count() == 0)
                    {
                        result.Add(new AnalyzeResult
                        {
                            表層形 = node.Surface,
                            品詞 = node.Feature.Split(',')[0],
                            原形 = wordOriginal,
                            出現回数 = 1
                        });
                    }
                    else
                    {
                        exist.First().出現回数 += 1;
                    } 
                }
                node = node.Next;
            }
            var ds = result.ToList();
            ds.Sort((a, b) => b.出現回数 - a.出現回数);
            analyzeResultDGV.DataSource = ds;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            analyzeResultDGV.DataSource = new List<AnalyzeResult>();
        }
    }
}
