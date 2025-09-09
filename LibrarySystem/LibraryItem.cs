using System;

namespace LibrarySystem
{
    public enum ItemType
    {
        Novels,
        Magazine,
        TextBook
    }

    public abstract class LibraryItem
    {
        private readonly int _id;
        private readonly string _title;
        private readonly ItemType _itemType;

        public int Id => _id;
        public string Title => _title;
        public ItemType ItemType => _itemType;

        public LibraryItem(int id, string title, ItemType itemType)
        {
            _id = id;
            _title = title;
            _itemType = itemType;
        }

        public abstract string GetDetails();
    }
}