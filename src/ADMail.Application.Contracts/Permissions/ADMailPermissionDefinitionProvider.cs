using ADMail.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ADMail.Permissions;

public class ADMailPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ADMailPermissions.GroupName, L("Permission:ADMail"));
        var pd = myGroup.AddPermission(ADMailPermissions.MailServer.Default,L("Permission:ADMail:MailServer"));
        pd.AddChild(ADMailPermissions.MailServer.Create,L("Permission:ADMail:MailServer:MailServer_Create"));
        pd.AddChild(ADMailPermissions.MailServer.Update,L("Permission:ADMail:MailServer:MailServer_Update"));
        pd.AddChild(ADMailPermissions.MailServer.Delete,L("Permission:ADMail:MailServer:MailServer_Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ADMailResource>(name);
    }
}
