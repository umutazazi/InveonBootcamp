namespace APIBestPractices.DTOs
{
    public record CreateBookDto(string Title, string Author, DateTime PublishedDate, int PageCount);
   
}
