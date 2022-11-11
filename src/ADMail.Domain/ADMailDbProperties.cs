namespace ADMail;

public static class ADMailDbProperties
{
    public static string DbTablePrefix { get; set; } = "ADMail";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ADMail";
}
