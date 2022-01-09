using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.PromoCodes
{
	class DiscountXRubles: PromoCodeInterface
	{
		uint rubles = 0;
		public DiscountXRubles(uint rubles)
		{
			this.rubles = rubles;
		}
		public void applyPromoCode(Order order)
		{
			order.discount += rubles;
		}
	}

	class DiscountXPercent: PromoCodeInterface
	{
		uint percents = 0;
		public DiscountXPercent(uint percents)
		{
			this.percents = percents;
		}
		public void applyPromoCode(Order order)
		{
			
		}
	}
}
