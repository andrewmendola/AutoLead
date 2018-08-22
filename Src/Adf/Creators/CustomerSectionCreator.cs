using AutoLead.Contact;
using AutoLead.Creators.Interface;
using AutoLead.Customer;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class CustomerSectionCreator : BaseSectionCreator, ICustomerSectionCreator
	{
		#region Constructors

		public CustomerSectionCreator(IDateStringFormatter dateStringFormatter, IIdXElementBuilder idXElementBuilder, IContactXElementBuilder contactXElementBuilder)
		{
			IdXElementBuilder = idXElementBuilder;
			ContactXElementBuilder = contactXElementBuilder;
			DateStringFormatter = dateStringFormatter;
		}

		#endregion

		#region Properties

		private IContactXElementBuilder ContactXElementBuilder { get; set; }

		private IDateStringFormatter DateStringFormatter { get; set; }

		private IIdXElementBuilder IdXElementBuilder { get; set; }

		#endregion

		#region Methods

		public XElement CreateCustomerSection(AdfCustomer customer)
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
