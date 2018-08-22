using AutoLead;
using AutoLead.Contact;
using AutoLead.Contact.Enum;
using AutoLead.Customer;
using AutoLead.Email;
using AutoLead.Name;
using AutoLead.Name.Enum;
using AutoLead.Phone;
using AutoLead.Prospect;
using AutoLead.Provider;
using AutoLead.Vehicle;
using AutoLead.Vendor;
using System.Collections.Generic;

namespace AdfUtility
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(764, 668);
			this.textBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 757);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

			var contact = new AdfContact
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
				Email = new AdfEmail
				{
					Value = "test@testadf.com",
					PreferredContact = true
				},
				Names = new List<AdfName>
							{
								new AdfName
								{
									NamePart = NamePart.Full,
									Value = "John Doe",
									Type = NameType.Individual
								}
							},
				PhoneNumbers = new List<AdfPhone>
							{
								new AdfPhone
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
					Customer = new AdfCustomer
					{
						Contact = contact,
						/*Timeframe = new Timeframe
						{
							Description = "time and stuff",
							EarliestDate = DateTime.Now.AddDays(1),
							LatestDate = DateTime.Now.AddMonths(1),
						},*/
						/*Ids = new List<AdfId>
						{
							new AdfId
							{
								Id = "123456",
								Source = "Autonation"
							},
							new AdfId
							{
								Id = "1234567",
								Source = "Cobalt"
							}
						},
						Comments = "hi there!"*/
					},
					Prospect = new AdfProspect
					{
						/*Ids = new List<AdfId>
						{
							new AdfId
							{
								Id = "123456",
								Source = "Autonation"
							},
							new AdfId
							{
								Id = "1234567",
								Source = "Cobalt"
							}
						},*/
						RequestDate = System.DateTime.Now
					},
					Provider = new AdfProvider {
						Ids = new List<AdfId>
						{
							new AdfId
							{
								Id = "123456",
								Source = "Autonation"
							},
							new AdfId
							{
								Id = "1234567",
								Source = "Cobalt"
							}
						},
						Email = new AdfEmail
						{
							Value = "test@testadf.com",
							PreferredContact = true
						},
						Names = new List<AdfName>
						{
							new AdfName
							{
								NamePart = NamePart.Full,
								Value = "John Doe",
								Type = NameType.Individual
							}
						},
						Phone = new AdfPhone
							{
								PreferredContact = true,
								Value = "321-123-4567",
							},
						Service = "milk",
						Url = "www.testadf.com",
						Contact = contact
					},
					Vehicles = new List<AdfVehicle>
					{
						new AdfVehicle
						{
							Year = "1999",
							Make = "Honda",
							Model = "Civic",
							/*Trim = "Ex",
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
								Currency = Currency.Usd,
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
										Currency = Currency.Usd,
										Limit = FinanceAmountLimit.DownPayment,
										Type = FinanceAmountType.Exact
									},
									new FinanceAmount
									{
										Amount = "$100",
										Currency = Currency.Usd,
										Limit = FinanceAmountLimit.Monthly,
										Type = FinanceAmountType.Minimum
									},
									new FinanceAmount
									{
										Amount = "$3,000",
										Currency = Currency.Usd,
										Limit = FinanceAmountLimit.Total,
										Type = FinanceAmountType.Maximum
									}
								},
								Balance = new FinanceBalance
								{
									Amount = "$4,000",
									Currency = Currency.Usd,
									Type = FinanceBalanceType.Residual
								},
								Method = "Finance"
							},
							Ids = new List<AdfId>(),
							Options = new List<Option>
							{
								new Option
								{
									ManufacturerCode = "abc123",
									OptionName = "SunRoof",
									Price = new Price
									{
										Currency = Currency.Usd,
										Source = "KBB",
										Value =  "$500"
									},
									Stock = "123fdsgds",
									Weighting = 20
								}
							},
							Status = VehicleStatus.Used*/
						}
					},
					Vendor = new AdfVendor {
						Ids = new List<AdfId>
						{
							new AdfId
							{
								Id = "123456",
								Source = "Autonation"
							},
							new AdfId
							{
								Id = "1234567",
								Source = "Cobalt"
							}
						},
						VendorName = "123Ford",
						Url = "test@adftest.com",
						Contact = contact
					}
				}
			};		

			var builder = new AdfBuilder(leads);

			textBox1.Text = builder.AdfXDocument.ToString();
		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}

