using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ADMail.Pages;

public class IndexModel : ADMailPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
