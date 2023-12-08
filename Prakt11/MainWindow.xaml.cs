using System.Text.RegularExpressions;
using System.Windows;

namespace Prakt11
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

        private void btnRegexFirst_Click(object sender, RoutedEventArgs e) // Искать совпадения в 1-й строке
        {
            Regex regex = new Regex("ab+a");
            string s = tbStringFirst.Text;
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                listBoxResultFirst.ItemsSource = mas;
            }
            else MessageBox.Show("Совпадений не найдено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnRegexSecond_Click(object sender, RoutedEventArgs e) // Искать совпадения во 2-й строке
        {
            Regex regex = new Regex(@"2\+*3");
            string s = tbStringSecond.Text;
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                listBoxResultSecond.ItemsSource = mas;
            }
            else MessageBox.Show("Совпадений не найдено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void miInfo_Click(object sender, RoutedEventArgs e) // О программе
        {
            MessageBox.Show("Практическая работа №11\n" +
                "Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, которое найдет строки aba, abba, abbba.\n" +
                "Дана строка '23 2+3 2++3 2+++3 445 677'. Напишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные.",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void miExit_Click(object sender, RoutedEventArgs e) // Выход
        {
            this.Close();
        }
    }
}