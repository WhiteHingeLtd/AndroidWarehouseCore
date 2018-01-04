using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProtoBuf;
using WhiteHingeFramework.Classes.Items;

namespace WebApiCore.Controllers.ApiControllers
{
    [Produces("application/json")]
    public class ItemDataController : Controller
    {
        [HttpPost]
        [Route("Item/SearchSkus/{query}")]
        public async Task<List<NewWhlSku>> SendDeviceLocationInfo(string query)
        {
            List<SearchSku> searchColl;
            using (var ms = new MemoryStream())
            {
                using (var file = System.IO.File.Open(@"C:\Data\SkuGen\SearchColl1.collection", FileMode.Open))
                {
                    file.CopyTo(ms);
                    ms.Position = 0;
                }

                searchColl = Serializer.Deserialize<List<SearchSku>>(ms);
            }

            var results = searchColl.Where(x => x.SearchKeywords.Contains(query));
            var returnable = new List<NewWhlSku>();
            foreach (var result in results)
            {
                returnable.Add(await WhiteHingeFrameworkExt.SkuGeneration.SkuGeneration.GenerateDataFromSku(result.Sku));
            }

            return returnable;
        }
    }
}