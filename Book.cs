using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP2
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
		public string name { get; }
		public string author { get; }
		public double price;
		public Format type { get; }
		public DateTime yearOfCreation { get; }
		public Genre genre { get; }
		public PublishingHouse publishing { get; }


		public Book(string name_value, string author_value, double price_value, Format typeBook, DateTime year, Genre genre_value, PublishingHouse publishing_value)
		{
			name = name_value;
			author = author_value;
			price = price_value;
			type = typeBook;
			yearOfCreation = year;
			genre = genre_value;
			publishing = publishing_value;
		}
	}
}