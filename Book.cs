using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
	enum Format
	{
		paper,
		doc,
		pdf,
		fb2
	}

	enum Genre
	{
		novel,
		horrors,
		fairy_tales,
		science,
		study,
		fantasy
	}

	enum PublishingHouse
	{
		moscow,
		spb,
		kazan,
		new_era,
		shkolnik
	}

	class Book
	{
		public readonly string name;
		public readonly string author;
		public double price;
		public readonly Format type;
		public readonly uint yearOfCreation;
		public readonly Genre genre;
		public readonly PublishingHouse publishing;
		public readonly uint yearOfPublish;


		public Book(string name_value, string author_value, double price_value, Format typeBook, uint year, Genre genre_value, PublishingHouse publishing_value, uint yearPublish)
		{
			if (yearPublish < year)
			{
				Console.WriteLine("Год публикции издания не должен быть меньше года написания книги");
			}
			else
			{
				name = name_value;
				author = author_value;
				price = price_value;
				type = typeBook;
				yearOfCreation = year;
				genre = genre_value;
				publishing = publishing_value;
				yearOfPublish = yearPublish;
			}
		}

		public void ChangePrice(double newPrice)
		{
			if (newPrice != price)
			{
				price = newPrice;
			}
		}
	}
}