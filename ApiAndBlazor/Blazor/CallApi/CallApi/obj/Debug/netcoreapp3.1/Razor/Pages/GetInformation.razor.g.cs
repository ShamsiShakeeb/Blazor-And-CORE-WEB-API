#pragma checksum "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693d2549634c9bc013bcf673c547ce023d388076"
// <auto-generated/>
#pragma warning disable 1591
namespace CallApi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using CallApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\_Imports.razor"
using CallApi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/getinformation")]
    public partial class GetInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GetInformation</h3>\r\n\r\n");
#nullable restore
#line 7 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor"
 foreach (var item in data)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 9 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor"
         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 10 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\DotNetProject\ApiAndBlazor\Blazor\CallApi\CallApi\Pages\GetInformation.razor"
       

    List<Data.MInformation> data = new List<Data.MInformation>();

    protected override async Task OnInitializedAsync()
    {
        ////Install-Package Microsoft.AspNetCore.Blazor.HttpClient -Version 3.2.0-preview3.20168.3

        data = await info.GetInfo();
        await base.OnInitializedAsync();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IGetInformation info { get; set; }
    }
}
#pragma warning restore 1591