using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.PromoCodes
{
	class FreeBook: PromoCodeInterface
	{
		Book book;
		public FreeBook(Book book)
		{
			this.book = book;
		}
		public void applyPromoCode(Order order)
		{

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
