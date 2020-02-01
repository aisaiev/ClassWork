using Shop.Command;
using Shop.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Shop.ViewModel
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Item> items;

        private Item selectedItem;

        public ObservableCollection<Item> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                if (this.items == value)
                    return;
                this.items = value;
                this.OnPropertyChanged(nameof(this.Items));
            }
        }

        public Item SelectedItem
        {
            get
            {
                return this.selectedItem;
            }
            set
            {
                if (this.selectedItem == value)
                    return;
                this.selectedItem = value;
                this.OnPropertyChanged(nameof(this.selectedItem));
            }
        }

        public ICommand RemoveItemCommand { get; set; }

        public ICommand SetDefaultsCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ItemsViewModel()
        {
            this.Items = new ObservableCollection<Item>()
            {
                new Item("Pixel 4", "Google", "/Resources/pixel_4_black.jpg", 799, "USA", "Just Black", "Phone"),
                new Item("Pixelbook", "Google", "/Resources/pixelbook.jpg", 999, "USA", "White", "Laptop"),
                new Item("Pixel Slate", "Google", "/Resources/pixel_slate.jpg", 799, "USA", "Black", "Tablet"),
            };
            this.RemoveItemCommand = new RelayCommand(RemoveItemCommandExecuted, CommandCanExecute);
            this.SetDefaultsCommand = new RelayCommand(SetDefaultsCommandExecuted, CommandCanExecute);
        }

        private bool CommandCanExecute(object obj)
        {
            return !(this.SelectedItem is null);
        }

        private void RemoveItemCommandExecuted(object obj)
        {
            this.Items.Remove(this.SelectedItem);
        }

        private void SetDefaultsCommandExecuted(object obj)
        {
            this.selectedItem.Model = "N/A";
            this.selectedItem.Brand = "N/A";
            this.selectedItem.ImageUrl = "/Resources/default.jpg";
            this.selectedItem.Cost = 0;
            this.selectedItem.Country = "N/A";
            this.selectedItem.Color = "N/A";
            this.selectedItem.Type = "N/A";
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
            {
                return;
            }
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
