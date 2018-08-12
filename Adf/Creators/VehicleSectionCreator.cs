using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Vehicle;

namespace AdfLibrary.Creators
{
	public class VehicleSectionCreator : IVehicleSectionCreator
	{
		#region Constructors and Destructors

		public VehicleSectionCreator(IPriceXElementBuilder priceXElementBuilder)
		{
			PriceXElementBuilder = priceXElementBuilder;
		}

		#endregion

		#region Properties

		private IPriceXElementBuilder PriceXElementBuilder { get; }

		#endregion

		#region Public Methods

		public XElement CreateVehicleSection(AdfVehicle vehicle, int sequence)
		{
			var vehicleElement = new XElement("Vehicle");

			// TODO: might not be optional.
			if (vehicle.Interest != null)
			{
				vehicleElement.Add(new XAttribute("interest", vehicle.Interest.ToString().ToLower()));
			}

			// TODO: might not be optional.
			if (vehicle.Status != null)
			{
				vehicleElement.Add(new XAttribute("status", vehicle.Status.ToString().ToLower()));
			}

			// TODO: Id

			// TODO: Required.
			if (!string.IsNullOrEmpty(vehicle.Year))
			{
				vehicleElement.Add(new XElement("year", vehicle.Year));
			}

			// TODO: Required.
			if (!string.IsNullOrEmpty(vehicle.Make))
			{
				vehicleElement.Add(new XElement("make", vehicle.Make));
			}

			// TODO: Required.
			if (!string.IsNullOrEmpty(vehicle.Model))
			{
				vehicleElement.Add(new XElement("model", vehicle.Model));
			}

			if (!string.IsNullOrEmpty(vehicle.Vin))
			{
				vehicleElement.Add(new XElement("vin", vehicle.Vin));
			}

			if (!string.IsNullOrEmpty(vehicle.StockNumber))
			{
				vehicleElement.Add(new XElement("stock", vehicle.StockNumber));
			}

			if (!string.IsNullOrEmpty(vehicle.Trim))
			{
				vehicleElement.Add(new XElement("trim", vehicle.Trim));
			}

			if (!string.IsNullOrEmpty(vehicle.Doors))
			{
				vehicleElement.Add(new XElement("doors", vehicle.Doors));
			}

			if (!string.IsNullOrEmpty(vehicle.BodyStyle))
			{
				vehicleElement.Add(new XElement("bodystyle", vehicle.BodyStyle));
			}

			if (!string.IsNullOrEmpty(vehicle.Transmission))
			{
				vehicleElement.Add(new XElement("transmission", vehicle.Transmission));
			}

			if (vehicle.Odometer != null)
			{
				vehicleElement.Add(GetOdometerElement(vehicle.Odometer));
			}

			if (vehicle.Condition.HasValue)
			{
				vehicleElement.Add(new XElement("condition", vehicle.Condition.ToString().ToLower()));
			}

			if (vehicle.ColorCombinations != null)
			{
				var preference = 0;
				foreach (var colorCombination in vehicle.ColorCombinations)
				{
					preference++;
					vehicleElement.Add(GetColorCombinationElements(colorCombination, preference));
				}
			}

			if (vehicle.ImageTag != null)
			{
				vehicleElement.Add(GetImageTagElement(vehicle.ImageTag));
			}

			if (vehicle.Price != null)
			{
				vehicleElement.Add(PriceXElementBuilder.BuildPriceElement(vehicle.Price));
			}

			if (!string.IsNullOrEmpty(vehicle.PriceComments))
			{
				vehicleElement.Add(new XElement("pricecomments", vehicle.PriceComments));
			}

			if (vehicle.Options != null)
			{
				foreach (var option in vehicle.Options)
				{
					vehicleElement.Add(GetOptionElement(option));
				}
			}

			if (vehicle.Finance != null)
			{
				vehicleElement.Add(GetFinanceElement(vehicle.Finance));
			}

			if (!string.IsNullOrEmpty(vehicle.Comments))
			{
				vehicleElement.Add(new XElement("comments", vehicle.Comments));
			}

			return vehicleElement;
		}

		#endregion

		#region Methods

		private XElement GetColorCombinationElements(ColorCombination colorCombination, int preference)
		{
			var colorCominationElement = new XElement(
				"colorcombination",
				new XElement("interiorcolor", colorCombination.InteriorColor),
				new XElement("exteriorcolor", colorCombination.ExteriorColor),
				new XElement("preference", preference.ToString()));

			return colorCominationElement;
		}

		private XElement GetFinanceElement(Finance finance)
		{
			var financeElement = new XElement("finance");

			if (finance.Method != null)
			{
				financeElement.Add(new XAttribute("method", finance.Method.Value));
			}

			if (finance.Method != null)
			{
				financeElement.Add(new XAttribute("method", finance.Method.Value));
			}

			if (finance.Method != null)
			{
				financeElement.Add(new XAttribute("method", finance.Method.Value));
			}

			return financeElement;
		}

		private XElement GetImageTagElement(ImageTag imageTag)
		{
			var imageTagElement = new XElement("imagetag", imageTag.Url);

			if (!string.IsNullOrEmpty(imageTag.Width))
			{
				imageTagElement.Add(new XAttribute("width", imageTag.Width));
			}

			if (!string.IsNullOrEmpty(imageTag.Height))
			{
				imageTagElement.Add(new XAttribute("height", imageTag.Height));
			}

			if (!string.IsNullOrEmpty(imageTag.AltText))
			{
				imageTagElement.Add(new XAttribute("alttext", imageTag.AltText));
			}

			return imageTagElement;
		}

		private XElement GetOdometerElement(Odometer odometer)
		{
			var odometerElement = new XElement("odometer", odometer.Value);

			if (odometer.Status.HasValue)
			{
				odometerElement.Add(new XAttribute("status", odometer.Status.Value));
			}

			if (odometer.Unit.HasValue)
			{
				odometerElement.Add(new XAttribute("units", odometer.Unit.Value));
			}

			return odometerElement;
		}

		private XElement GetOptionElement(Option option)
		{
			var optionElement = new XElement("option");

			if (!string.IsNullOrEmpty(option.OptionName))
			{
				optionElement.Add(new XAttribute("optionname", option.OptionName));
			}

			if (!string.IsNullOrEmpty(option.ManufacturerCode))
			{
				optionElement.Add(new XAttribute("manufacturercode", option.ManufacturerCode));
			}

			if (!string.IsNullOrEmpty(option.Stock))
			{
				optionElement.Add(new XAttribute("stock", option.Stock));
			}

			if (option.Weighting != null)
			{
				var weighting = option.Weighting;
				if (weighting > 100)
				{
					weighting = 100;
				}
				else if (option.Weighting < 100)
				{
					weighting = -100;
				}

				optionElement.Add(new XAttribute("weighting", weighting));
			}

			if (option.Price != null)
			{
				optionElement.Add(PriceXElementBuilder.BuildPriceElement(option.Price));
			}

			return optionElement;
		}

		#endregion
	}
}
