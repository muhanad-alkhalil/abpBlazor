#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596c76000eaeec980bc10e928ffc05b18d23cf04"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
using Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
using Models.User.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
using Web.Blazor.Pages.UsersDialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
           [Authorize(Policy = "Users")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
       
    SearchKeyword searchKeyword = new SearchKeyword();
    int MaxResultCount = 10;
    int pages = 1;
    int currentPage = 1;
    int totalRoles = 0;
    List<UserResult> pageUsers = new List<UserResult>();
    //CreateRoleDto CreateRolemodel = new CreateRoleDto();


    string disabled = "disabled";
    string active = "active";
    protected override async Task OnInitializedAsync()
    {

        await refreshResult("", 0);
    }

    private async Task refreshResult(string word, int skip)
    {
        var response = await user.GetAll(word, skip, MaxResultCount);
        pageUsers = response.result.items;
        totalRoles = response.result.totalCount;
        pages = 1 + ((totalRoles - 1) / MaxResultCount);
        currentPage = (skip / 10) + 1;

    }

    private async Task DeleteUser(int id, string userName)
    {
        var dialogResult = await dialogService.Confirm(c.l["UserDeleteWarningMessage"].Replace("{0}", userName), c.l["AreYouSureWantToDelete"].Replace("{0}", userName), new ConfirmOptions() { OkButtonText = c.l["Yes"], CancelButtonText = c.l["No"] });
        if (dialogResult.HasValue && dialogResult.Value)
        {
            var response = await user.Delete(id);
            if (response.success)
            {
                notificationService.Notify(new NotificationMessage()
                {
                    Severity = NotificationSeverity.Success,
                    Summary = c.l["SuccessfullyDeleted"],
                    Detail = "",
                    Duration = 3000
                });
                await refreshResult(searchKeyword.keyword, (currentPage - 1) * 10);
            }
            else
            {
                notificationService.Notify(new NotificationMessage()
                {
                    Severity = NotificationSeverity.Error,
                    Summary = response.error.message,
                    Detail = response.error.details,
                    Duration = 3000
                });
            }
        }
    }

    async Task CreateUserDialog() => await dialogService.OpenAsync(c.l["CreateNewRole"], ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, "<CreateUserDialog ds=\"ds\" OnCreated=\"async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)\"></CreateUserDialog> ");
        }
#nullable restore
#line 196 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
                                                                                                                        );


async Task EditUserDialog(int id) => await dialogService.OpenAsync(c.l["EditRole"], ds =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(1, "<EditUserDialog ds=\"ds\" OnCreated=\"async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)\" userId=\"id\"></EditUserDialog> ");
        }
#nullable restore
#line 200 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
                                                                                                                              );


async Task ResetPasswordDialog(int id) => await dialogService.OpenAsync(c.l["CreateNewRole"], ds =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(2, "<ResetPasswordDialog ds=\"ds\" userId=\"id\"></ResetPasswordDialog>     ");
        }
#nullable restore
#line 204 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Users.razor"
                                                 );





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
#pragma warning restore 1591
