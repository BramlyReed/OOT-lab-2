
using System.Collections.Generic;

namespace BookStore
{
	class PromosProvider : PromosProviderInterface
	{
		public List<PromoInterface> GetActivePromos()
		{
			var listOfPromos = new List<PromoInterface>
			{
				new TwoPaperAndOneElectronic()
			};
			return listOfPromos;
		}
	}
}