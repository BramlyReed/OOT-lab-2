using System.Collections.Generic;

namespace BookStore
{
	interface PromoInterface
	{
		void applyPromo(Order order);
	}

	interface PromosProviderInterface
	{
		List<PromoInterface> GetActivePromos();
	}
}
