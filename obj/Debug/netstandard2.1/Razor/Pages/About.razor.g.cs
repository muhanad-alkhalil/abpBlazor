#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d5ba71039ba26abe670786b7686d38da762447"
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
#line 3 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\About.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/About")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>About</h1>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"card\" role=\"alert\">\r\n    <div class=\"card-body\">\r\n        <i class=\"fas fa-code\"></i>\r\n        Experimental Blazor Wasm Application Created by Muhanad Alkhalil.\r\n    </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
#pragma warning restore 1591
