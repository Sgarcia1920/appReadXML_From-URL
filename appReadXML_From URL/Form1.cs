using Microsoft.VisualBasic;
using System.Xml;

namespace appReadXML_From_URL
{
	public partial class Form1 : Form
	{
		String URLString;
		XmlTextReader reader;
		public Form1()
		{
			InitializeComponent();
			URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
			reader = new XmlTextReader(URLString);
			while (reader.Read())
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element: // The node is an element.
						txtXMLData.Text += ("<" + reader.Name);

						while (reader.MoveToNextAttribute()) // Read the attributes.
							txtXMLData.Text += (" " + reader.Name + "='" + reader.Value + "'");
						//txtXMLData.Text +=(">");
						txtXMLData.Text += (">") + Environment.NewLine;
						break;
					case XmlNodeType.Text: //Display the text in each element.
						txtXMLData.Text += (reader.Value) + Environment.NewLine;
						break;
					case XmlNodeType.EndElement: //Display the end of the element.
						txtXMLData.Text += ("</" + reader.Name);
						txtXMLData.Text += (">") + Environment.NewLine;
						break;
				}
			}


		}

		private void btnshowxml_Click(object sender, EventArgs e)
		{
			
			Cd_information[] cd = new Cd_information[60];
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("tu_archivo.xml"); 

				// Obtener la lista de nodos <CD>
				XmlNodeList cdList = xmlDoc.GetElementsByTagName("CD");

				// Lista para almacenar objetos CDInformation
				List<Cd_information> cdInfos = new List<Cd_information>();

				// Iterar sobre los nodos <CD>
				foreach (XmlNode cdNode in cdList)
				{
					XmlElement cdElement = (XmlElement)cdNode;

					// Extraer los datos del CD
					string title = cdElement.GetElementsByTagName("TITLE")[0].InnerText;
					string artist = cdElement.GetElementsByTagName("ARTIST")[0].InnerText;
					string country = cdElement.GetElementsByTagName("COUNTRY")[0].InnerText;
					string company = cdElement.GetElementsByTagName("COMPANY")[0].InnerText;
					double price = Convert.ToDouble(cdElement.GetElementsByTagName("PRICE")[0].InnerText);
					int year = Convert.ToInt32(cdElement.GetElementsByTagName("YEAR")[0].InnerText);

					// Crear un objeto CDInformation con los datos
					Cd_information cdInfo = new Cd_information(title, artist, country, company, price, year);
					cdInfos.Add(cdInfo); // Agregar el objeto a la lista
				}

				// Agregar los objetos CDInformation al ListView
				foreach (Cd_information cdInfo in cdInfos)
				{
					ListViewItem item = new ListViewItem(new[] { cdInfo.Title, cdInfo.Artist, cdInfo.Country, cdInfo.Company, cdInfo.Price.ToString(), cdInfo.Year.ToString() });
					lstvcds_data.Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al procesar el XML: " + ex.Message);
			}
		}

		//	if (reader.NodeType == XmlNodeType.Element && reader.Name == "CD")
		//	{
		//		cd[i] = new Cd_information();
		//	}
		//	else if (reader.NodeType == XmlNodeType.Text)
		//	{
		//		if (reader.Value != "\n")
		//		{
		//			switch (reader.Name)
		//			{
		//				case "TITLE":
		//					cd[i].Title = reader.Value;
		//					break;
		//				case "ARTIST":
		//					cd[i].Artist = reader.Value;
		//					break;
		//				case "COUNTRY":
		//					cd[i].Country = reader.Value;
		//					break;
		//				case "COMPANY":
		//					cd[i].Company = reader.Value;
		//					break;
		//				case "PRICE":
		//					cd[i].Price = decimal.Parse(reader.Value);
		//					break;
		//				case "YEAR":
		//					cd[i].Year = int.Parse(reader.Value);
		//					break;
		//			}
		//			ListViewItem row = new ListViewItem(cd[i].Title);
		//			row.SubItems.Add(cd[i].Artist);
		//			row.SubItems.Add(cd[i].Country);
		//			row.SubItems.Add(cd[i].Company);
		//			row.SubItems.Add(cd[i].Price.ToString());
		//			row.SubItems.Add(cd[i].Year.ToString());
		//			lstvcds_data.Items.Add(row);
		//			i++;

		//		}
		//	}

		//}


	}
	
}
