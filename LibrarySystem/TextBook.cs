namespace LibrarySystem
{
    public class TextBook : LibraryItem
    {
        private readonly string _publisher;
        public string Publisher => _publisher;
        public TextBook(int id, string title, string publisher) 
            : base(id, title, ItemType.TextBook)
        {
            _publisher = publisher;
        }
        public override string GetDetails()
        {
            return $"TextBook - Title: {Title}, Publisher: {Publisher}, ID: {Id}";
        }
    }
}