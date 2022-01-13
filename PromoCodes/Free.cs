using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.PromoCodes
{
	class Free: PromoCodeInterface
	{
		Book book;
		public Free(Book book)
		{
			this.book = book;
		}
		public void applyPromoCode(Order order)
		{
			if (order.books.Contains(book))
			{
				order.discount += book.price;
			}
		}
	}

	class FreeDelivery: PromoCodeInterface
	{
		public void applyPromoCode(Order order)
		{
			order.delivery = 0;
		}
	}
}
