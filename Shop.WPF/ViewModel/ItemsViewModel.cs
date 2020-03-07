using Shop.DAL.Model;
using Shop.DAL.Repository;
using Shop.WPF.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Shop.WPF.ViewModel
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Item> items;

        private Item selectedItem;

        private UnitOfWork unitOfWork;

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

        public UnitOfWork UnitOfWork
        {
            get
            {
                return this.unitOfWork;
            }
            set
            {
                this.unitOfWork = value;
            }
        }

        public ICommand AddItemCommand { get; set; }

        public ICommand UpdateItemCommand { get; set; }

        public ICommand RemoveItemCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ItemsViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                return;
            }
            this.UnitOfWork = new UnitOfWork();
            this.AddItemCommand = new RelayCommand(AddItemCommandExecuted, AddItemCommandCanExecute);
            this.UpdateItemCommand = new RelayCommand(UpdateItemCommandExecuted, CommandCanExecute);
            this.RemoveItemCommand = new RelayCommand(RemoveItemCommandExecuted, CommandCanExecute);
            this.GetAllItems();
        }

        private void AddItemCommandExecuted(object obj)
        {
            Item item = new Item();
            this.UnitOfWork.ItemRepository.Add(item);
            this.UnitOfWork.Save();
            this.items.Add(item);
        }

        private bool AddItemCommandCanExecute(object obj)
        {
            return true;
        }

        private void UpdateItemCommandExecuted(object obj)
        {
            this.UnitOfWork.ItemRepository.Update(this.SelectedItem);
            this.UnitOfWork.Save();
        }

        private void RemoveItemCommandExecuted(object obj)
        {
            this.UnitOfWork.ItemRepository.Delete(this.SelectedItem);
            this.UnitOfWork.Save();
            this.Items.Remove(this.SelectedItem);
        }

        private bool CommandCanExecute(object obj)
        {
            return !(this.SelectedItem is null);
        }

        private void GetAllItems()
        {
            this.Items = new ObservableCollection<Item>(this.UnitOfWork.ItemRepository.Get().ToList());
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
