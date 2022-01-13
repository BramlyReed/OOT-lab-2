using System;
using System.Collections.Generic;

namespace BookStore
{
	class AuthorBooks
	{
		public String author;
		public List<Book> authorsPaperBooks;

		public AuthorBooks(String a)
		{
			author = a;
			authorsPaperBooks = new List<Book>();
		}
	}

	class TwoPaperAndOneElectronic : PromoInterface
	{
		public void applyPromo(Order order)
		{
			HashSet<String> groupOfAuthors = new HashSet<String>();
			List<AuthorBooks> array = new List<AuthorBooks>();

			foreach (Book book in order.books)
			{
				groupOfAuthors.Add(book.author);
			}

			foreach (String authorName in groupOfAuthors)
			{
				AuthorBooks tmp = new AuthorBooks(authorName);
				foreach (Book book in order.books)
				{
					if (book.author == authorName && book.type == Format.paper)
					{
						tmp.authorsPaperBooks.Add(book);
					}
				}
				array.Add(tmp);
			}

			foreach (AuthorBooks singleAuthor in array)
			{
				if (singleAuthor.authorsPaperBooks.Count > 1)
				{
					var singleBook = findBook(order.books, singleAuthor.author);
					if (singleBook != null)
					{
						order.discount += singleBook.price;
					}
					else
					{
						DB_Products baseDB = new DB_Products();
						singleBook = findBook(baseDB.db, singleAuthor.author);
						if (singleBook != null)
						{
							order.books.Add(singleBook);
						}
					}
				}
			}
		}

		private Book findBook(List<Book> books, String authorname)
		{
			foreach (Book book in books)
			{
				if (book.author == authorname && book.type != Format.paper)
				{
					return book;
				}
			}
			return null;
		}
	}
}
