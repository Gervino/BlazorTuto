#pragma checksum "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d5a985d21e6c3ef210adfe25096543c409f8032"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFileUpload.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using BlazorFileUpload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using BlazorFileUpload.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
using BlazorFileUpload.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/autocomplete")]
    public partial class AutoComplete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AutoComplete - Autocomplete in blazor | Blazored Typehead</h3>\r\n\r\n");
            __Blazor.BlazorFileUpload.Pages.AutoComplete.TypeInference.CreateBlazoredTypeahead_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
                                 SearchProducts

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 8 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
                                                              SelectedProduct

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedProduct = __value, SelectedProduct)), 5, () => SelectedProduct, 6, (context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddContent(8, 
#nullable restore
#line 10 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
         context.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            , 10, (context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddContent(12, 
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
         context.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, " ");
                __builder2.OpenElement(14, "strong");
                __builder2.AddContent(15, 
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
                                      context.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(17, "\r\n\r\n");
#nullable restore
#line 17 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
 if (SelectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Selected Product is : ");
            __builder.AddContent(21, 
#nullable restore
#line 19 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
                              SelectedProduct.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 20 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\AutoComplete.razor"
       
    private List<Product> products;
    private Product SelectedProduct;

    protected override void OnInitialized()
    {
        products = new List<Product>
        {
            new Product("Computer", 50000),
            new Product("Computer", 50000),
            new Product("Mouse", 2000),
            new Product("keyboard", 300),
        };
    }

    private async Task<IEnumerable<Product>> SearchProducts(string searcheText) {
        return await Task.FromResult(products.Where(x => x.ProductName.ToLower().Contains(searcheText.ToLower())).ToList());
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorFileUpload.Pages.AutoComplete
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazoredTypeahead_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg5)
        {
        __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "SelectedTemplate", __arg4);
        __builder.AddAttribute(__seq5, "ResultTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
