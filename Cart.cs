using System;
using System.Collections.Generic;

namespace BookStore
{
	class Cart
	{
		private Order order;
		private List<PromoCodeInterface> listWithActivePromoCodes;
		private PromosProviderInterface promoProvider;

		public Cart(List<Book> listOfBooks, PromosProviderInterface promosProvider, List<PromoCodeInterface> listWithPromocodes)
		{
			order = new Order(listOfBooks);
			promoProvider = promosProvider;
			listWithActivePromoCodes = listWithPromocodes;
		}

		public double PaymentCalculation()
		{
			promoProvider.GetActivePromos().ForEach(a => a.applyPromo(order));
			if (listWithActivePromoCodes != null)
			{
				foreach (PromoCodeInterface promoCode in listWithActivePromoCodes)
				{
					promoCode.applyPromoCode(order);
				}
			}
			double cost = order.finalSum;
			Console.WriteLine($"Цена { order.cost}");
			Console.WriteLine($"Доставка { order.delivery}");
			Console.WriteLine($"Скидка { order.discount}");
			Console.WriteLine($"Количество книг { order.books.Count}");
			return cost;
		}
	}
}