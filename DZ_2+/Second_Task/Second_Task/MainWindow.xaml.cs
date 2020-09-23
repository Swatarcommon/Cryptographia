using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Second_Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static bool IsSimple(int n)
        {
            for (int i = 2; i <= (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private int NOD(int first, int second)
        {
            int a, b, q, r = 1;
            if (first >= second)
            {
                a = first;
                b = second;
            }
            else
            {
                a = second;
                b = first;
            }
            while (r != 0)
            {
                q = (int)(a / b);
                r = (a % b);
                a = b;
                b = r;
            }
            return a;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            ComboRoot.Items.Clear();
            if ((TextN.Text != String.Empty) || (TextN.Text.Replace(" ", "") != ""))
            {
                int n = Convert.ToInt32(TextN.Text.Replace(" ", ""));
                if (true)
                {
                    List<int> fn = new List<int>();
                    for (int i = 2; i <= n; i++)
                    {
                        if (NOD(n, i) == 1)
                        {
                            fn.Add(i);
                        }
                    }
                    for (int i = 0; i < fn.Count; i++)
                    {
                        int count = 0;
                        string result = "[" + fn[i] + "] - ";
                        int[] arr = new int[n];
                        for (int j = 0; j < arr.Length; j++)
                        {
                            arr[j] = (int)BigInteger.ModPow(fn[i], j, n);
                            if (arr[j] == 1)
                            {
                                count++;
                            }
                            result += arr[j].ToString() + " ";
                        }
                        if ((count == 2) && (arr[arr.Length - 1] == 1))
                        {
                            ComboRoot.Items.Add(" + " + result);
                        }
                        else
                        {
                            ComboRoot.Items.Add(" - " + result);
                        }
                    }
                    ComboRoot.Items.Add("Created by YKarlianok");
                }
                else
                {
                    MessageBox.Show("Первообразные корни отсутствуют");
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели N");
            }
        }
    }
}
