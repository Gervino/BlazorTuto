using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFileUpload.Service
{
    interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
