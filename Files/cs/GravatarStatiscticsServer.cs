using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace CustomConfigurationService
{
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class GravatarStatisticServer
	{
		private UserConnection _userConnection;

		private UserConnection userConnection {
			get {
				return _userConnection ?? (_userConnection =
					HttpContext.Current.Session["UserConnection"] as UserConnection);
			}
		}

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "GetGravatarImageCount", ResponseFormat = WebMessageFormat.Json)]
		public int GetGravatarImageCount() {
			var statisticsQuery = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysImage");
			statisticsQuery.AddAllSchemaColumns();
			var filter = statisticsQuery.CreateFilterWithParameters(FilterComparisonType.Contain, "Name", "Gravatar");
			statisticsQuery.Filters.Add(filter);
			return statisticsQuery.GetEntityCollection(userConnection).Count;
		}
	}
}