using AutoLead.Builders;
using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead
{
	public class AdfDocumentBuilder : IAdfDocumentBuilder
	{
		#region Methods

		public XDocument BuildAdfDocument(List<AdfLead> adfLeads, AdfDocumentBuilderSettings adfDocumentBuilderSettings = null)
		{
			if (adfDocumentBuilderSettings == null)
			{
				adfDocumentBuilderSettings = new AdfDocumentBuilderSettings();
			}

			SetDefaultSettings(adfDocumentBuilderSettings);

			var adfDocument =
				adfDocumentBuilderSettings.RootDocumentBuilder.BuildRootDocument(
					adfDocumentBuilderSettings.IncludeXmlDeclaration,
					adfDocumentBuilderSettings.IncludeAdfDeclaration);

			var adfRootNode = new XElement("adf");
			adfDocument.Add(adfRootNode);

			foreach (var adfLead in adfLeads)
			{
				var vehicleNodes = GetVehicleNodes(adfLead.Vehicles, adfDocumentBuilderSettings);
				var customerNode = adfDocumentBuilderSettings.CustomerElementBuilder.BuildCustomerElement(adfLead.Customer);
				var vendorNode = adfDocumentBuilderSettings.VendorElementBuilder.BuildVendorElement(adfLead.Vendor);
				var providorNode = adfDocumentBuilderSettings.ProviderElementBuilder.BuildProviderElement(adfLead.Provider);
				var prospectNode = adfDocumentBuilderSettings.ProspectElementBuilder.BuildProspectElement(adfLead.Prospect);

				prospectNode.Add(vehicleNodes);
				prospectNode.Add(customerNode);
				prospectNode.Add(vendorNode);
				prospectNode.Add(providorNode);

				adfRootNode.Add(prospectNode);
			}

			return adfDocument;
		}

		private List<XElement> GetVehicleNodes(ICollection<Vehicle> adfVehicles, AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			var vehicleNodes = new List<XElement>();
			var vehicleSequence = 0;
			foreach (var vehicle in adfVehicles)
			{
				vehicleSequence++;
				vehicleNodes.Add(adfDocumentBuilderSettings.VehicleElementBuilder.BuildVehicleElement(vehicle, vehicleSequence));
			}

			return vehicleNodes;
		}

		private void SetDefaultSettings(AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			adfDocumentBuilderSettings.DateStringFormatter = adfDocumentBuilderSettings.DateStringFormatter ?? new DateStringFormatter();
			adfDocumentBuilderSettings.EmailElementBuilder = adfDocumentBuilderSettings.EmailElementBuilder ?? new EmailElementBuilder();
			adfDocumentBuilderSettings.IdElementBuilder = adfDocumentBuilderSettings.IdElementBuilder ?? new IdElementBuilder();
			adfDocumentBuilderSettings.NameElementBuilder = adfDocumentBuilderSettings.NameElementBuilder ?? new NameElementBuilder();
			adfDocumentBuilderSettings.PhoneElementBuilder = adfDocumentBuilderSettings.PhoneElementBuilder ?? new PhoneElementBuilder();
			adfDocumentBuilderSettings.PriceElementBuilder = adfDocumentBuilderSettings.PriceElementBuilder ?? new PriceElementBuilder();
			adfDocumentBuilderSettings.RootDocumentBuilder = adfDocumentBuilderSettings.RootDocumentBuilder ?? new RootDocumentBuilder();

			adfDocumentBuilderSettings.ContactElementBuilder = adfDocumentBuilderSettings.ContactElementBuilder
				?? new ContactElementBuilder(
					adfDocumentBuilderSettings.NameElementBuilder,
					adfDocumentBuilderSettings.EmailElementBuilder,
					adfDocumentBuilderSettings.PhoneElementBuilder);

			adfDocumentBuilderSettings.ProspectElementBuilder = adfDocumentBuilderSettings.ProspectElementBuilder
				?? new ProspectElementBuilder(
					adfDocumentBuilderSettings.DateStringFormatter,
					adfDocumentBuilderSettings.IdElementBuilder);

			adfDocumentBuilderSettings.CustomerElementBuilder = adfDocumentBuilderSettings.CustomerElementBuilder
				?? new CustomerElementBuilder(
					adfDocumentBuilderSettings.DateStringFormatter,
					adfDocumentBuilderSettings.IdElementBuilder,
					adfDocumentBuilderSettings.ContactElementBuilder);

			adfDocumentBuilderSettings.ProviderElementBuilder = adfDocumentBuilderSettings.ProviderElementBuilder
				?? new ProviderElementBuilder(
					adfDocumentBuilderSettings.IdElementBuilder,
					adfDocumentBuilderSettings.NameElementBuilder,
					adfDocumentBuilderSettings.ContactElementBuilder,
					adfDocumentBuilderSettings.EmailElementBuilder,
					adfDocumentBuilderSettings.PhoneElementBuilder);

			adfDocumentBuilderSettings.VehicleElementBuilder = adfDocumentBuilderSettings.VehicleElementBuilder
				?? new VehicleElementBuilder(
					adfDocumentBuilderSettings.PriceElementBuilder,
					adfDocumentBuilderSettings.IdElementBuilder);

			adfDocumentBuilderSettings.VendorElementBuilder = adfDocumentBuilderSettings.VendorElementBuilder
				?? new VendorElementBuilder(
					adfDocumentBuilderSettings.IdElementBuilder,
					adfDocumentBuilderSettings.ContactElementBuilder);
		}

		#endregion
	}
}
