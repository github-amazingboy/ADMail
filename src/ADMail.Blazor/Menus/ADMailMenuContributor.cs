using ADMail.Localization;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ADMail.Blazor.Menus;

public class ADMailMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<ADMailResource>();
        context.Menu.AddItem(
           new ApplicationMenuItem("MyProject.Crm", l["Menu:CRM"])
               .AddItem(new ApplicationMenuItem(
                   name: "MyProject.Crm.Customers",
                   displayName: l["Menu:Customers"],
                   url: "/crm/customers")
               ).AddItem(new ApplicationMenuItem(
                   name: "MyProject.Crm.Orders",
                   displayName: l["Menu:Orders"],
                   url: "/crm/orders")
                ));
        //Add main menu items.
        var admailMenu = context.Menu.AddItem(new ApplicationMenuItem(ADMailMenus.Prefix, displayName: "ADMail", "/ADMail", icon: "fa fa-globe")
            .AddItem(new ApplicationMenuItem(ADMailMenus.Prefix, displayName: "MailServer", "/mailserver", icon: "fa fa-globe"))
        );
        return Task.CompletedTask;
    }
}
