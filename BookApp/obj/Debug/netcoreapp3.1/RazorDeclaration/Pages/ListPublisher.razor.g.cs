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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listPublisher")]
    public partial class ListPublisher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListPublisher.razor"
       
   private string searchTerm;
   private string SearchTerm
   {
      get { return searchTerm; }
      set { searchTerm = value; FilterRecords(); }
   }

   List<Publisher> publishers;

   #region Pagination

   int totalPages;
   int totalRecords;
   int curPage;
   int pagerSize;
   int pageSize;
   int startPage;
   int endPage;
   string sortColumnName = "Id";
   string sortDir = "ASC";

   #endregion

   protected override async Task OnInitializedAsync()
   {
      //display total page buttons
      pagerSize = 3;
      pageSize = 5;
      curPage = 1;
      publishers = await publisherService.ListAll((curPage - 1) * 
         pageSize, pageSize, sortColumnName, sortDir, searchTerm);
      totalRecords = await publisherService.Count(searchTerm);
      totalPages = (int)Math.Ceiling
                   (totalRecords / (decimal)pageSize);
      SetPagerSize("forward");
   }

   protected async Task DeletePublisher(int id)
   {
      await publisherService.Delete(id);
      publishers = await publisherService.ListAll((curPage - 1) * 
         pageSize, pageSize, sortColumnName, sortDir, searchTerm);
   }

   private bool isSortedAscending;
   private string activeSortColumn;

   private async Task<List<Publisher>>
           SortRecords(string columnName, string dir)
   {
      return await publisherService.ListAll((curPage - 1)*pageSize,
         pageSize, columnName, dir, searchTerm);
   }

   private async Task SortTable(string columnName)
   {
      if (columnName != activeSortColumn)
      {
         publishers = await SortRecords(columnName, "ASC");
         isSortedAscending = true;
         activeSortColumn = columnName;
      }
      else
      {
         if (isSortedAscending)
         {
            publishers = await SortRecords(columnName, "DESC");
         }
         else
         {
            publishers = await SortRecords(columnName, "ASC");
         }

         isSortedAscending = !isSortedAscending;
      }
      sortColumnName = columnName;
      sortDir = isSortedAscending ? "ASC" : "DESC";
   }

   private string SetSortIcon(string columnName)
   {
      if (activeSortColumn != columnName)
      {
         return string.Empty;
      }
      if (isSortedAscending)
      {
         return "fa-sort-up";
      }
      else
      {
         return "fa-sort-down";
      }
   }

   public async Task refreshRecords(int currentPage)
   {
      publishers = await publisherService.ListAll((currentPage - 1)
         * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
      curPage = currentPage;
      this.StateHasChanged();
   }

   public void SetPagerSize(string direction)
   {
      if (direction == "forward" && endPage < totalPages)
      {
         startPage = endPage + 1;
         if (endPage + pagerSize < totalPages)
         {
            endPage = startPage + pagerSize - 1;
         }
         else
         {
            endPage = totalPages;
         }
         this.StateHasChanged();
      }
      else if (direction == "back" && startPage > 1)
      {
         endPage = startPage - 1;
         startPage = startPage - pagerSize;
      }
      else
      {
         startPage = 1;
         endPage = totalPages;
      }
   }

   public async Task NavigateToPage(string direction)
   {
      if (direction == "next")
      {
         if (curPage < totalPages)
         {
            if (curPage == endPage)
            {
               SetPagerSize("forward");
            }
            curPage += 1;
         }
      }
      else if (direction == "previous")
      {
         if (curPage > 1)
         {
            if (curPage == startPage)
            {
               SetPagerSize("back");
            }
            curPage -= 1;
         }
      }
      await refreshRecords(curPage);
   }

   public void FilterRecords()
   {
      endPage = 0;
      this.OnInitializedAsync().Wait();
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
#pragma warning restore 1591
