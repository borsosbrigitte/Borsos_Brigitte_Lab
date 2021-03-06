
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Borsos_Brigitte_Lab2.Models
{
    public class Book
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }

        public ICollection<PublishedBook> PublishedBooks { get; set; }
    }
}
