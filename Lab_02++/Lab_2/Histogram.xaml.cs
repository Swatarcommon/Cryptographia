using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for Histogram.xaml
    /// </summary>
    public partial class Histogram : Window
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        double[] alphabetChance = new double[alphabet.Length];

        public Histogram()
        {
            InitializeComponent();
        }

        public Histogram(double[] _alphabetChance)
        {
            this.alphabetChance = _alphabetChance;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double max = alphabetChance.Max();
            AChance.Content = alphabetChance[0].ToString();
            AHisto.Height = (int)(alphabetChance[0] * 300 / max);
            BChance.Content = alphabetChance[1].ToString();
            BHisto.Height = (int)(alphabetChance[1] * 300 / max);
            CChance.Content = alphabetChance[2].ToString();
            CHisto.Height = (int)(alphabetChance[2] * 300 / max);
            DChance.Content = alphabetChance[3].ToString();
            DHisto.Height = (int)(alphabetChance[3] * 300 / max);
            EChance.Content = alphabetChance[4].ToString();
            EHisto.Height = (int)(alphabetChance[4] * 300 / max);
            FChance.Content = alphabetChance[5].ToString();
            FHisto.Height = (int)(alphabetChance[5] * 300 / max);
            GChance.Content = alphabetChance[6].ToString();
            GHisto.Height = (int)(alphabetChance[6] * 300 / max);
            HChance.Content = alphabetChance[7].ToString();
            HHisto.Height = (int)(alphabetChance[7] * 300 / max);
            IChance.Content = alphabetChance[8].ToString();
            IHisto.Height = (int)(alphabetChance[8] * 300 / max);
            JChance.Content = alphabetChance[9].ToString();
            JHisto.Height = (int)(alphabetChance[9] * 300 / max);
            KChance.Content = alphabetChance[10].ToString();
            KHisto.Height = (int)(alphabetChance[10] * 300 / max);
            LChance.Content = alphabetChance[11].ToString();
            LHisto.Height = (int)(alphabetChance[11] * 300 / max);
            MChance.Content = alphabetChance[12].ToString();
            MHisto.Height = (int)(alphabetChance[12] * 300 / max);
            NChance.Content = alphabetChance[13].ToString();
            NHisto.Height = (int)(alphabetChance[13] * 300 / max);
            OChance.Content = alphabetChance[14].ToString();
            OHisto.Height = (int)(alphabetChance[14] * 300 / max);
            PChance.Content = alphabetChance[15].ToString();
            PHisto.Height = (int)(alphabetChance[15] * 300 / max);
            QChance.Content = alphabetChance[16].ToString();
            QHisto.Height = (int)(alphabetChance[16] * 300 / max);
            RChance.Content = alphabetChance[17].ToString();
            RHisto.Height = (int)(alphabetChance[17] * 300 / max);
            SChance.Content = alphabetChance[18].ToString();
            SHisto.Height = (int)(alphabetChance[18] * 300 / max);
            TChance.Content = alphabetChance[19].ToString();
            THisto.Height = (int)(alphabetChance[19] * 300 / max);
            UChance.Content = alphabetChance[20].ToString();
            UHisto.Height = (int)(alphabetChance[20] * 300 / max);
            VChance.Content = alphabetChance[21].ToString();
            VHisto.Height = (int)(alphabetChance[21] * 300 / max);
            WChance.Content = alphabetChance[22].ToString();
            WHisto.Height = (int)(alphabetChance[22] * 300 / max);
            XChance.Content = alphabetChance[23].ToString();
            XHisto.Height = (int)(alphabetChance[23] * 300 / max);
            YChance.Content = alphabetChance[24].ToString();
            YHisto.Height = (int)(alphabetChance[24] * 300 / max);
            ZChance.Content = alphabetChance[25].ToString();
            ZHisto.Height = (int)(alphabetChance[25] * 300 / max);
        }
    }
}
