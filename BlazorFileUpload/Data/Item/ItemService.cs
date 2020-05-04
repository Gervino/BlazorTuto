using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFileUpload.Data.Item
{
    public class ItemService
    {
        public Task<ItemInfo[]> GetItemInfo()
        {
            var range = new Random();
            int ivalue = 0;
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new ItemInfo
            {
                ItemName = "Item - " + range.Next(1, 100),
                ItemQty = range.Next(2, 100)
            }).ToArray());

        }
    }
}
