#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03950175d9d101b7a3c96038ce4cd89ef895b34c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
using Web.Blazor.Models.Tenants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
using Web.Blazor.Models.Tenants.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
using Web.Blazor.Pages.TenantsDialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
           [Authorize(Policy = "Tenants")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tenants")]
    public partial class Tenants : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "content-header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-6");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "h1");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                     c.l["Tenants"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-6 text-right");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                          async () => await CreateTenantDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n                    <i class=\"fa fa-plus-square\"></i>\r\n                    ");
            __builder.AddContent(23, 
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                     c.l["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "section");
            __builder.AddAttribute(31, "class", "content px-2 loading");
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container-fluid");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.AddMarkupContent(38, "\r\n\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-header");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(42);
            __builder.AddAttribute(43, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                 searchKeyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "input-group");
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "input-group-prepend");
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "type", "submit");
                __builder2.AddAttribute(54, "class", "btn btn-primary");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                     () =>  refreshResult(searchKeyword.keyword,0)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(56, "\r\n                                <i class=\"fas fa-search\"></i>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", 
#nullable restore
#line 39 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                      c.l["SearchWithThreeDot"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                              searchKeyword.keyword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchKeyword.keyword = __value, searchKeyword.keyword))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => searchKeyword.keyword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-body table-responsive p-0");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<TenantDto>>(72);
            __builder.AddAttribute(73, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TenantDto>>(
#nullable restore
#line 46 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                     pageTenants

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<TenantDto>>(76);
                __builder2.AddAttribute(77, "Property", "TenancyName");
                __builder2.AddAttribute(78, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                           c.l["RoleName"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<TenantDto>>(80);
                __builder2.AddAttribute(81, "Property", "Name");
                __builder2.AddAttribute(82, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                    c.l["DisplayName"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<TenantDto>>(84);
                __builder2.AddAttribute(85, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                         c.l["IsActive"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Width", "80px");
                __builder2.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TenantDto>)((tenantdata) => (__builder3) => {
                    __builder3.AddMarkupContent(88, "\r\n                                ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "custom-control custom-checkbox");
                    __builder3.AddMarkupContent(91, "\r\n                                    ");
                    __builder3.OpenElement(92, "input");
                    __builder3.AddAttribute(93, "type", "checkbox");
                    __builder3.AddAttribute(94, "class", "custom-control-input disabled");
                    __builder3.AddAttribute(95, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                        tenantdata.IsActive

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tenantdata.IsActive = __value, tenantdata.IsActive));
                    __builder3.SetUpdatesAttributeName("checked");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n                                    <label class=\"custom-control-label\"></label>\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<TenantDto>>(100);
                __builder2.AddAttribute(101, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                         c.l["Actions"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "Width", "200px");
                __builder2.AddAttribute(103, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TenantDto>)((tenantdata) => (__builder3) => {
                    __builder3.AddMarkupContent(104, "\r\n                                ");
                    __builder3.OpenElement(105, "button");
                    __builder3.AddAttribute(106, "type", "button");
                    __builder3.AddAttribute(107, "class", "btn btn-sm btn-secondary");
                    __builder3.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                 async () => await EditTenantDialog(tenantdata.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(109, "\r\n                                    <i class=\"fas fa-pencil-alt\"></i>\r\n                                    ");
                    __builder3.AddContent(110, 
#nullable restore
#line 62 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                     c.l["Edit"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(111, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n                                ");
                    __builder3.OpenElement(113, "button");
                    __builder3.AddAttribute(114, "type", "button");
                    __builder3.AddAttribute(115, "class", "btn btn-sm btn-danger mx-2");
                    __builder3.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                   async () => await DeleteTenat(tenantdata.Id,tenantdata.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(117, "\r\n                                    <i class=\"fas fa-trash\"></i>\r\n                                    ");
                    __builder3.AddContent(118, 
#nullable restore
#line 66 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                     c.l["Delete"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(119, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n\r\n\r\n\r\n            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "card-footer bg-light border-top");
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "row");
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-sm-4 col-12 text-sm-left text-center");
            __builder.AddMarkupContent(132, "\r\n                        ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-secondary");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                       async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(136, "\r\n                            <i class=\"fas fa-redo-alt\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                    ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-sm-4 col-12 text-center");
            __builder.AddMarkupContent(141, "\r\n                        ");
            __builder.OpenElement(142, "p");
            __builder.AddAttribute(143, "class", "mb-0 my-2");
            __builder.AddMarkupContent(144, "\r\n                            ");
            __builder.AddContent(145, 
#nullable restore
#line 87 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                             c.l["TotalRecordsCount"].Replace("{0}", totalTenants.ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(146, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "col-sm-4 col-12");
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "float-sm-right m-auto");
            __builder.AddMarkupContent(154, "\r\n\r\n                            ");
            __builder.OpenElement(155, "nav");
            __builder.AddMarkupContent(156, "\r\n                                ");
            __builder.OpenElement(157, "ul");
            __builder.AddAttribute(158, "class", "pagination m-0 ng-star-inserted");
            __builder.AddAttribute(159, "style", true);
            __builder.AddMarkupContent(160, "\r\n\r\n\r\n                                    ");
            __builder.OpenElement(161, "li");
            __builder.AddAttribute(162, "class", "page-item" + " ng-star-inserted" + " " + (
#nullable restore
#line 97 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                            (currentPage == 1) ? @disabled : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(163, "\r\n                                        ");
            __builder.OpenElement(164, "a");
            __builder.AddAttribute(165, "class", "page-link ng-star-inserted");
            __builder.AddAttribute(166, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                           async () => await refreshResult(searchKeyword.keyword,(currentPage-2)*10)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(167, "\r\n                                            <i class=\"fas fa-chevron-left\"></i>\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 105 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                     for (int i = 1; i < pages + 1; i++)
                                    {
                                        int pageNum = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "                                        ");
            __builder.OpenElement(171, "li");
            __builder.AddAttribute(172, "class", "page-item" + " " + (
#nullable restore
#line 108 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                               (currentPage == pageNum) ? @active : ""

#line default
#line hidden
#nullable disable
            ) + " ng-star-inserted");
            __builder.AddAttribute(173, "style", "z-index: 0;");
            __builder.AddMarkupContent(174, "\r\n                                            ");
            __builder.OpenElement(175, "a");
            __builder.AddAttribute(176, "class", "page-link");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                              async () => await refreshResult(searchKeyword.keyword,(pageNum*10-10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(178, " ");
            __builder.AddContent(179, 
#nullable restore
#line 109 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                                                                         i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(180, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n");
#nullable restore
#line 111 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(183, "                                    ");
            __builder.OpenElement(184, "li");
            __builder.AddAttribute(185, "class", "page-item" + " ng-star-inserted" + " " + (
#nullable restore
#line 112 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                            (currentPage == pages) ? @disabled : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(186, "\r\n                                        ");
            __builder.OpenElement(187, "a");
            __builder.AddAttribute(188, "class", "page-link ng-star-inserted");
            __builder.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                           async () => await refreshResult(searchKeyword.keyword,(currentPage*10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(190, "<i class=\"fas fa-chevron-right\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
       
    SearchKeyword searchKeyword = new SearchKeyword();

    int MaxResultCount = 10;
    int pages = 1;
    int currentPage = 1;
    int totalTenants = 0;
    List<TenantDto> pageTenants = new List<TenantDto>();

    string disabled = "disabled";
    string active = "active";

    protected override async Task OnInitializedAsync()
    {

        await refreshResult("", 0);
    }

    private async Task refreshResult(string word, int skip)
    {
        Console.WriteLine(word);
        var response = await tenant.GetAll(word, skip, MaxResultCount);
        pageTenants = response.result.items;
        totalTenants = response.result.totalCount;
        pages = 1 + ((totalTenants - 1) / MaxResultCount);
        if (currentPage <= pages)
        {
            currentPage = (skip / 10) + 1;
        }
        else
        {
            currentPage = (skip / 10);
        }
    }


    async Task CreateTenantDialog() => await dialogService.OpenAsync(c.l["CreateNewTenant"], ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Web.Blazor.Pages.TenantsDialogs.CreateTenantDialog>(201);
            __builder2.AddAttribute(202, "ds", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DialogService>(
#nullable restore
#line 165 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                             ds

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(203, "OnCreated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 165 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                            async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)

#line default
#line hidden
#nullable disable
            )));
            __builder2.CloseComponent();
            __builder2.AddContent(204, "             ");
        }
#nullable restore
#line 165 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                                                      );
    
    async Task EditTenantDialog(int id) => await dialogService.OpenAsync(c.l["EditTenant"], ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Web.Blazor.Pages.TenantsDialogs.EditTenantDialog>(205);
            __builder2.AddAttribute(206, "ds", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DialogService>(
#nullable restore
#line 168 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                           ds

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(207, "OnCreated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 168 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                          async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(208, "tenantId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 168 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                                               id

#line default
#line hidden
#nullable disable
            ));
            __builder2.CloseComponent();
            __builder2.AddContent(209, "             ");
        }
#nullable restore
#line 168 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Tenants.razor"
                                                                                                                                                  );

    private async Task DeleteTenat(int id, string tenantName)
    {
        var dialogResult = await dialogService.Confirm(c.l["TenantDeleteWarningMessage"].Replace("{0}", tenantName), c.l["AreYouSureWantToDelete"].Replace("{0}", tenantName), new ConfirmOptions() { OkButtonText = c.l["Yes"], CancelButtonText = c.l["No"] });
        if (dialogResult.HasValue && dialogResult.Value)
        {
            var response = await tenant.Delete(id);
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService tenant { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
#pragma warning restore 1591
