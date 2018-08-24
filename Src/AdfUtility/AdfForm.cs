using AutoLead;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoLead.Data;
using AutoLead.Data.Enum;

namespace AdfUtility
{
	public partial class AdfForm : Form
	{
		public AdfForm()
		{
			InitializeComponent();
		}

		private void testButton_Click(object sender, EventArgs e)
		{

			var contact = new Contact
			{
				Address = new ContactAddress
				{
					StreetLines = new List<string>
					{
						"1234 test ave",
						"po box 12345"
					},
					Apartment = "2",
					City = "Test City",
					Country = "US",
					RegionCode = "NY",
					PostalCode = "12345",
					Type = ContactAddressType.Home
				},
				Email = new Email
				{
					Value = "test@testadf.com",
					PreferredContact = true
				},
				Names = new List<Name>
							{
								new Name
								{
									NamePart = NamePart.Full,
									Value = "John Doe",
									Type = NameType.Individual
								}
							},
				PhoneNumbers = new List<Phone>
							{
								new Phone
								{
									PreferredContact = true,
									Value = "321-123-4567",
								}
							}
			};

			var leads = new List<AdfLead>
			{
				new AdfLead
				{
					Customer = new Customer
					{
						Contact = contact,
						Timeframe = new Timeframe
						{
							Description = "time and stuff",
							EarliestDate = DateTime.Now.AddDays(1),
							LatestDate = DateTime.Now.AddMonths(1),
						},
						Ids = new List<Id>
						{
							new Id
							{
								LeadId = "123456",
								Source = "Autonation"
							},
							new Id
							{
								LeadId = "1234567",
								Source = "Cobalt"
							}
						},
						Comments = "hi there!"
					},
					Prospect = new Prospect
					{
						Ids = new List<Id>
						{
							new Id
							{
								LeadId = "123456",
								Source = "Autonation"
							},
							new Id
							{
								LeadId = "1234567",
								Source = "Cobalt"
							}
						},
						RequestDate = System.DateTime.Now
					},
					Provider = new Provider {
						Ids = new List<Id>
						{
							new Id
							{
								LeadId = "123456",
								Source = "Autonation"
							},
							new Id
							{
								LeadId = "1234567",
								Source = "Cobalt"
							}
						},
						Email = new Email
						{
							Value = "test@testadf.com",
							PreferredContact = true
						},
						Names = new List<Name>
						{
							new Name
							{
								NamePart = NamePart.Full,
								Value = "John Doe",
								Type = NameType.Individual
							}
						},
						Phone = new Phone
							{
								PreferredContact = true,
								Value = "321-123-4567",
							},
						Service = "milk",
						Url = "www.testadf.com",
						Contact = contact
					},
					Vehicles = new List<Vehicle>
					{
						new Vehicle
						{
							Year = "1999",
							Make = "Honda",
							Model = "Civic",
							Trim = "Ex",
							Transmission = "Automatic",
							BodyStyle = "Coupe",
							ColorCombinations = new List<ColorCombination>
							{
								new ColorCombination
								{
									InteriorColor = "Black",
									ExteriorColor = "Blue"
								}
							},
							Comments = "test comments",
							Condition = VehicleCondition.Poor,
							Doors = "4",
							ImageTag = new ImageTag
							{
								AltText = "1999 Honda Civic",
								Height = "200",
								Width = "200",
								Url = "http://www.google.com"
							},
							Interest = VehicleInterest.Buy,
							Odometer = new Odometer
							{
								Status = VehicleOdometerStatus.Original,
								Unit = VehicleOdometerUnits.Mi,
								Value = "123456"
							},
							Price = new Price
							{
								Currency =  "USD",
								PriceDelta = PriceDelta.Percentage,
								PriceRelativeTo = PriceRelativeTo.Msrp,
								PriceType = PriceType.Offer,
								Source = "KBB",
								Value =  "$10,000.00"
							},
							PriceComments = "price comment test",
							Vin = "1HGEJ8246XL098270",
							StockNumber = "R098270",
							Finance = new Finance
							{
								Amounts = new List<FinanceAmount>
								{
									new FinanceAmount
									{
										Amount = "$1,000",
										Currency = "USD",
										Limit = FinanceAmountLimit.DownPayment,
										Type = FinanceAmountType.Exact
									},
									new FinanceAmount
									{
										Amount = "$100",
										Currency =  "USD",
										Limit = FinanceAmountLimit.Monthly,
										Type = FinanceAmountType.Minimum
									},
									new FinanceAmount
									{
										Amount = "$3,000",
										Currency =  "USD",
										Limit = FinanceAmountLimit.Total,
										Type = FinanceAmountType.Maximum
									}
								},
								Balance = new FinanceBalance
								{
									Amount = "$4,000",
									Currency =  "USD",
									Type = FinanceBalanceType.Residual
								},
								Method = "Finance"
							},
							Ids = new List<Id>(),
							Options = new List<Option>
							{
								new Option
								{
									ManufacturerCode = "abc123",
									OptionName = "SunRoof",
									Price = new Price
									{
										Currency =  "USD",
										Source = "KBB",
										Value =  "$500"
									},
									Stock = "123fdsgds",
									Weighting = 20
								}
							},
							Status = VehicleStatus.Used
						}
					},
					Vendor = new Vendor {
						Ids = new List<Id>
						{
							new Id
							{
								LeadId = "123456",
								Source = "Autonation"
							},
							new Id
							{
								LeadId = "1234567",
								Source = "Cobalt"
							}
						},
						VendorName = "123Ford",
						Url = "test@adftest.com",
						Contact = contact
					}
				}
			};

			var builder = new AdfDocumentBuilder(leads);

			AdfTextBox.Text = builder.AdfXDocument.ToString();
		}
	}
}
