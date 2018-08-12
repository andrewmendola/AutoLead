using System.Collections.Generic;
using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;
using AdfLibrary.Vehicle;

namespace AdfLibrary
{
	public abstract class BaseAdfDocumentBuilder
	{
		#region Constants and Fields

		private XDocument _adfXDocument;

		#endregion

		#region Constructors and Destructors

		protected BaseAdfDocumentBuilder(AdfDocumentBuilderSettings adfDocumentBuilderSettings = null)
		{
			Settings = adfDocumentBuilderSettings ?? new AdfDocumentBuilderSettings();
		}

		#endregion

		#region Public Properties

		public XDocument AdfXDocument => _adfXDocument ?? (_adfXDocument = BuildAdfDocument());

		#endregion

		#region Properties

		protected AdfDocumentBuilderSettings Settings { get; }

		protected abstract IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected abstract IRootDocumentCreator XmlDocumentCreator { get; }

		protected abstract IVehicleSectionCreator VehicleSectionCreator { get; }

		protected abstract ICustomerSectionCreator CustomerSectionCreator { get; }

		protected abstract IProviderSectionCreator ProviderSectionCreator { get; }

		protected abstract IVendorSectionCreator VendorSectionCreator { get; }

		protected abstract IProspectCreator ProspectCreator { get; }

		#endregion

		#region Methods

		protected virtual XDocument BuildAdfDocument()
		{
			var adfDocument = XmlDocumentCreator.CreateRootDocument(Settings);
			var adfRootNode = new XElement("adf");
			adfDocument.Add(adfRootNode);

			var prospectSequence = 0;
			foreach (var adfLead in AdfLeads)
			{
				prospectSequence++;

				var vehicleNodes = GetVehicleNodes(adfLead.Vehicles);
				var customerNode = CustomerSectionCreator.CreateCustomerSection(adfLead.Customer);
				var vendorNode = VendorSectionCreator.CreateVendorSection(adfLead.Vendor);
				var providorNode = ProviderSectionCreator.CreateProviderSection(adfLead.Provider);
				var prospectNode = ProspectCreator.CreateProspect(adfLead.Prospect, prospectSequence, Settings);

				AddSectionsToProspect(prospectNode, customerNode, vendorNode, providorNode, vehicleNodes);

				adfRootNode.Add(prospectNode);
			}

			return adfDocument;
		}

		protected virtual void AddSectionsToProspect(
			XElement prospectNode,
			XElement customerNode,
			XElement vendorNode,
			XElement providorNode,
			IReadOnlyCollection<XElement> vehicleNodes)
		{
			prospectNode.Add(vehicleNodes);
			prospectNode.Add(customerNode);
			prospectNode.Add(vendorNode);
			prospectNode.Add(providorNode);
		}

		private List<XElement> GetVehicleNodes(IReadOnlyCollection<AdfVehicle> adfVehicles)
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
