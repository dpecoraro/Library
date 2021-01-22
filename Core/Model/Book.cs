using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Book
    {
        public long Id { get; set; }

        public double Price { get; set; }

        public Costumer Costumer { get; set; }

        public DateTime? SalesDate { get; set; }

        public DateTime? EntryDate { get; set; }

        private string _name;

        private string _author;

        private string _barCode;

        public string Name
        {
            get => _name;
            set => _name = value?.Trim();
        }

        public string Author
        {
            get => _author;
            set => _author = value?.Trim();
        }

        public string BarCode
        {
            get => _barCode;
            set => _barCode = value?.Trim().ToUpper();
        }
       
    }
}
