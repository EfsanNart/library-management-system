namespace LibraryManagementSystem.Models.ViewModels
{
    public class BookListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
