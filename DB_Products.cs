using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
	class DB_Products
	{
		public List<Book> db;

		public DB_Products()
		{
			db = SetBaseProducts();
		}

		private List<Book> SetBaseProducts()
		{
			List<Book> books = new List<Book>();
			Book book1 = new Book("Азбука", "Иванов", 799, Format.paper, 2012, Genre.study, PublishingHouse.kazan, 2012);
			Book book2 = new Book("Арифметика", "Александров", 699, Format.paper, 2010, Genre.study, PublishingHouse.kazan, 2010);
			Book book3 = new Book("Программирование на Swift", "Сакун", 1000, Format.pdf, 2020, Genre.study, PublishingHouse.spb, 2021);
			Book book4 = new Book("Гарри Поттер", "Роулинг", 1500, Format.doc, 1999, Genre.fantasy, PublishingHouse.new_era, 2010);
			Book book5 = new Book("Джек Потрошитель", "Народный автор", 2000, Format.fb2, 1899, Genre.horrors, PublishingHouse.shkolnik, 2000);
			Book book6 = new Book("Евгений Онегин", "Пушкин", 1500, Format.paper, 1830, Genre.novel, PublishingHouse.moscow, 2005);
			Book book7 = new Book("Учение о квантовых компьюетрах", "Подошведов", 5000, Format.pdf, 2017, Genre.science, PublishingHouse.moscow, 2018);
			Book book8 = new Book("Капитанская дочка", "Пушкин", 1000, Format.paper, 1836, Genre.novel, PublishingHouse.moscow, 2006);
			Book book9 = new Book("Кавказский пленник", "Пушкин", 1000, Format.pdf, 1821, Genre.novel, PublishingHouse.moscow, 2007);


			books.Add(book1);
			books.Add(book2);
			books.Add(book3);
			books.Add(book4);
			books.Add(book5);
			books.Add(book6);
			books.Add(book7);
			books.Add(book8);
			books.Add(book9);

			return books;
		}

		public void AddBook(List<Book> basedb, Book book)
		{
			basedb.Add(book);
		}
	}
}
