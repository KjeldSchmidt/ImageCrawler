using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		delegate void SetTextCallback( string text );

		CrawlHandler crawler;
		Thread crawlThread;

		public Form1()
		{
			InitializeComponent();
		}

		private void beginCrawl( object sender, EventArgs e )
		{
			string URL = URLInput.Text;
			try
			{
				this.crawler = new CrawlHandler( this, URL );
				this.crawlThread = new Thread( new ThreadStart( crawler.Start ) );
				this.crawlThread.Start();
				while ( !this.crawlThread.IsAlive );
			}
			catch ( Exception ex )
			{
				debugBox.ForeColor = Color.Red;
				debugBox.Text += "\nThe input URL is invalid! Please try again." + ex.ToString();
			}
		}

		private void selectFolderButton_Click( object sender, EventArgs e )
		{
			folderBrowserDialog1.ShowDialog();
			targetFolderInput.Text = folderBrowserDialog1.SelectedPath;
		}

		private void stopCrawl_Click( object sender, EventArgs e )
		{
			this.crawlThread.Abort();
			this.crawlThread.Join();
		}

		/*
		 * Thread-Safe text insertion.
		 */
		public void debugLine( string text )
		{
			if ( this.debugBox.InvokeRequired )
			{
				SetTextCallback d = new SetTextCallback( debugLine );
				this.Invoke( d, new object[] { text } );
			}
			else
			{
				this.debugBox.Text += text + "\n";
				if ( this.debugBox.Text.Length > 0.8 * this.debugBox.MaxLength )
				{
					this.debugBox.Text = this.debugBox.Text.Remove( 0, this.debugBox.Text.Length / 2 );
				}
			}
		}

		private void debugBox_TextChanged( object sender, EventArgs e )
		{
			debugBox.SelectionStart = debugBox.Text.Length;
			debugBox.ScrollToCaret();
		}
	}
}
