#pragma checksum "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57aaf8e3edc9263f2f70d2cf4c528a9df0057957"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listBook")]
    public partial class ListBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
   .sort-th {
      cursor: pointer;
   }

   .fa {
      float: right;
   }

   .btn-custom {
      color: black;
      float: left;
      padding: 8px 16px;
      text-decoration: none;
      transition: background-color .3s;
      border: 2px solid #000;
      margin: 0px 5px 0px 5px;
   }
</style>

");
            __builder.AddMarkupContent(2, "<a class=\"btn btn-primary\" href=\'/addBook\'>Add new book</a>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
 if (books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "   ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 31 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "   ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row col-md-3 pull-right");
            __builder.AddMarkupContent(8, "\r\n      ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "id", "txtSearch");
            __builder.AddAttribute(12, "placeholder", "Search Titles...");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                    SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n   ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(20, "\r\n      ");
            __builder.OpenElement(21, "thead");
            __builder.AddMarkupContent(22, "\r\n         ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "class", "sort-th");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                           () => SortTable("ISBN")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "I S B N\r\n               ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "fa" + " " + (
#nullable restore
#line 44 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("ISBN")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "class", "sort-th");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                            () => SortTable("Title")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n               T i t l e\r\n               ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "fa" + " " + (
#nullable restore
#line 49 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("Title")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "class", "sort-th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                           () => SortTable("AuthorName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "Author\r\n               ");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", "fa" + " " + (
#nullable restore
#line 53 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("AuthorName")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "th");
            __builder.AddAttribute(50, "class", "sort-th");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                           () => SortTable("PubYear")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "Pub.<br>\r\n               Year\r\n               ");
            __builder.OpenElement(53, "span");
            __builder.AddAttribute(54, "class", "fa" + " " + (
#nullable restore
#line 58 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("PubYear")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "th");
            __builder.AddAttribute(58, "class", "sort-th");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                           () => SortTable("PurchDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\r\n               Purchase<br>Date\r\n               ");
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "fa" + " " + (
#nullable restore
#line 63 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("PurchDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "th");
            __builder.AddAttribute(66, "class", "sort-th");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                           () => SortTable("PubName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "Publisher\r\n               ");
            __builder.OpenElement(69, "span");
            __builder.AddAttribute(70, "class", "fa" + " " + (
#nullable restore
#line 67 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                 SetSortIcon("PubName")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.AddMarkupContent(73, "<th>Action</th>\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n      ");
            __builder.OpenElement(76, "tbody");
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 73 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
          if (books == null || books.Count == 0)
         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "            ");
            __builder.AddMarkupContent(79, "<tr>\r\n               <td colspan=\"3\">\r\n                  No Records to display\r\n               </td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
         }
         else
         {
            long prevISBN = 0;
            foreach (var book in books)
            {
               if (@book.ISBN != prevISBN)
               {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                  ");
            __builder.OpenElement(81, "tr");
            __builder.AddMarkupContent(82, "\r\n                     ");
            __builder.OpenElement(83, "td");
            __builder.AddMarkupContent(84, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 90 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(85, book.ISBN);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                     ");
            __builder.OpenElement(87, "td");
            __builder.AddMarkupContent(88, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 92 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(89, book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                     ");
            __builder.OpenElement(91, "td");
            __builder.AddMarkupContent(92, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 94 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(93, book.AuthorName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                     ");
            __builder.OpenElement(95, "td");
            __builder.AddMarkupContent(96, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 96 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(97, book.PubYear);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                     ");
            __builder.OpenElement(99, "td");
            __builder.AddMarkupContent(100, "<hr style=\"padding:0px;  margin:0px;\">\r\n                         ");
#nullable restore
#line 98 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(101, book.PurchDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                     ");
            __builder.OpenElement(103, "td");
            __builder.AddMarkupContent(104, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 100 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(105, book.PubName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                     ");
            __builder.OpenElement(107, "td");
            __builder.AddMarkupContent(108, "<hr style=\"padding:0px; margin:0px;\">\r\n                        ");
            __builder.OpenElement(109, "a");
            __builder.AddAttribute(110, "class", "btn btn-primary");
            __builder.AddAttribute(111, "href", "/editBook/" + (
#nullable restore
#line 103 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                            book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(112, "\r\n                           &#8194;Edit&#8194;");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "&#8194;\r\n                        ");
            __builder.OpenElement(114, "a");
            __builder.AddAttribute(115, "class", "btn btn-warning");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                                             () =>
                           DeleteBook((long)book.ISBN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(117, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 109 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
               }
               else
               {

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "                  ");
            __builder.OpenElement(122, "tr");
            __builder.AddMarkupContent(123, "\r\n                     <td></td>\r\n                     <td></td>\r\n                     ");
            __builder.OpenElement(124, "td");
            __builder.AddMarkupContent(125, "<hr style=\"padding:0px; margin:0px;\">\r\n                         ");
#nullable restore
#line 116 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(126, book.AuthorName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 118 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
               }
               prevISBN = (long)@book.ISBN;
            }
         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n   ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "pagination");
            __builder.AddMarkupContent(134, "\r\n      ");
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "class", "btn btn-custom");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                                async ()=>
              await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(138, "◀");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\r\n");
#nullable restore
#line 128 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
       for (int i = startPage; i <= endPage; i++)
      {
         var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "         ");
            __builder.OpenElement(141, "button");
            __builder.AddAttribute(142, "class", "btn" + " btn-custom" + " pagebutton" + " \r\n                 " + (
#nullable restore
#line 132 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                   currentPage==curPage?"btn-info":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                            async () =>
                 await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 134 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
__builder.AddContent(144, currentPage);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(145, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 136 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "      ");
            __builder.OpenElement(148, "button");
            __builder.AddAttribute(149, "class", "btn btn-custom");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
                                                async ()=>
              await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(151, "▶");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 140 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\ListBook.razor"
       
   private string searchTerm;
   private string SearchTerm
   {
      get { return searchTerm; }
      set { searchTerm = value; FilterRecords(); }
   }

   List<BookAuPub> books;

   #region Pagination

   int totalPages;
   int totalRecords;
   int curPage;
   int pagerSize;
   int pageSize;
   int startPage;
   int endPage;
   string sortColumnName = "PurchDate";
   string sortDir = "DESC";

   #endregion

   protected override async Task OnInitializedAsync()
   {
      //display total page buttons
      pagerSize = 3;
      pageSize = 8;
      curPage = 1;
      books = await bookService.ListAll((curPage - 1) * pageSize,
              pageSize, sortColumnName, sortDir, searchTerm);
      totalRecords = await bookService.Count(searchTerm);
      totalPages = (int)Math.Ceiling
                   (totalRecords / (decimal)pageSize);
      SetPagerSize("forward");
   }

   protected async Task DeleteBook(long isbn)
   {
      await bookService.Delete(isbn);
      books = await bookService.ListAll((curPage - 1) * pageSize,
              pageSize, sortColumnName, sortDir, searchTerm);
   }

   private bool isSortedAscending;
   private string activeSortColumn;

   private async Task<List<BookAuPub>> SortRecords
           (string columnName, string dir)
   {
      return await bookService.ListAll((curPage - 1) * pageSize,
             pageSize, columnName, dir, searchTerm);
   }

   private async Task SortTable(string columnName)
   {
      if (columnName != activeSortColumn)
      {
         books = await SortRecords(columnName, "ASC");
         isSortedAscending = true;
         activeSortColumn = columnName;
      }
      else
      {
         if (isSortedAscending)
         {
            books = await SortRecords(columnName, "DESC");
         }
         else
         {
            books = await SortRecords(columnName, "ASC");
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
      books = await bookService.ListAll((currentPage - 1)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService bookService { get; set; }
    }
}
#pragma warning restore 1591