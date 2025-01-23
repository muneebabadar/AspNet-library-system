namespace LibraryManagementSystem.Domain;

public class Author : BaseModel
{
    // DO NOT MODIFY ABOVE THIS LINE
    public string? Name { get; set; } 
    // public ICollection<Book> Books { get; set; } = new List<Book>();
    public ICollection<Book>? Books { get; set; }
    // An author may have written multiple books.
    // This will make the relationship between Book and Author many-to-many
    
    // DO NOT MODIFY BELOW THIS LINE

    public string BooksToString()
    {
        // DO NOT MODIFY ABOVE THIS LINE
        // This method should return a string with the names of the books of the author separated by commas
        // If the author has multiple books, the names should be separated by commas and the last name should be preceded by 'and'
        // If the author has only one book, the name should be returned as is
        // If the author has no books, an empty string should be returned
        if (Books == null || !Books.Any())
        {
            return string.Empty;
        }
        // Extract book titles
        var bookTitles = Books.Select(book => book.Title).ToList();
        if (bookTitles.Count() == 1)
        {
            return bookTitles[0];
        }

        // If multiple books, format them with commas and 'and'
        var allExceptLast = bookTitles.Take(bookTitles.Count - 1);
        var lastBook = bookTitles.Last();

        return $"{string.Join(", ", allExceptLast)} and {lastBook}";
        // DO NOT MODIFY BELOW THIS LINE
    }
}