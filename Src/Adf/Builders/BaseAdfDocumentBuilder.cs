using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead
{
	public abstract class BaseAdfDocumentBuilder
	{
		#region Fields

		private XDocument _adfXDocument;

		#endregion

		#region Constructors

		protected BaseAdfDocumentBuilder(AdfDocumentBuilderSettings adfDocumentBuilderSettings = null)
		{
			Settings = adfDocumentBuilderSettings ?? new AdfDocumentBuilderSettings();
		}

		#endregion

		#region Properties

		public XDocument AdfXDocument => _adfXDocument ?? (_adfXDocument = BuildAdfDocument());

		protected abstract IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected abstract ICustomerElementBuilder CustomerSectionCreator { get; }

		protected abstract IProspectElementBuilder ProspectCreator { get; }

		protected abstract IProviderElementBuilder ProviderSectionCreator { get; }

		protected AdfDocumentBuilderSettings Settings { get; }

		protected abstract IVehicleElementBuilder VehicleSectionCreator { get; }

		protected abstract IVendorElementBuilder VendorSectionCreator { get; }

		protected abstract IRootDocumentBuilder XmlDocumentCreator { get; }

		#endregion

		#region Methods

		protected virtual void AddSectionsToProspect(
			XElement prospectNode,
			XElement customerNode,
			XElement vendorNode,
			XElement providorNode,
			ICollection<XElement> vehicleNodes)
		{
			prospectNode.Add(vehicleNodes);
			prospectNode.Add(customerNode);
			prospectNode.Add(vendorNode);
			prospectNode.Add(providorNode);
		}

		protected virtual XDocument BuildAdfDocument()
		{
			var adfDocument = XmlDocumentCreator.BuildRootDocument(Settings);
			var adfRootNode = new XElement("adf");
			adfDocument.Add(adfRootNode);

			foreach (var adfLead in AdfLeads)
			{
				var vehicleNodes = GetVehicleNodes(adfLead.Vehicles);
				var customerNode = CustomerSectionCreator.BuildCustomerElement(adfLead.Customer);
				var vendorNode = VendorSectionCreator.BuildVendorElement(adfLead.Vendor);
				var providorNode = ProviderSectionCreator.BuildProviderElement(adfLead.Provider);
				var prospectNode = ProspectCreator.BuildProspectElement(adfLead.Prospect, Settings);

				AddSectionsToProspect(prospectNode, customerNode, vendorNode, providorNode, vehicleNodes);

				adfRootNode.Add(prospectNode);
			}

			return adfDocument;
		}

		private List<XElement> GetVehicleNodes(ICollection<Vehicle> adfVehicles)
		{
			var vehicleNodes = new List<XElement>();
			var vehicleSequence = 0;
			foreach (var vehicle in adfVehicles)
			{
				vehicleSequence++;
				vehicleNodes.Add(VehicleSectionCreator.BuildVehicleElement(vehicle, vehicleSequence));
			}

			return vehicleNodes;
		}

		#endregion
	}
}
