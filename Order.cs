using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
	class Order
	{
		public List<Book> books;
		public double cost;
		public double discount;
		public double delivery;

		public Order(List<Book> list)
		{
			books = list;
			foreach (Book book in books)
			{
				cost += book.price;
				
			}
		}
	}
}
