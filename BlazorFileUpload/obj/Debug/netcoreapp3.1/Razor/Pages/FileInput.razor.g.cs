#pragma checksum "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0cf1ad39e1e3343636e957519eeb4f993baf77c"
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
#line 3 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
using BlazorFileUpload.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fileinput")]
    public partial class FileInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FileInput - File Upload With Blazor</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 7 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
                     HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
 if (file != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Name: ");
            __builder.AddContent(7, 
#nullable restore
#line 11 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
              file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Size in Bytes: ");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
                       file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "File type: ");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
                   file.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 14 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\kouge\source\repos\BlazorFileUpload\BlazorFileUpload\Pages\FileInput.razor"
       

    IFileListEntry file;
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if(file != null)
        {
            await fileUpload.UploadAsync(file);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
