// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using BookApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\_Imports.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editAuthor/{id:int}")]
    public partial class EditAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditAuthor.razor"
        

   [Parameter]
   public int id { get; set; }

   Author author = new Author();

   protected override async Task OnInitializedAsync()
   {
      author = await authorService.ReadByPk(id);
   }

   protected async Task UpdateAuthor()
   {
      await authorService.Update(author);
      navigationManager.NavigateTo("/listAuthor");
   }

   void Cancel()
   {
      navigationManager.NavigateTo("/listAuthor");
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
    }
}
#pragma warning restore 1591
