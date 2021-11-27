#pragma checksum "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5e96386a211180c1f8e4b367a7202241cb29bc"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editBook/{isbn:long}")]
    public partial class EditBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>\r\n   Edit Book\r\n</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n   ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "width", "100%");
            __builder.AddAttribute(5, "cellpadding", "0");
            __builder.AddAttribute(6, "cellspacing", "0");
            __builder.AddAttribute(7, "border", "0");
            __builder.AddMarkupContent(8, "\r\n      ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n         ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<td>\r\n               <label for=\"ISBN\" class=\"control-label\">\r\n                  ISBN\r\n               </label>\r\n            </td>\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "for", "ISBN");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                         book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.ISBN = __value, book.ISBN));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n         ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<td><label for=\"Title\" class=\"control-label\">\r\n                       Title</label></td>\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "for", "Title");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                               book.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Title = __value, book.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n         ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<td><label for=\"Authors\" class=\"control-label\">\r\n                       Authors</label></td>\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n               ");
            __builder.AddMarkupContent(38, "<label style=\"width: 95px;\">\r\n                      <u><i><b>Sequence</b></i></u></label>\r\n               ");
            __builder.AddMarkupContent(39, "<label><u><i><b>Full Name</b></i></u></label><br>\r\n");
#nullable restore
#line 34 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                foreach (var bookAuthorName in bookAuthorNames)
               {                 

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                  ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "number");
            __builder.AddAttribute(43, "style", "width: 75px;");
            __builder.AddAttribute(44, "min", "0");
            __builder.AddAttribute(45, "max", "5");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                 bookAuthorName.AuthorOrd

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => bookAuthorName.AuthorOrd = __value, bookAuthorName.AuthorOrd, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "       \r\n");
#nullable restore
#line 40 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                   if (@bookAuthorName.ISBN > 0)
                  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                     ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "name", "AreChecked");
            __builder.AddAttribute(52, "type", "checkbox");
            __builder.AddAttribute(53, "value", 
#nullable restore
#line 43 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                    bookAuthorName.AuthorId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "checked", true);
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                       eventArgs => { CheckChanged(bookAuthorName, eventArgs.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 45 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                     ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "name", "AreChecked");
            __builder.AddAttribute(60, "type", "checkbox");
            __builder.AddAttribute(61, "value", 
#nullable restore
#line 49 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                    bookAuthorName.AuthorId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                       eventArgs => { CheckChanged(bookAuthorName, eventArgs.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 51 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                  }

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                  ");
            __builder.OpenElement(65, "label");
            __builder.AddAttribute(66, "for", "AuthorName");
            __builder.AddAttribute(67, "style", "width: 150px;");
            __builder.AddMarkupContent(68, "\r\n                         ");
#nullable restore
#line 53 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
__builder.AddContent(69, bookAuthorName.AuthorName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "<br>\r\n");
#nullable restore
#line 54 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "td");
            __builder.AddMarkupContent(74, "\r\n               &#8201;\r\n               ");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "href", "/addAuthor/" + (
#nullable restore
#line 59 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                    book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "\r\n                  &#8194;Add author&#8194;");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "<br>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n         ");
            __builder.OpenElement(82, "tr");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.AddMarkupContent(84, "<td><label for=\"PubYear\" class=\"control-label\">\r\n                       Publication Year</label></td>\r\n            ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "for", "PubYear");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                               book.PubYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PubYear = __value, book.PubYear));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n         ");
            __builder.OpenElement(93, "tr");
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.AddMarkupContent(95, "<td><label for=\"PurchDate\" class=\"control-label\">\r\n                       Purchase Date</label></td>\r\n            ");
            __builder.OpenElement(96, "td");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "date");
            __builder.AddAttribute(99, "class", "form-control");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                               book.PurchDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PurchDate = __value, book.PurchDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n         ");
            __builder.OpenElement(104, "tr");
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.AddMarkupContent(106, "<td><label for=\"Publisher\" class=\"control-label\">\r\n                       Publisher</label></td>\r\n            ");
            __builder.OpenElement(107, "td");
            __builder.AddMarkupContent(108, "\r\n               ");
            __builder.OpenElement(109, "select");
            __builder.AddAttribute(110, "for", "Publisher");
            __builder.AddAttribute(111, "class", "form-control");
            __builder.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                          book.PubId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PubId = __value, book.PubId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 81 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                   foreach (var publisher in publishers)
                  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                     ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", 
#nullable restore
#line 83 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                     publisher.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(118, "\r\n                             ");
#nullable restore
#line 84 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
__builder.AddContent(119, publisher.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 85 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                  }

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.OpenElement(124, "td");
            __builder.AddMarkupContent(125, "\r\n               &#8201;\r\n               ");
            __builder.OpenElement(126, "a");
            __builder.AddAttribute(127, "class", "btn btn-primary");
            __builder.AddAttribute(128, "href", "/addPublisher/" + (
#nullable restore
#line 91 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                       book.ISBN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(129, "Add publisher");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n         ");
            __builder.OpenElement(133, "tr");
            __builder.AddMarkupContent(134, "\r\n            <td></td>\r\n            ");
            __builder.OpenElement(135, "td");
            __builder.AddMarkupContent(136, "\r\n               <br>\r\n               ");
            __builder.OpenElement(137, "button");
            __builder.AddAttribute(138, "type", "button");
            __builder.AddAttribute(139, "class", "btn btn-primary");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                 () => UpdateBook()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(141, "\r\n                  &#8195;Save&#8195;\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "&#8194;\r\n               ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "type", "button");
            __builder.AddAttribute(145, "class", "btn btn-warning");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
                                 () => Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(147, "\r\n                  &#8194;&#8201;Cancel&#8201;&#8194;\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\micha\Documents\GitHub\BlazorServerP5\BookApp\Pages\EditBook.razor"
        

   [Parameter] public long isbn { get; set; }

   Book book = new Book();
   BookAuthorName bookAuthorName = new BookAuthorName();
   List<Publisher> publishers = new List<Publisher>();
   List<BookAuthorName>bookAuthorNames = new List<BookAuthorName>();

   protected override async Task OnInitializedAsync()
   {
      book = await bookService.ReadByPk(isbn);
      bookAuthorNames = await bookAuthorService.FetchAll(isbn);
      publishers = await publisherService.FetchAll();
   }

   protected async Task CheckChanged(BookAuthorName bookAuthorName,
                                     object checkValue)
   {
      if ((bool)checkValue)
      {
         // insert
         bookAuthorName.ISBN = isbn;
         await bookAuthorService.Create(bookAuthorName);
      }
      else
      {
         //delete
         bookAuthorName.AuthorOrd = null;
         await bookAuthorService.Delete(isbn, bookAuthorName.AuthorId);
      }
      bookAuthorNames = await bookAuthorService.FetchAll(isbn);
   }

   protected async Task UpdateBook()
   {
      await bookService.Update(book, isbn);
      navigationManager.NavigateTo("/listBook");
   }

   void Cancel()
   {
      navigationManager.NavigateTo("/listBook");
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookAuthorService bookAuthorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService bookService { get; set; }
    }
}
#pragma warning restore 1591
