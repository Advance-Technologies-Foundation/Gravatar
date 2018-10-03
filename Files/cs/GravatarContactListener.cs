using System;
using Terrasoft.Core.Configuration;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

namespace Gravatar
{
	[EntityEventListener(SchemaName = "Contact")]
	public class GravatarContactListener : BaseEntityEventListener
	{	
		public override void OnSaved(object sender, EntityAfterEventArgs e) {
			base.OnSaved(sender, e);
			var contact = (Entity)sender;
			var imageId = contact.GetTypedColumnValue<Guid>("PhotoId");
			if (imageId == Guid.Empty) {
				var email = contact.GetTypedColumnValue<string>("Email");
				var gravatar = AvatarFactory.CreateAvatarByEmail(email);
				byte[] gravatarImage = gravatar.GetImage();
				var userConnection = contact.UserConnection;
				if (gravatarImage != null) {
					var newImage = new SysImage(userConnection);
					newImage.SetDefColumnValues();
					newImage.SetBytesValue("Data", gravatarImage);
					newImage.SetColumnValue("Name", "FromGravatar");
					newImage.Save();
					contact.SetColumnValue("PhotoId", newImage.PrimaryColumnValue);
					contact.Save();
				}
			}
		}
	}
}