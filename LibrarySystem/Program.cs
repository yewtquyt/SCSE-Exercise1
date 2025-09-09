using System;
using LibrarySystem;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager library = new LibraryManager();

            library.AddItem(new Novel(1, "Harry Potter", "J.K.Rowling"));
            library.AddItem(new Magazine(2, "National Geographic", 202509));
            library.AddItem(new TextBook(3, "Head First Java", "Kathy Sierra & Bert Bates"));
            library.AddItem(new Novel(4, "Le Petit Prince", "Antoine de Saint-Exupéry"));

            Member alice = new Member("Alice");
            Member bob = new Member("Bob");

            library.RegisterMember(alice);
            library.RegisterMember(bob);
            library.ShowCatalog();

            Console.WriteLine("=== Alice's Borrowing Process ===");
            BorrowItemForMember(library, alice, 1);
            BorrowItemForMember(library, alice, 2);
            BorrowItemForMember(library, alice, 3);

            Console.WriteLine("\n--- Testing Alice's 4th Borrow ---");
            BorrowItemForMember(library, alice, 4);

            Console.WriteLine("\n=== Alice's Borrowed Items ===");
            foreach (var item in alice.GetBorrowedItems())
            {
                Console.WriteLine(item.GetDetails());
            }

            Console.WriteLine("\n=== Alice's Return Process ===");
            LibraryItem? itemToReturn = library.FindItemById(2);
            if (itemToReturn != null)
            {
                Console.WriteLine(alice.ReturnItem(itemToReturn));
            }

            Console.WriteLine("\n=== Alice's Borrowed Items (After Return) ===");
            foreach (var item in alice.GetBorrowedItems())
            {
                Console.WriteLine(item.GetDetails());
            }
        }

        static void BorrowItemForMember(LibraryManager library, Member member, int itemId)
        {
            LibraryItem? item = library.FindItemById(itemId);
            if (item != null)
            {
                Console.WriteLine(member.BorrowItem(item));
            }
            else
            {
                Console.WriteLine($"Item with ID {itemId} not found.");
            }
        }
    }
}