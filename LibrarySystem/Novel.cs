namespace LibrarySystem
{
    public class Novel : LibraryItem
    {
        private readonly string _author;
        public string Author => _author;
        public Novel(int id, string title, string author) 
            : base(id, title, ItemType.Novels)
        {
            _author = author;
        }

        public override string GetDetails()
        {
            return $"Novel - Title: {Title}, Author: {Author}, ID: {Id}";
        }
    }
}