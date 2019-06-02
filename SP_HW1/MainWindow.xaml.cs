using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SP_HW1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
            List<Classes.Proc> proc = new List<Classes.Proc>();
            foreach (Process process in Process.GetProcesses())
            {
                proc.Add(new Classes.Proc
                {
                    Name = process.ProcessName + ".exe",
                    Id = process.Id,
                    Status = "Выполняется",
                    UserName = process.MainWindowTitle,
                    CPU = "Недоступно",
                    Memory = process.PagedSystemMemorySize64,
                    Virtualization = "Недоступно"
                });
            }           
            MyDGrid.ItemsSource = proc;

            MessageBox.Show("Используте вкладку Подробности");
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            if (MyDGrid.SelectedItem != null)
            {
                int index = MyDGrid.SelectedIndex;
                try
                {
                    MessageBox.Show("Вы собираетесь остановить выполнение адекватно функционирующего приложения. Вы уверенны?");
                    procList[index].Kill();
                }
                catch (Exception)
                {
                    MessageBox.Show("Отказано в доступе");
                }
            }
        }
    }
}
