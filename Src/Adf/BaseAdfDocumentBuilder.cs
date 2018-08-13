using AutoLead.Creators.Interface;
using AutoLead.Lead;
using AutoLead.Vehicle;
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

		protected abstract ICustomerSectionCreator CustomerSectionCreator { get; }

		protected abstract IProspectCreator ProspectCreator { get; }

		protected abstract IProviderSectionCreator ProviderSectionCreator { get; }

		protected AdfDocumentBuilderSettings Settings { get; }

		protected abstract IVehicleSectionCreator VehicleSectionCreator { get; }

		protected abstract IVendorSectionCreator VendorSectionCreator { get; }

		protected abstract IRootDocumentCreator XmlDocumentCreator { get; }

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
			var adfDocument = XmlDocumentCreator.CreateRootDocument(Settings);
			var adfRootNode = new XElement("adf");
			adfDocument.Add(adfRootNode);

			foreach (var adfLead in AdfLeads)
			{
				var vehicleNodes = GetVehicleNodes(adfLead.Vehicles);
				var customerNode = CustomerSectionCreator.CreateCustomerSection(adfLead.Customer);
				var vendorNode = VendorSectionCreator.CreateVendorSection(adfLead.Vendor);
				var providorNode = ProviderSectionCreator.CreateProviderSection(adfLead.Provider);
				var prospectNode = ProspectCreator.CreateProspect(adfLead.Prospect, Settings);

				AddSectionsToProspect(prospectNode, customerNode, vendorNode, providorNode, vehicleNodes);

				adfRootNode.Add(prospectNode);
			}

			return adfDocument;
		}

		private List<XElement> GetVehicleNodes(ICollection<AdfVehicle> adfVehicles)
		{
			var vehicleNodes = new List<XElement>();
			var vehicleSequence = 0;
			foreach (var vehicle in adfVehicles)
			{
				vehicleSequence++;
				vehicleNodes.Add(VehicleSectionCreator.CreateVehicleSection(vehicle, vehicleSequence));
			}

			return vehicleNodes;
		}

		#endregion
	}
}
