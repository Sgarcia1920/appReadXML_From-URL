using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appReadXML_From_URL
{
	internal class Cd_information
	{
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string artist;

		public string Artist
		{
			get { return artist; }
			set { artist = value; }
		}

		private string country;

		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		private string company;

		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		public Cd_information()
		{
			this.title = "";
			this.artist = "";
			this.country = "";
			this.company = "";
			this.price = 0;
			this.year = 0;
		}
		public Cd_information(string namecd, string artist , string country, string company, double price, int year)
		{
			this.title = namecd;
			this.artist = artist;
			this.country = country;
			this.company = company;
			this.price = price;
			this.year = year;
		}

		public override string ToString()
		{
			return title + " -" + artist + " -" + country + " -" + company + " -" + price + " -" + year;
		}


	}
}
