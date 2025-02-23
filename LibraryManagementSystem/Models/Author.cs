namespace LibraryManagementSystem.Models
{
    public class Author
    {
        public Author()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
