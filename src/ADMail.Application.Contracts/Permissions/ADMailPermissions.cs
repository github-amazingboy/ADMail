using Volo.Abp.Reflection;

namespace ADMail.Permissions;

public class ADMailPermissions
{
    public const string GroupName = "ADMail";

    public class MailServer{
        
        public const string Default = "MailServer";
        public const string Create = Default+".Create";
        public const string Delete = Default+".Delete";
        public const string Update = Default+".Update";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ADMailPermissions));
    }
}
