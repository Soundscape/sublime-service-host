using System;
using Nancy;
using Nancy.Conventions;

namespace Sublime.Services.Manager
{
	public class HostBootstrapper : DefaultNancyBootstrapper
	{
		#region Methods

		protected override void ConfigureConventions(NancyConventions conventions)
		{
			base.ConfigureConventions(conventions);

			StaticConfiguration.DisableErrorTraces = false;
			conventions.StaticContentsConventions.Add(
				StaticContentConventionBuilder.AddDirectory("/", "/Public"));
		}

		#endregion
	}
}