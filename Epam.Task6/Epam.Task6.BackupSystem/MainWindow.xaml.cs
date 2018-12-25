using System;
using System.Windows;
using System.Windows.Forms;

namespace Epam.Task6.BackupSystem
{
    /// <summary>
    ///     Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.WatherMode.Checked += (a, b) => this.HideRestore(Visibility.Hidden);
            this.RestoreMode.Checked += (a, b) => this.HideRestore(Visibility.Visible);
            this.WatherMode.Visibility = Visibility.Hidden;
            this.HideRestore(Visibility.Hidden);
            this.Closed += (a, b) => Control.Save();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (System.Windows.Forms.DialogResult.OK == dialog.ShowDialog())
            {
                folder.Visibility = Visibility.Hidden;
                this.WatherMode.Visibility = Visibility.Visible;
                this.HideRestore(Visibility.Visible);
                Control.Start(dialog.SelectedPath);
                this.WatherMode.Click += (a, b) => Control.Watch();
                this.RestoreMode.Click += (a, b) => Control.DoNotWatch();
            }
            else
            {
                this.RestoreMode.IsChecked = true;
                this.WatherMode.Visibility = Visibility.Hidden;
            }
        }

        private void HideRestore(Visibility visibility)
        {
            Restore.Visibility = visibility;
            MyDate.Visibility = visibility;
            MyTime.Visibility = visibility;
        }

        private void Restore_Click(object sender, RoutedEventArgs e)
        {
            if (MyDate.SelectedDate != null)
            {
                var temp = (DateTime)MyDate.SelectedDate;
                if (MyTime.Value != null)
                {
                    var temp2 = MyTime.Value.Value;
                    temp = temp.AddHours(temp2.Hour).AddMinutes(temp2.Minute).AddSeconds(temp2.Second);
                }

                Control.Restore(temp);
            }
        }
    }
}