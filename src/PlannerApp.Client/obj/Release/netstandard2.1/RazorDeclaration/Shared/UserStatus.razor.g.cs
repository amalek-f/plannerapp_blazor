#pragma checksum "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Shared\UserStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71c7c701772385a5f8b557bfc4413484789c4cb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    public partial class UserStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Shared\UserStatus.razor"
       

    async Task Logout()
    {
        var localStateProvider = (LocalAuthenticationStateProvider)authenticationStateProvider;
        await localStateProvider.LogoutAsync();
        navigationManager.NavigateTo("/auth/login"); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
