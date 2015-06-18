using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WindowsFormsApplication1
{
	class CrawlHandler
	{
		LinkedList<WebHandler> requestQueue = new LinkedList<WebHandler>();
		List<string> visited = new List<string>();
		Form1 form;
		Thread imageLoadThread;

		public CrawlHandler( Form1 form, String startingURL )
		{
			this.form = form;			
			requestQueue.AddLast( new WebHandler( startingURL ) );
		}

		public void Start()
		{
			while ( requestQueue.Count != 0 )
			{
				crawlURL( requestQueue.First() );
				requestQueue.RemoveFirst();
			}
		}

		private void crawlURL( WebHandler webHandler )
		{
			form.debugLine( "Crawling: " + webHandler.url );
			webHandler.executeRequest();
			webHandler.findLinks();
			webHandler.findImages();
			addLinks( webHandler.Links );
			addImages( webHandler.Images );
		}

		/*
		 * List of links to be added to the end of the queue, resulting in images being downloaded with priority.
		 */
		private void addLinks( List<string> list )
		{
			foreach ( string url in list )
			{
				if ( !visited.Contains( url ) )
				{
					requestQueue.AddLast( new WebHandler( url ) );
					visited.Add( url );
				}
			}
		}


		/*
		 * List of image-URLS to be added to the start of the queue, resulting in images being downloaded with priority.
		 */
		private void addImages( List<string> list )
		{
			foreach ( string url in list )
			{
				if ( !visited.Contains( url ) )
				{
					requestQueue.AddFirst( new WebHandler( url ) );
					visited.Add( url );
				}
			}
		}


	}
}
