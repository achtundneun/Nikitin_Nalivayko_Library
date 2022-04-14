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
using Library_Nikitin.ClassHelper;
using Library_Nikitin.EF;

namespace Library_Nikitin.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserListWindow.xaml
    /// </summary>
    public partial class UserListWindow : Window
    {

        List<Reader> readerList = new List<Reader>();

        List<string> listSort = new List<string>() { "По умолчанию", "По фамилии", "По имени", "По адресу" };
        public UserListWindow()
        {
            InitializeComponent();

            cmbSort.ItemsSource = listSort;
            cmbSort.SelectedIndex = 0;

            Filter();
        }

        private void Filter()
        {
            readerList = AppData.Context.Reader.ToList();
            readerList = readerList.
                Where(i => i.LastName.ToLower().Contains(txtSearch.Text.ToLower())
                || i.FirstName.ToLower().Contains(txtSearch.Text.ToLower()))
                .ToList();


            switch (cmbSort.SelectedIndex)
            {
                case 0:
                    readerList = readerList.OrderBy(i => i.Id).ToList();
                    break;

                case 1:
                    readerList = readerList.OrderBy(i => i.LastName).ToList();
                    break;

                case 2:
                    readerList = readerList.OrderBy(i => i.FirstName).ToList();
                    break;

                case 3:
                    readerList = readerList.OrderBy(i => i.Address).ToList();
                    break;

                default:
                    readerList = readerList.OrderBy(i => i.Id).ToList();
                    break;
            }

            lvReader.ItemsSource = readerList;
        }

        private void btnAddReader_Click(object sender, RoutedEventArgs e)
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow();
            this.Opacity = 0.2;
            addReaderWindow.ShowDialog();
            lvReader.ItemsSource = AppData.Context.Reader.ToList();
            this.Opacity = 1;

        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void lvReader_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Delete || e.Key == System.Windows.Input.Key.Back)
            {
                if (lvReader.SelectedItem is EF.Reader && lvReader.SelectedIndex != -1)
                {
                    try
                    {
                        var item = lvReader.SelectedItem as EF.Reader;
                        var resultClick = MessageBox.Show("Вы уверены?", "Подтверите Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (resultClick == MessageBoxResult.Yes)
                        {
                            AppData.Context.Reader.Remove(item);
                            AppData.Context.SaveChanges();
                            MessageBox.Show("Пользователь успешно удален", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                            Filter();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

            }

        }

        private void lvReader_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var editReader = new EF.Reader();

            if (lvReader.SelectedItem is EF.Reader)
            {
                editReader = lvReader.SelectedItem as EF.Reader;
            }

            AddReaderWindow addReaderWindow = new AddReaderWindow(editReader);
            this.Opacity = 0.2;
            addReaderWindow.ShowDialog();
            lvReader.ItemsSource = AppData.Context.Reader.ToList();
            this.Opacity = 1;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
