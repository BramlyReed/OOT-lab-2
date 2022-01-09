using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Promos
{
	public interface PromoInterface
	{
		void applyPromo(Order order);
	}

	public interface PromosProvider
	{
		List<PromoInterface> GetActivePromos();
	}
}
