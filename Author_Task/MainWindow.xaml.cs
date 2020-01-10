using Author_Task.Model;
using Author_Task.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Author_Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Author> authors;

        public MainWindow()
        {
            InitializeComponent();
            this.authors = new ObservableCollection<Author>();
            this.AuthorsListView.ItemsSource = this.authors;
        }

        private void CoreCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is Button)
            {
                Button button = e.Source as Button;
                switch (button.Name)
                {
                    case "NewAuthorButton":
                        this.CreateAuthor();
                        Debug.WriteLine("NewAuthorButton clicked");
                        break;
                    case "NewBookButton":
                        this.CreateBook();
                        Debug.WriteLine("NewBookButton clicked");
                        break;
                    case "ChangeAuthorButton":
                        this.ChangeAuthor();
                        Debug.WriteLine("ChangeAuthorButton clicked");
                        break;
                    case "ChangeBookButton":
                        this.ChangeBook();
                        Debug.WriteLine("ChangeBookButton clicked");
                        break;
                    case "DeleteAuthorButton":
                        this.DeleteAuthor();
                        Debug.WriteLine("DeleteAuthorButton clicked");
                        break;
                    case "DeleteBookButton":
                        this.DeleteBook();
                        Debug.WriteLine("DeleteBookButton clicked");
                        break;
                }
            }
            else if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "NewAuthorMenuItem":
                        this.CreateAuthor();
                        Debug.WriteLine("NewAuthorMenuItem clicked");
                        break;
                    case "NewBookMenuItem":
                        this.CreateBook();
                        Debug.WriteLine("NewBookMenuItem clicked");
                        break;
                    case "ChangeAuthorMenuItem":
                        this.ChangeAuthor();
                        Debug.WriteLine("ChangeAuthorMenuItem clicked");
                        break;
                    case "ChangeBookMenuItem":
                        this.ChangeBook();
                        Debug.WriteLine("ChangeBookMenuItem clicked");
                        break;
                    case "DeleteAuthorMenuItem":
                        this.DeleteAuthor();
                        Debug.WriteLine("DeleteAuthorMenuItem clicked");
                        break;
                    case "DeleteBookMenuItem":
                        this.DeleteBook();
                        Debug.WriteLine("DeleteBookMenuItem clicked");
                        break;
                }
            }
        }

        private void CoreCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Source is Button)
            {
                Button button = e.Source as Button;
                switch (button.Name)
                {
                    case "NewAuthorButton":
                        e.CanExecute = true;
                        break;
                    case "NewBookButton":
                    case "ChangeAuthorButton":
                    case "DeleteAuthorButton":
                        if (this.AuthorsListView.SelectedItem != null)
                        {
                            e.CanExecute = true;
                        }
                        else
                        {
                            e.CanExecute = false;
                        }
                        break;
                    case "ChangeBookButton":
                    case "DeleteBookButton":
                        if (this.BooksDataGrid.SelectedItem != null)
                        {
                            e.CanExecute = true;
                        }
                        else
                        {
                            e.CanExecute = false;
                        }
                        break;
                }
            }
            else if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "NewAuthorMenuItem":
                        e.CanExecute = true;
                        break;
                    case "NewBookMenuItem":
                    case "ChangeAuthorMenuItem":
                    case "DeleteAuthorMenuItem":
                        if (this.AuthorsListView.SelectedItem != null)
                        {
                            e.CanExecute = true;
                        }
                        else
                        {
                            e.CanExecute = false;
                        }
                        break;
                    case "ChangeBookMenuItem":
                    case "DeleteBookMenuItem":
                        if (this.BooksDataGrid.SelectedItem != null)
                        {
                            e.CanExecute = true;
                        }
                        else
                        {
                            e.CanExecute = false;
                        }
                        break;
                }
            }
        }

        private void ShowAuthorWindow(string title, Author author)
        {
            AuthorWindow authorWindow = new AuthorWindow() { Title = title, DataContext = author };
            if (authorWindow.ShowDialog().Value)
            {
                Author authorResult = authorWindow.DataContext as Author;
                if (author.IsNew)
                {
                    this.authors.Add(authorResult);
                }
                else
                {
                    Author searchedAuthor = this.authors.First(a => a.Id == author.Id);
                    int authorIndex = this.authors.IndexOf(searchedAuthor);
                    this.authors[authorIndex] = authorResult;
                    this.AuthorsListView.Items.Refresh();
                }
            }
        }

        private void ShowBookWindow(string title, Book book)
        {
            BookWindow bookWindow = new BookWindow() { Title = title, DataContext = book };
            if (bookWindow.ShowDialog().Value)
            {
                Book bookResult = bookWindow.DataContext as Book;
                Author selectedAuthor = this.AuthorsListView.SelectedItem as Author;
                Author searchedAuthor = this.authors.First(a => a.Id == selectedAuthor.Id);
                int authorIndex = this.authors.IndexOf(searchedAuthor);
                if (book.IsNew)
                {
                    this.authors[authorIndex].Books.Add(bookResult);
                }
                else
                {
                    Book selectedBook = this.BooksDataGrid.SelectedItem as Book;
                    Book searchedBook = this.authors[authorIndex].Books.First(b => b.Id == selectedBook.Id);
                    int bookIndex = this.authors[authorIndex].Books.IndexOf(searchedBook);
                    this.authors[authorIndex].Books[bookIndex] = bookResult;
                }
            }
        }

        private void CreateAuthor()
        {
            Author author = new Author();
            this.ShowAuthorWindow("New Author", author);
        }

        private void CreateBook()
        {
            Book book = new Book();
            this.ShowBookWindow("New Book", book);
        }

        private void ChangeAuthor()
        {
            Author selectedAuthor = this.AuthorsListView.SelectedItem as Author;
            Author author = selectedAuthor.Clone() as Author;
            author.IsNew = false;
            this.ShowAuthorWindow("Edit Author", author);
        }

        private void ChangeBook()
        {
            Book selectedBook = this.BooksDataGrid.SelectedItem as Book;
            Book book = selectedBook.Clone() as Book;
            book.IsNew = false;
            this.ShowBookWindow("Edit Book", book);
        }

        private void DeleteAuthor()
        {
            Author authorToRemove = this.AuthorsListView.SelectedItem as Author;
            this.authors.Remove(authorToRemove);
        }

        private void DeleteBook()
        {
            Book bookToRemove = this.BooksDataGrid.SelectedItem as Book;
            Author selectedAuthor = this.AuthorsListView.SelectedItem as Author;
            Author searchedAuthor = this.authors.First(a => a.Id == selectedAuthor.Id);
            int authorIndex = this.authors.IndexOf(searchedAuthor);
            this.authors[authorIndex].Books.Remove(bookToRemove);
        }
    }
}
