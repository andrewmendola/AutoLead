using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class CustomerElementBuilder : BaseElementBuilder, ICustomerElementBuilder
	{
		#region Constructors

		public CustomerElementBuilder(IDateStringFormatter dateStringFormatter,
			IIdElementBuilder idXElementBuilder,
			IContactElementBuilder contactXElementBuilder)
		{
			DateStringFormatter = dateStringFormatter;
			IdXElementBuilder = idXElementBuilder;
			ContactXElementBuilder = contactXElementBuilder;
		}

		#endregion

		#region Properties

		private IContactElementBuilder ContactXElementBuilder { get; set; }

		private IDateStringFormatter DateStringFormatter { get; set; }

		private IIdElementBuilder IdXElementBuilder { get; set; }

		#endregion

		#region Methods

		public XElement BuildCustomerElement(Customer customer)
		{
			var customerElement = new XElement("customer");

			var idElements = GetIdElements(customer.Ids, IdXElementBuilder);
			if (idElements.Any())
			{
				customerElement.Add(idElements);
			}

			if (customer.Contact != null)
			{
				customerElement.Add(ContactXElementBuilder.BuildContactElement(customer.Contact));
			}

			if (customer.Timeframe != null)
			{
				customerElement.Add(GetTimeframeElement(customer.Timeframe));
			}

			if (!string.IsNullOrEmpty(customer.Comments))
			{
				customerElement.Add(new XElement("comments", customer.Comments));
			}

			return customerElement;
		}

		private XElement GetTimeframeElement(Timeframe timeframe)
		{
			if (timeframe.EarliestDate == null && timeframe.LatestDate == null)
			{
				throw new AdfException("An ealiest date or latest date is required for timeframe.");
			}

			var timeframeElement = new XElement("timeframe");

			if (!string.IsNullOrEmpty(timeframe.Description))
			{
				timeframeElement.Add(new XElement("description", timeframe.Description));
			}

			if (timeframe.EarliestDate != null)
			{
				timeframeElement.Add(new XElement("earliestdate", timeframe.EarliestDate));
			}

			if (timeframe.LatestDate != null)
			{
				timeframeElement.Add(new XElement("latestdate", timeframe.LatestDate));
			}

			return timeframeElement;
		}

		#endregion
	}
}
