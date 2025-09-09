using System;
using System.Collections.Generic;
using System.Linq;
using LibrarySystem; 

namespace LibrarySystem 
{
    public class LibraryManager
    {
        private readonly List<LibraryItem> _catalog = new List<LibraryItem>();
        private readonly List<Member> _members = new List<Member>();

        public void AddItem(LibraryItem item)
        {
            _catalog.Add(item);
        }

        public void RegisterMember(Member member)
        {
            _members.Add(member);
        }

        public void ShowCatalog()
        {
            Console.WriteLine("\n=== Library Catalog ===");
            if (_catalog.Count == 0)
            {
                Console.WriteLine("No items in catalog.");
                return;
            }

            foreach (var item in _catalog)
            {
                Console.WriteLine(item.GetDetails());
            }
            Console.WriteLine("======================\n");
        }

        public LibraryItem? FindItemById(int id) => _catalog.Find(i => i.Id == id);

        public Member? FindMemberByName(string name) => _members.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}