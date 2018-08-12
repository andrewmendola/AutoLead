﻿using System.Xml.Linq;
using AdfLibrary.Vehicle;

namespace AdfLibrary
{
	public class PriceXElementBuilder : IPriceXElementBuilder
	{
		#region Public Methods

		public XElement BuildPriceElement(Price vehiclePrice)
		{
			var priceTypeAttribute = new XAttribute("type", vehiclePrice.PriceType.ToString().ToLower());
			var currencyAttribute = new XAttribute("currency", vehiclePrice.Currency.ToString().ToUpper());
			var priceElement = new XElement("price", priceTypeAttribute, currencyAttribute, vehiclePrice.Value);

			if (vehiclePrice.PriceDelta != null)
			{
				priceElement.Add(new XAttribute("delta", vehiclePrice.PriceDelta));
			}

			if (vehiclePrice.PriceRelativeTo != null)
			{
				priceElement.Add(new XAttribute("relativeto", vehiclePrice.PriceRelativeTo));
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
