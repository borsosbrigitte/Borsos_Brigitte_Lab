

namespace Borsos_Brigitte_Lab2.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publishers Publisher { get; set; }
        public Book Book { get; set; }
    }
}
