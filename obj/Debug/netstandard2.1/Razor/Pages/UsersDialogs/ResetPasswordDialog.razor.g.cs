#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3c401e62b254b2a5c64342cea677acd710eba83"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Blazor.Pages.UsersDialogs
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
#line 1 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
using Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
using Models.User.Results;

#line default
#line hidden
#nullable disable
    public partial class ResetPasswordDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "Style", "position: inherit");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                         resetPasswordModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                            ResetPasswordAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n\r\n            ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "col-md-9 offset-md-3");
                    __builder3.OpenElement(13, "p");
                    __builder3.AddAttribute(14, "class", "text-info mb-1");
                    __builder3.AddContent(15, " ");
                    __builder3.AddContent(16, 
#nullable restore
#line 9 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                                          c.l["ResetPasswordStepOneInfo"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(17, " ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n\r\n            ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "form-group row required");
                    __builder3.AddMarkupContent(21, "\r\n                ");
                    __builder3.OpenElement(22, "label");
                    __builder3.AddAttribute(23, "for", "name");
                    __builder3.AddAttribute(24, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(25, " ");
                    __builder3.AddContent(26, 
#nullable restore
#line 12 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                                    c.l["AdminPassword"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(27, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n                ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                    __builder3.AddAttribute(33, "type", "password");
                    __builder3.AddAttribute(34, "class", "form-control ");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                            resetPasswordModel.adminPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => resetPasswordModel.adminPassword = __value, resetPasswordModel.adminPassword))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => resetPasswordModel.adminPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                    ");
                    __Blazor.Web.Blazor.Pages.UsersDialogs.ResetPasswordDialog.TypeInference.CreateValidationMessage_0(__builder3, 39, 40, 
#nullable restore
#line 15 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                            () => resetPasswordModel.adminPassword

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(41, "\r\n\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-9 offset-md-3");
                    __builder3.OpenElement(46, "p");
                    __builder3.AddAttribute(47, "class", "text-info mb-1");
                    __builder3.AddContent(48, " ");
                    __builder3.AddContent(49, 
#nullable restore
#line 19 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                                          c.l["ResetPasswordStepTwoInfo"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(50, " ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n            ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "form-group row required");
                    __builder3.AddMarkupContent(54, "\r\n                ");
                    __builder3.OpenElement(55, "label");
                    __builder3.AddAttribute(56, "for", "name");
                    __builder3.AddAttribute(57, "class", "col-md-3 col-form-label");
                    __builder3.AddContent(58, " ");
                    __builder3.AddContent(59, 
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                                    c.l["NewPassword"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(60, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-9");
                    __builder3.AddMarkupContent(64, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                    __builder3.AddAttribute(66, "type", "password");
                    __builder3.AddAttribute(67, "class", "form-control ");
                    __builder3.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                            resetPasswordModel.newPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => resetPasswordModel.newPassword = __value, resetPasswordModel.newPassword))));
                    __builder3.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => resetPasswordModel.newPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n                    ");
                    __Blazor.Web.Blazor.Pages.UsersDialogs.ResetPasswordDialog.TypeInference.CreateValidationMessage_1(__builder3, 72, 73, 
#nullable restore
#line 24 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                            () => resetPasswordModel.newPassword

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(74, "\r\n\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n            <br>\r\n            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "modal-footer justify-content-between");
                    __builder3.AddMarkupContent(79, "\r\n                ");
                    __builder3.OpenElement(80, "button");
                    __builder3.AddAttribute(81, "type", "button");
                    __builder3.AddAttribute(82, "class", "btn btn-default");
                    __builder3.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                                                                        ()=> ds.Close()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(84, "\r\n                    ");
                    __builder3.AddContent(85, 
#nullable restore
#line 31 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                     c.l["Cancel"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(86, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n\r\n                ");
                    __builder3.OpenElement(88, "button");
                    __builder3.AddAttribute(89, "type", "submit");
                    __builder3.AddAttribute(90, "class", "btn btn-primary");
                    __builder3.AddMarkupContent(91, "\r\n                    ");
                    __builder3.AddContent(92, 
#nullable restore
#line 35 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
                     c.l["Save"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(93, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\UsersDialogs\ResetPasswordDialog.razor"
               
            ResetPasswordDto resetPasswordModel = new ResetPasswordDto();

            [Parameter]
            public DialogService ds { get; set; }
            [Parameter]
            public int userId { get; set; }

            protected override async Task OnInitializedAsync()
            {
                resetPasswordModel.userId = userId;
                await Task.FromResult(resetPasswordModel.userId);
            }


            async Task ResetPasswordAsync()
            {

                var response = await user.ResetPassword(resetPasswordModel);
                if (response.success)
                {
                    notificationService.Notify(new NotificationMessage()
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = c.l["SavedSuccessfully"],
                        Detail = "",
                        Duration = 3000
                    });
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
namespace __Blazor.Web.Blazor.Pages.UsersDialogs.ResetPasswordDialog
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
    }
}
#pragma warning restore 1591
