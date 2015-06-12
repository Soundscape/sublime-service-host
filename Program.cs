using System;
using Topshelf;

namespace Sublime.Services.Manager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			HostFactory.Run (x => {
				x.Service<ManagerService>(s => {
					s.ConstructUsing(name => new ManagerService("http://localhost:1337"));
					s.WhenStarted(i => i.Start());
					s.WhenStopped(i => i.Stop());
				});

				x.UseLinuxIfAvailable();
				x.RunAsLocalSystem();

				x.SetDescription("Service manager");
				x.SetDisplayName("ServiceManager");
				x.SetServiceName("ServiceManager");
			});
		}
	}
}
