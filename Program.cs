using System;
using System.Collections.Generic;
using BookStore.PromoCodes;

namespace BookStore
{
	class Program
	{
		static void Main(string[] args)
		{
			DB_Products baseDB = new DB_Products();

			List<Book> exampleOrder = new List<Book>()
			{
				baseDB.db[0],
				baseDB.db[4],
				baseDB.db[5],
				baseDB.db[6],
				baseDB.db[7],
				baseDB.db[8]
			};

			PromosProvider promoProvider = new PromosProvider();
			
			Free freebook = new Free(baseDB.db[6]);
			DiscountXR discX = new DiscountXR(100);

			List<PromoCodeInterface> promoCodesList = new List<PromoCodeInterface>
			{
				freebook,
				discX
			};

			Cart exampleCart = new Cart(exampleOrder, promoProvider, promoCodesList);
			Console.WriteLine($"Итоговая цена { exampleCart.PaymentCalculation()}");
		}
	}
}
