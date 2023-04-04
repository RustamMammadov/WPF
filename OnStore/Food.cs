using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnStore
{
    public class Food : INotifyPropertyChanged
    {
        //public string Picture { get; set; }  = string.Empty;
        //public string Name { get; set; } = string.Empty;
        //public double Price { get; set; } = 0;

        private string picture = string.Empty;
        private string name = string.Empty;
        private double price = 0;

        public string Picture { get => picture; set { picture = value; PropertyChanging(); } }
        public string Name { get => name; set { name = value; PropertyChanging(); } }
        public double Price { get => price; set { price = value; PropertyChanging(); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void PropertyChanging([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
