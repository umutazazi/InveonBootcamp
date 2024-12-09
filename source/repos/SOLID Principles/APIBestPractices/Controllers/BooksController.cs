using APIBestPractices.DTOs;
using APIBestPractices.Models;
using APIBestPractices.Models.Interfaces;
using APIBestPractices.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIBestPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("page/{page}/pageSize/{pageSize}")]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetPage(int page , int pageSize,[FromServices] IRedisCacheService redisCacheService)
        {
            string cacheKey = $"books:page:{page}:pageSize:{pageSize}";
            var cachedData = await redisCacheService.GetValueAsync(cacheKey);
            if (!string.IsNullOrEmpty(cachedData))
            {
                // Cache'teki veriyi deserialization yap ve döndür
                var cachedBooks = JsonSerializer.Deserialize<List<BookDto>>(cachedData);
                return Ok(cachedBooks);
            }

            // Cache'te yoksa DB'den veriyi al
            var totalCount = BookRepository.books.Count;
            var totalPages = (int)Math.Ceiling((decimal)totalCount / pageSize);
            var booksPerPage = BookRepository.GetAllBookAsDto()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Yeni veriyi Redis'e ekle (örneğin, 1 saat süreyle sakla)
            var serializedData = JsonSerializer.Serialize(booksPerPage);
            await redisCacheService.SetValueAsync(cacheKey, serializedData);

            return Ok(booksPerPage);
        }
        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = BookRepository.GetAllBookAsDto();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var book = BookRepository.books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            var bookDto = new BookDto(book.Id, book.Title, book.Author,book.PublishedDate,book.PageCount);
            return Ok(bookDto);
        }
        [HttpPost]
        public ActionResult Create([FromBody] CreateBookDto createBookDto)
        {
            var newBook = new Book
            {
                Id = BookRepository.books.Max(b => b.Id) + 1,
                Title = createBookDto.Title,
                Author = createBookDto.Author,
                PublishedDate = createBookDto.PublishedDate,
                PageCount = createBookDto.PageCount
            };

            BookRepository.books.Add(newBook);

            var bookDto = new BookDto(newBook.Id, newBook.Title, newBook.Author, newBook.PublishedDate, newBook.PageCount);
            return StatusCode(201);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var book = BookRepository.books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            BookRepository.books.Remove(book);
            return Ok();
        }

    }
}
