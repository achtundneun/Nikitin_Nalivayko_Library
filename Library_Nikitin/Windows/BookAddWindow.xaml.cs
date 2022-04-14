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
using Library_Nikitin.EF;
using Library_Nikitin.ClassHelper;

namespace Library_Nikitin.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookAddWindow.xaml
    /// </summary>
    public partial class BookAddWindow : Window
    {
        EF.Book editBook = new EF.Book();

        bool isEdit = true;

        public BookAddWindow()
        {
            InitializeComponent();

            //cmbSelection.ItemsSource = AppData.Context.Selection.ToList();
            //cmbSelection.DisplayMemberPath = "NameSelection";
            //cmbSelection.SelectedIndex = 0;

            //cmbPublishHouse.ItemsSource = AppData.Context.PublishHouse.ToList();
            //cmbPublishHouse.DisplayMemberPath = "NamePublishHouse";
            //cmbPublishHouse.SelectedIndex = 0;

            cmbLastNameAuthor.ItemsSource = AppData.Context.Author.ToList();
            cmbLastNameAuthor.DisplayMemberPath = "LastName";
            cmbLastNameAuthor.SelectedIndex = 0;

            cmbFirstNameAuthor.ItemsSource = AppData.Context.Author.ToList();
            cmbFirstNameAuthor.DisplayMemberPath = "FirstName";
            cmbFirstNameAuthor.SelectedIndex = 0;
            isEdit = false;
        }

        public BookAddWindow(EF.Book book)
        {
            InitializeComponent();

            editBook = book;
            //add combobox
            //cmbSelection.ItemsSource = AppData.Context.Selection.ToList();
            //cmbSelection.DisplayMemberPath = "NameSelection";

            //cmbPublishHouse.ItemsSource = AppData.Context.PublishHouse.ToList();
            //cmbPublishHouse.DisplayMemberPath = "NamePublishHouse";

            cmbLastNameAuthor.ItemsSource = AppData.Context.Author.ToList();
            cmbLastNameAuthor.DisplayMemberPath = "LastName";

            cmbFirstNameAuthor.ItemsSource = AppData.Context.Author.ToList();
            cmbFirstNameAuthor.DisplayMemberPath = "FirstName";

            //edit Title and content into button
            tbTitle.Text = "Изменения данных о книге";
            btnAddBook.Content = "Изменить";

            //get value
            txtTitle.Text = editBook.TitleBook;
            cmbLastNameAuthor.SelectedIndex = editBook.IdAuthor - 1;
            cmbFirstNameAuthor.SelectedIndex = editBook.IdAuthor - 1;
            //cmbSelection.SelectedIndex = editBook.IdSection - 1;
            //cmbPublishHouse.SelectedIndex = editBook.IdPublishHouse;

            isEdit = true;
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            //Валидация
            #region
            //Проверка на пустоту
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Поле «Название книги» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //Проверка на количество символов
            if (txtTitle.Text.Length > 100)
            {
                MessageBox.Show("В поле «Название книги» недопустимое количество символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            #endregion


            if (isEdit)
            {
                try
                {
                    editBook.TitleBook = txtTitle.Text;
                    editBook.IdAuthor = cmbLastNameAuthor.SelectedIndex + 1;
                    editBook.IdAuthor = cmbFirstNameAuthor.SelectedIndex + 1;
                    //editBook.IDSection = cmbSelection.SelectedIndex + 1;
                    //editBook.IDPublishHouse = cmbPublishHouse.SelectedIndex + 1;

                    AppData.Context.SaveChanges();
                    MessageBox.Show("Информация о книге успешно изменена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                //Проверка на ошибки в БД
                try
                {
                    var resultClick = MessageBox.Show("Вы уверены?", "Подтвердите добавление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (resultClick == MessageBoxResult.Yes)
                    {
                        //Добавление нового читателя
                        EF.Book book = new EF.Book();
                        book.TitleBook = txtTitle.Text;
                        book.IdAuthor = cmbLastNameAuthor.SelectedIndex + 1;
                        book.IdAuthor = cmbFirstNameAuthor.SelectedIndex + 1;
                        //book.IDSection = cmbSelection.SelectedIndex + 1;
                        //book.IDPublishHouse = cmbPublishHouse.SelectedIndex + 1;

                        AppData.Context.Book.Add(book);
                        AppData.Context.SaveChanges();
                        MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}