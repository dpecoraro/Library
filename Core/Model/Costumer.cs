using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Model
{
    public class Costumer
    {
        public long Id { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
        ErrorMessage = "Check the Costumer CPF.")]
        public string CPF { get; set; }

        public DateTime BirthDate { get; set; }

        public bool AllowStorageData { get; set; }

        public IList<Book> Books { get; set; }
    }
}
