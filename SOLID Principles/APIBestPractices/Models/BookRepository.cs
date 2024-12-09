using APIBestPractices.DTOs;
using static System.Reflection.Metadata.BlobBuilder;

namespace APIBestPractices.Models
{
    public static class BookRepository
    {
        public static List<Book> books = new List<Book>()
        {
            new Book{Id= 1, Title="Nutuk", Author="M. Kemal Atatürk", PublishedDate=new DateTime(1927,1,1), PageCount=400},
            new Book{Id=2, Title="Savaş ve Barış", Author="Lev Tolstoy", PublishedDate=new DateTime(1869,1,1), PageCount=1225},
new Book{Id=3, Title="1984", Author="George Orwell", PublishedDate=new DateTime(1949,6,8), PageCount=328},
new Book{Id=4, Title="Kürk Mantolu Madonna", Author="Sabahattin Ali", PublishedDate=new DateTime(1943,1,1), PageCount=177},
new Book{Id=5, Title="Yeraltından Notlar", Author="Fyodor Dostoyevski", PublishedDate=new DateTime(1864,1,1), PageCount=128},
new Book{Id=6, Title="Beyaz Diş", Author="Jack London", PublishedDate=new DateTime(1906,1,1), PageCount=270},
new Book{Id=7, Title="Don Kişot", Author="Miguel de Cervantes", PublishedDate=new DateTime(1615,1,1), PageCount=1072},
new Book{Id=8, Title="Suç ve Ceza", Author="Fyodor Dostoyevski", PublishedDate=new DateTime(1866,1,1), PageCount=671},
new Book{Id=9, Title="Küçük Prens", Author="Antoine de Saint-Exupéry", PublishedDate=new DateTime(1943,4,6), PageCount=96},
new Book{Id=10, Title="Harry Potter ve Felsefe Taşı", Author="J.K. Rowling", PublishedDate=new DateTime(1997,6,26), PageCount=223},
new Book{Id=11, Title="Zamanın Kısa Tarihi", Author="Stephen Hawking", PublishedDate=new DateTime(1988,1,1), PageCount=256},
new Book{Id=12, Title="Şeker Portakalı", Author="José Mauro de Vasconcelos", PublishedDate=new DateTime(1968,1,1), PageCount=182},
new Book{Id=13, Title="Aşk ve Gurur", Author="Jane Austen", PublishedDate=new DateTime(1813,1,1), PageCount=432},
new Book{Id=14, Title="Olasılıksız", Author="Adam Fawer", PublishedDate=new DateTime(2005,1,1), PageCount=392},
new Book{Id=15, Title="Simyacı", Author="Paulo Coelho", PublishedDate=new DateTime(1988,1,1), PageCount=208},
new Book{Id=16, Title="Monte Cristo Kontu", Author="Alexandre Dumas", PublishedDate=new DateTime(1844,1,1), PageCount=1243},
new Book{Id=17, Title="Dune", Author="Frank Herbert", PublishedDate=new DateTime(1965,1,1), PageCount=412},
new Book{Id=18, Title="Hayvan Çiftliği", Author="George Orwell", PublishedDate=new DateTime(1945,8,17), PageCount=112},
new Book{Id=19, Title="Ben Robot", Author="Isaac Asimov", PublishedDate=new DateTime(1950,12,2), PageCount=224},
new Book{Id=20, Title="Vadideki Zambak", Author="Honoré de Balzac", PublishedDate=new DateTime(1835,1,1), PageCount=472},
new Book{Id=21, Title="Yüzüklerin Efendisi: Yüzük Kardeşliği", Author="J.R.R. Tolkien", PublishedDate=new DateTime(1954,7,29), PageCount=423},
new Book{Id=22, Title="Frankenstein", Author="Mary Shelley", PublishedDate=new DateTime(1818,1,1), PageCount=280},
new Book{Id=23, Title="Drakula", Author="Bram Stoker", PublishedDate=new DateTime(1897,1,1), PageCount=418},
new Book{Id=24, Title="Çalıkuşu", Author="Reşat Nuri Güntekin", PublishedDate=new DateTime(1922,1,1), PageCount=411},
new Book{Id=25, Title="Binbir Gece Masalları", Author="Anonim", PublishedDate=new DateTime(1706,1,1), PageCount=720},
new Book{Id=26, Title="Bülbülü Öldürmek", Author="Harper Lee", PublishedDate=new DateTime(1960,7,11), PageCount=281},
new Book{Id=27, Title="Anna Karenina", Author="Lev Tolstoy", PublishedDate=new DateTime(1877,1,1), PageCount=864},
new Book{Id=28, Title="Satranç", Author="Stefan Zweig", PublishedDate=new DateTime(1942,1,1), PageCount=104},
new Book{Id=29, Title="Karamazov Kardeşler", Author="Fyodor Dostoyevski", PublishedDate=new DateTime(1880,1,1), PageCount=824},
new Book{Id=30, Title="Mülksüzler", Author="Ursula K. Le Guin", PublishedDate=new DateTime(1974,1,1), PageCount=336},
new Book{Id=31, Title="Sefiller", Author="Victor Hugo", PublishedDate=new DateTime(1862,1,1), PageCount=1232},



        };

        public static List<BookDto> GetAllBookAsDto()
        {
            return books.Select(book => new BookDto(book.Id,
                                                book.Title,
                                                book.Author,
                                                book.PublishedDate,
                                                book.PageCount)).ToList();
        }
    }
}
