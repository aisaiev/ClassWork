using System.ComponentModel;

namespace Shop.Model
{
    public class Item : INotifyPropertyChanged
    {
        private string model;

        private string brand;

        private string imageUrl;

        private decimal cost;

        private string country;

        private string color;

        private string type;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (this.model == value)
                    return;
                this.model = value;
                this.OnPropertyChanged(nameof(this.Model));
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (this.brand == value)
                    return;
                this.brand = value;
                this.OnPropertyChanged(nameof(this.Brand));
            }
        }

        public string ImageUrl
        {
            get
            {
                return this.imageUrl;
            }
            set
            {
                if (this.imageUrl == value)
                    return;
                this.imageUrl = value;
                this.OnPropertyChanged(nameof(this.ImageUrl));
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (this.cost == value)
                    return;
                this.cost = value;
                this.OnPropertyChanged(nameof(this.Cost));
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (this.country == value)
                    return;
                this.country = value;
                this.OnPropertyChanged(nameof(this.Country));
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (this.color == value)
                    return;
                this.color = value;
                this.OnPropertyChanged(nameof(this.Color));
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (this.type == value)
                    return;
                this.type = value;
                this.OnPropertyChanged(nameof(this.Type));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Item(string model, string brand, string imageUrl, decimal cost, string country, string color, string type)
        {
            this.Model = model;
            this.Brand = brand;
            this.ImageUrl = imageUrl;
            this.Cost = cost;
            this.Country = country;
            this.Color = color;
            this.Type = type;
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
