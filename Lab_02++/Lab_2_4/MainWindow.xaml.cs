using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_2_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string alph = "01";


        private bool checkText(string text)
        {
            if (text != String.Empty)
            {
                return true;
            }
            return false;
        }

        private void Entropy(object sender, RoutedEventArgs e)
        {
            string text = RichText.GetText(OriginalText).Substring(0, RichText.GetText(OriginalText).Length - 2).ToLower();


            int[] alphCount = new int[alph.Length];
            int n = 0;
            double[] alphabetChance = new double[alph.Length];
            double entropy = 0.0D;
            double errorEntropy = 0.0D;

            if (Convert.ToDouble(Text.Text.Replace('.', ',')) != 0 && (Convert.ToDouble(Text.Text.Replace('.',',')) != 1.0D))
            {
                errorEntropy = Convert.ToDouble(Text.Text.Replace('.', ',')) * Math.Log(Convert.ToDouble(Text.Text.Replace('.', ',')), 2) + (1 - Convert.ToDouble(Text.Text.Replace('.', ','))) * Math.Log((1 - Convert.ToDouble(Text.Text.Replace('.', ','))), 2);
            }


            string rplChars = " ,.!?:-;()[]'\"";
            foreach (var chr in rplChars)
            {
                text = text.Replace(chr.ToString(), "");
            }

            if (!checkText(text))
            {
                MessageBox.Show("Введите символ алфавита, не пустую строку :)");
                return;
            }

            string binText = "";
            var textChr = Encoding.ASCII.GetBytes(text);
            foreach (int chr in textChr)
            {
                binText += Convert.ToString(chr, 2).PadLeft(8, '0');
            }

            for (int i = 0; i < binText.Length; i++)
            {
                for (int j = 0; j < alph.Length; j++)
                {
                    if (binText[i] == alph[j])
                    {
                        alphCount[j]++;
                        n++;
                    }
                }
            }

            for (int i = 0; i < alphabetChance.Length; i++)
            {
                alphabetChance[i] = (double)alphCount[i] / n;
            }

            for (int i = 0; i < alphabetChance.Length; i++)
            {
                if (alphabetChance[i] != 0)
                {
                    entropy += alphabetChance[i] * Math.Log(alphabetChance[i], 2);
                }
            }

            if (errorEntropy != 0)
            {
                entropy -= errorEntropy;
            }

            TextEntropy.Text = (Math.Abs(entropy) * binText.Length).ToString();

        }
    }

    public static class RichText
    {
        public static void SetText(this RichTextBox richTextBox, string text)
        {
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(text)));
        }

        public static string GetText(this RichTextBox richTextBox)
        {
            return new TextRange(richTextBox.Document.ContentStart,
                richTextBox.Document.ContentEnd).Text;
        }
    }
}