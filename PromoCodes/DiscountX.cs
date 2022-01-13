using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.PromoCodes
{
	class DiscountXR: PromoCodeInterface
	{
		uint rubles = 0;
		public DiscountXR(uint rubles)
		{
			this.rubles = rubles;
		}
		public void applyPromoCode(Order order)
		{
			order.discount += rubles;
		}
	}

	class DiscountXP: PromoCodeInterface
	{
		uint percents = 0;
		public DiscountXP(uint percents)
		{
			this.percents = percents;
		}
		public void applyPromoCode(Order order)
		{
			order.discount = (order.cost / 100) * percents;
		}
	}
}
