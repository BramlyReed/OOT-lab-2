using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
	class Order
	{
		public List<Book> books;
		public readonly double cost;
		public double discount;
		public double delivery;
		public double finalSum => (cost - discount + delivery);

		public Order(List<Book> list)
		{
			books = list;
			foreach (Book book in books)
			{
				cost += book.price;
				discount = 0;
			}
			delivery = checkConditions();
		}

		private double checkConditions()
		{
			double paperBooksCost = 0;
			foreach (Book book in books)
			{
				if (book.type == Format.paper)
				{
					paperBooksCost += book.price;
				}
			}
			if (paperBooksCost < 1000)
			{
				return 200;
			}
			return 0;
		}
	}
}
