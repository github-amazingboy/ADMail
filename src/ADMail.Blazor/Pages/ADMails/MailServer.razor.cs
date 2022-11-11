using System;
using System.Linq;
using System.Threading.Tasks;
using ADMail.Mail;
using Blazorise.DataGrid;
using Volo.Abp.Application.Dtos;
using Volo.Abp.BlazoriseUI;
using ADMail.Permissions;
namespace ADMail.Blazor.Pages
{
    public partial class MailServer: AbpCrudPageBase<IMailServerAppService, MailServerDto, Guid, MailServerPagedAndSortedResultRequestDto,
CreateUpdateMailServerDto>
    {

        public MailServer()
        {
            CreatePolicyName = ADMailPermissions.MailServer.Create;
            DeletePolicyName = ADMailPermissions.MailServer.Delete;
            UpdatePolicyName = ADMailPermissions.MailServer.Delete;
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        protected override Task UpdateGetListInputAsync()
        {
            if (GetListInput is ISortedResultRequest sortedResultRequestInput)
            {
                sortedResultRequestInput.Sorting = CurrentSorting;
            }

            if (GetListInput is IPagedResultRequest pagedResultRequestInput)
            {
                pagedResultRequestInput.SkipCount = (CurrentPage - 1) * PageSize;
            }

            if (GetListInput is ILimitedResultRequest limitedResultRequestInput)
            {
                limitedResultRequestInput.MaxResultCount = PageSize;

            }
            return Task.CompletedTask;
        }

        protected override Task OnDataGridReadAsync(DataGridReadDataEventArgs<MailServerDto> e)
        {

            var name = e.Columns.FirstOrDefault(c => c.SearchValue != null && c.Field == "Name");
            if (name != null) this.GetListInput.Name = name.SearchValue.ToString();

            return base.OnDataGridReadAsync(e);
        }
    }
}