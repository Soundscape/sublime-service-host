using System;
using Nancy.Hosting.Self;
using Nancy;

namespace Sublime.Services.Manager
{
	public class ManagerService
	{
		#region Members

		NancyHost host;

		#endregion

		#region Constructors

		public ManagerService (string uri) {
			uri = uri.Trim ();
			if (string.IsNullOrEmpty (uri))
				throw new ArgumentNullException ("URI cannot be empty");

			this.host = new NancyHost (new Uri (uri), new HostBootstrapper ());
		}

		#endregion

		#region Methods

		public void Start() {
			Console.WriteLine ("Starting manager host");
			this.host.Start ();
		}

		public void Stop() {
			Console.WriteLine ("Stoping manager host");
			this.host.Stop ();
		}

		#endregion
	}
}

