#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcf7d7a040239a2fa67822ddfed94d6bf104aa2b"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Blazor.Pages.TenantsDialogs
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
#line 1 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
using Web.Blazor.Models.Tenants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
using Web.Blazor.Models.Tenants.Results;

#line default
#line hidden
#nullable disable
    public partial class CreateTenantDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "Style", "position: inherit");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                     createTenantModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                       CreateTenantAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n\r\n        ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "form-group row required");
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenElement(14, "label");
                    __builder3.AddAttribute(15, "for", "name");
                    __builder3.AddAttribute(16, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(17, " ");
                    __builder3.AddContent(18, 
#nullable restore
#line 12 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                c.l["TenancyName"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(19, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenElement(21, "div");
                    __builder3.AddAttribute(22, "class", "col-md-9");
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                    __builder3.AddAttribute(25, "type", "text");
                    __builder3.AddAttribute(26, "name", "name");
                    __builder3.AddAttribute(27, "class", "form-control ng-untouched ng-pristine ng-invalid");
                    __builder3.AddAttribute(28, "ng-reflect-required", "");
                    __builder3.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        createTenantModel.tenancyName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTenantModel.tenancyName = __value, createTenantModel.tenancyName))));
                    __builder3.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createTenantModel.tenancyName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __Blazor.Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog.TypeInference.CreateValidationMessage_0(__builder3, 33, 34, 
#nullable restore
#line 15 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        () => createTenantModel.tenancyName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(35, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n        ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "form-group row required");
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenElement(41, "label");
                    __builder3.AddAttribute(42, "for", "displayName");
                    __builder3.AddAttribute(43, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(44, " ");
                    __builder3.AddContent(45, 
#nullable restore
#line 20 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                       c.l["Name"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(46, " ");
                    __builder3.CloseElement();
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col -md-9");
                    __builder3.AddMarkupContent(49, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                    __builder3.AddAttribute(51, "type", "text");
                    __builder3.AddAttribute(52, "name", "displayName");
                    __builder3.AddAttribute(53, "class", "form-control ng-untouched ng-pristine ng-invalid");
                    __builder3.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        createTenantModel.name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTenantModel.name = __value, createTenantModel.name))));
                    __builder3.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createTenantModel.name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n                ");
                    __Blazor.Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog.TypeInference.CreateValidationMessage_1(__builder3, 58, 59, 
#nullable restore
#line 22 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        () => createTenantModel.name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(60, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n\r\n        ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "form-group row required");
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.OpenElement(66, "label");
                    __builder3.AddAttribute(67, "for", "displayName");
                    __builder3.AddAttribute(68, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(69, " ");
                    __builder3.AddContent(70, 
#nullable restore
#line 28 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                       c.l["DatabaseConnectionString"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(71, " ");
                    __builder3.CloseElement();
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col -md-9");
                    __builder3.AddMarkupContent(74, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                    __builder3.AddAttribute(76, "type", "text");
                    __builder3.AddAttribute(77, "name", "displayName");
                    __builder3.AddAttribute(78, "class", "form-control ng-untouched ng-pristine ng-invalid");
                    __builder3.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        createTenantModel.connectionString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTenantModel.connectionString = __value, createTenantModel.connectionString))));
                    __builder3.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createTenantModel.connectionString));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n                ");
                    __Blazor.Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog.TypeInference.CreateValidationMessage_2(__builder3, 83, 84, 
#nullable restore
#line 30 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        () => createTenantModel.connectionString

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(85, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n        ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "form-group row required");
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.OpenElement(91, "label");
                    __builder3.AddAttribute(92, "for", "displayName");
                    __builder3.AddAttribute(93, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(94, " ");
                    __builder3.AddContent(95, 
#nullable restore
#line 35 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                       c.l["AdminEmailAddress"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(96, " ");
                    __builder3.CloseElement();
                    __builder3.OpenElement(97, "div");
                    __builder3.AddAttribute(98, "class", "col -md-9");
                    __builder3.AddMarkupContent(99, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                    __builder3.AddAttribute(101, "type", "text");
                    __builder3.AddAttribute(102, "name", "displayName");
                    __builder3.AddAttribute(103, "class", "form-control ng-untouched ng-pristine ng-invalid");
                    __builder3.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        createTenantModel.adminEmailAddress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTenantModel.adminEmailAddress = __value, createTenantModel.adminEmailAddress))));
                    __builder3.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createTenantModel.adminEmailAddress));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\r\n                ");
                    __Blazor.Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog.TypeInference.CreateValidationMessage_3(__builder3, 108, 109, 
#nullable restore
#line 37 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                        () => createTenantModel.adminEmailAddress

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(110, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n        ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col-md-9");
                    __builder3.AddMarkupContent(115, "\r\n            ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "custom-control custom-checkbox");
                    __builder3.AddMarkupContent(118, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(119);
                    __builder3.AddAttribute(120, "type", "checkbox");
                    __builder3.AddAttribute(121, "class", "custom-control-input");
                    __builder3.AddAttribute(122, "id", "ac");
                    __builder3.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                                  async () => await isActiveClick()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                            createTenantModel.isActive

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTenantModel.isActive = __value, createTenantModel.isActive))));
                    __builder3.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => createTenantModel.isActive));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\r\n                ");
                    __builder3.OpenElement(128, "label");
                    __builder3.AddAttribute(129, "class", "custom-control-label");
                    __builder3.AddAttribute(130, "for", "ac");
                    __builder3.AddMarkupContent(131, "\r\n                    ");
                    __builder3.AddContent(132, 
#nullable restore
#line 46 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                     c.l["IsActive"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(133, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\r\n\r\n        <br>\r\n        ");
                    __builder3.OpenElement(137, "div");
                    __builder3.AddAttribute(138, "class", "modal-footer justify-content-between");
                    __builder3.AddMarkupContent(139, "\r\n            ");
                    __builder3.OpenElement(140, "button");
                    __builder3.AddAttribute(141, "type", "button");
                    __builder3.AddAttribute(142, "class", "btn btn-default");
                    __builder3.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                                                                    ()=> ds.Close()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(144, "\r\n                ");
                    __builder3.AddContent(145, 
#nullable restore
#line 54 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                 c.l["Cancel"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(146, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\r\n\r\n            ");
                    __builder3.OpenElement(148, "button");
                    __builder3.AddAttribute(149, "type", "submit");
                    __builder3.AddAttribute(150, "class", "btn btn-primary");
                    __builder3.AddMarkupContent(151, "\r\n                ");
                    __builder3.AddContent(152, 
#nullable restore
#line 58 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
                 c.l["Save"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(153, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\TenantsDialogs\CreateTenantDialog.razor"
       
    CreateTenantDto createTenantModel = new CreateTenantDto();

    [Parameter]
    public DialogService ds { get; set; }
    [Parameter]
    public EventCallback<bool> OnCreated { get; set; }

    protected override async Task OnInitializedAsync()
    {
        createTenantModel.isActive = true;
        await Task.FromResult(createTenantModel.isActive);

    }

    async Task isActiveClick()
    {
        createTenantModel.isActive = !createTenantModel.isActive;
        await Task.FromResult(createTenantModel.isActive);
    }

    async Task CreateTenantAsync()
    {
        var response = await tenant.Create(createTenantModel);
        if (response.success)
        {
            notificationService.Notify(new NotificationMessage()
            {
                Severity = NotificationSeverity.Success,
                Summary = c.l["SavedSuccessfully"],
                Detail = "",
                Duration = 3000
            });
            await OnCreated.InvokeAsync(true);

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
        ds.Close();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService tenant { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
namespace __Blazor.Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
