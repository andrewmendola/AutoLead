using AutoLead.Builders.Interface;
using System.Xml.Linq;

namespace AutoLead.Data
{
	public class PriceElementBuilder : IPriceElementBuilder
	{
		#region Methods

		public XElement BuildPriceElement(Price vehiclePrice)
		{
			var priceElement = new XElement("price", new XAttribute("type", vehiclePrice.PriceType.ToString().ToLower()), vehiclePrice.Value);

			if (!string.IsNullOrEmpty(vehiclePrice.Currency))
			{
				var currencyAttribute = new XAttribute("currency", vehiclePrice.Currency.ToUpper());
			}

			if (vehiclePrice.PriceDelta != null)
			{
				priceElement.Add(new XAttribute("delta", vehiclePrice.PriceDelta.ToString().ToLower()));
			}

			if (vehiclePrice.PriceRelativeTo != null)
			{
				priceElement.Add(new XAttribute("relativeto", vehiclePrice.PriceRelativeTo.ToString().ToLower()));
			}

			if (!string.IsNullOrEmpty(vehiclePrice.Source))
			{
				priceElement.Add(new XAttribute("source", vehiclePrice.Source));
			}

			return priceElement;
		}

		#endregion
	}
}
