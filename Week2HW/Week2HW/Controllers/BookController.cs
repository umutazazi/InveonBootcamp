using Microsoft.AspNetCore.Mvc;
using Week2HW.Models.Repositories;

namespace Week2HW.Controllers
{
    public class BookController(IUnitOfWork unitOfWork) : Controller
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _unitOfWork.Books.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest("Book cannot be null.");
            }

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CompleteAsync();
            return Ok("Book added successfully.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound("Book not found.");
            }

            await _unitOfWork.Books.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
            return Ok("Book deleted successfully.");
        }


    }
}
