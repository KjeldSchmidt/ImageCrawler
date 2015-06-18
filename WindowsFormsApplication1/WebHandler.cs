using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
	class WebHandler
	{
		public String url;
		static int count;
		WebClient client;
		List<string> links = new List<string>();
		List<string> images = new List<string>();
		public string HTML;

		public WebHandler( string url )
			: this( url, false )
		{

		}

		/*
		 *	url: Location to acces
		 *	execute: Execute request when initializing? (False: Execute with executeRequest() instead when needed)
		 */
		public WebHandler( string url, bool execute )
		{
			this.url = url;
			this.client = new WebClient();

			if ( execute )
			{
				executeRequest();
			}
		}

		public void executeRequest()
		{
			try
			{
				if ( this.url.EndsWith( ".jpg" ) || this.url.EndsWith( ".png" ) || this.url.EndsWith( ".gif" ) )
				{
					if ( WebHandler.count > 0 )	WebHandler.count++;
					else WebHandler.count = 1;
					client.DownloadFile( url, "C:\\Users\\Kjeld\\Desktop\\CrawledImages\\" + WebHandler.count + url.Remove( 0, url.Length - 4 ) );
				}
				else
				{
					this.HTML = client.DownloadString( this.url );
				}
			}
			catch ( Exception ex )
			{
				Console.WriteLine( ex.ToString() );
			}
		}

		public void findLinks()
		{
			Regex anchorMatch = new Regex( "<a[^>]*" ); //Matches anchor tags
			Regex linkMatch = new Regex( "(?<=href=\")[^\"]*" ); // Inside an anchor tag, matches the HREF.



			if ( this.HTML != null )
			{
				MatchCollection matches = anchorMatch.Matches( this.HTML );
				if ( matches != null )
				{
					foreach ( Match match in matches )
					{
						String potentialLink = linkMatch.Match( match.Value ).Value;
						if ( Uri.IsWellFormedUriString( potentialLink, UriKind.Absolute ) )
						{
							this.links.Add( potentialLink );
						}
					}
				}
			}


		}

		public void findImages()
		{
			Regex imageMatch = new Regex( "<img[^>]*" ); //Matches image tags
			Regex sourceMatch = new Regex( "(?<=src=\")[^\"]*" ); // Inside an image tag, matches the SRC


			if ( this.HTML != null )
			{
				MatchCollection matches = imageMatch.Matches( this.HTML );
				if ( matches != null )
				{
					foreach ( Match match in matches )
					{
						String potentialImage = sourceMatch.Match( match.Value ).Value;
						if ( Uri.IsWellFormedUriString( potentialImage, UriKind.Absolute ) )
						{
							this.images.Add( potentialImage );
						}
					}
				}
			}
		}

		public String getResponse()
		{
			return this.HTML;
		}

		public List<string> Links
		{
			get
			{
				return this.links;
			}
			set
			{
				this.links = value;
			}
		}

		public List<string> Images
		{
			get
			{
				return this.images;
			}
			set
			{
				this.images = value;
			}
		}
	}
}