namespace appReadXML_From_URL
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtXMLData = new TextBox();
			lstvcds_data = new ListView();
			column_title = new ColumnHeader();
			column_artist = new ColumnHeader();
			column_country = new ColumnHeader();
			column_company = new ColumnHeader();
			column_price = new ColumnHeader();
			column_year = new ColumnHeader();
			btnshowxml = new Button();
			SuspendLayout();
			// 
			// txtXMLData
			// 
			txtXMLData.Font = new Font("Segoe UI", 10F);
			txtXMLData.Location = new Point(12, 12);
			txtXMLData.Multiline = true;
			txtXMLData.Name = "txtXMLData";
			txtXMLData.ScrollBars = ScrollBars.Both;
			txtXMLData.Size = new Size(274, 348);
			txtXMLData.TabIndex = 0;
			// 
			// lstvcds_data
			// 
			lstvcds_data.Columns.AddRange(new ColumnHeader[] { column_title, column_artist, column_country, column_company, column_price, column_year });
			lstvcds_data.Location = new Point(292, 12);
			lstvcds_data.Name = "lstvcds_data";
			lstvcds_data.Size = new Size(496, 348);
			lstvcds_data.TabIndex = 1;
			lstvcds_data.UseCompatibleStateImageBehavior = false;
			lstvcds_data.View = View.Details;
			// 
			// column_title
			// 
			column_title.Text = "Title";
			column_title.Width = 80;
			// 
			// column_artist
			// 
			column_artist.Text = "Artist";
			column_artist.Width = 80;
			// 
			// column_country
			// 
			column_country.Text = "Country";
			// 
			// column_company
			// 
			column_company.Text = "Company";
			column_company.Width = 70;
			// 
			// column_price
			// 
			column_price.Text = "Price";
			// 
			// column_year
			// 
			column_year.Text = "Year";
			// 
			// btnshowxml
			// 
			btnshowxml.Location = new Point(656, 366);
			btnshowxml.Name = "btnshowxml";
			btnshowxml.Size = new Size(132, 34);
			btnshowxml.TabIndex = 2;
			btnshowxml.Text = "Show XML";
			btnshowxml.UseVisualStyleBackColor = true;
		
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnshowxml);
			Controls.Add(lstvcds_data);
			Controls.Add(txtXMLData);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtXMLData;
		private ListView lstvcds_data;
		private ColumnHeader column_title;
		private ColumnHeader column_artist;
		private ColumnHeader column_country;
		private ColumnHeader column_company;
		private ColumnHeader column_price;
		private ColumnHeader column_year;
		private Button btnshowxml;
	}
}
