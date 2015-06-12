using System;
using Nancy;

namespace Sublime.Services.Manager
{
	public class ManagerModule : NancyModule
	{
		public ManagerModule ()
		{
			var path = @"/home/shaun/services";

			Get ["/"] = _ =>
				View ["home", new { Title = "My page", Services = Blackboard.factory.LoadFromDirectory (path) }];

			Post ["/service/{name}"] = _ => {
				var name = _["name"].ToString();
				Blackboard.factory.StartService(name);

				return HttpStatusCode.OK;
			};

			Delete ["/service/{name}"] = _ => {
				var name = _["name"].ToString();
				Blackboard.factory.StopService(name);

				return HttpStatusCode.NoContent;
			};
		}
	}
}

