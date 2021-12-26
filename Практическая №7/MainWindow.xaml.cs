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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая__7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void IncreaseBy1_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(DateDay.Text) > 31 || int.Parse(DateMonth.Text) > 12 || int.Parse(DateDay.Text) < 0 || int.Parse(DateMonth.Text) < 0 || int.Parse(DateYear.Text) < 0)
            {
                MessageBox.Show("Дата указана некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Date date = new Date(int.Parse(DateDay.Text), int.Parse(DateMonth.Text), int.Parse(DateYear.Text));
                Date result = date + 1;
                DateDay.Text = result.Day.ToString();
                DateMonth.Text = result.Month.ToString();
                DateYear.Text = result.Year.ToString();
            }
        }

        private void AddDays_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(DateDay.Text) < 0)
            {
                MessageBox.Show("Количество дней не может быть отрицательным числом!", "Ошибка");
            }
            else
            {
                Date date = new Date(int.Parse(DateDay.Text), int.Parse(DateMonth.Text), int.Parse(DateYear.Text));
                Date result = date.AddDays(int.Parse(dayQuantity.Text));
                DateDay.Text = result.Day.ToString();
                DateMonth.Text = result.Month.ToString();
                DateYear.Text = result.Year.ToString();
            }
        }

        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Использовать класс Triad (тройка чисел). Определить производный класс Date с полями: год, месяц и день. " +
             "Переопределить методы увеличения полей на 1 и определить метод увеличения даты на n дней.", "Задание");
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
