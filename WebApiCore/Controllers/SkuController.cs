using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WhiteHingeFramework.Classes.Items;
using WhiteHingeFrameworkExt.Models;

namespace WebApiCore.Controllers
{
    public class SkuController : Controller
    {
        
        public SkuController()
        {

        }

        private List<NewWhlSku> LoadCollection()
        {
            var ms = new MemoryStream();
            using (var file = System.IO.File.Open(@"C:\Data\SkuGen\Skus1.collection", FileMode.Open))
            {
                file.CopyTo(ms);
            }
            ms.Position = 0;
            var skus = Serializer.Deserialize<List<NewWhlSku>>(ms);
            ms.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return skus;
        }
        
        public async Task<ActionResult> Index(string sortOrder,string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "sku_desc" : "";
            ViewData["SalesSortParm"] = sortOrder == "Sales" ? "sales_desc" : "Sales";
            ViewData["SearchString"] = searchString;
            List<NewWhlSku> skus;
            if (string.IsNullOrWhiteSpace(searchString))
            {
                skus = LoadCollection();
            }
            else
            {
                var results = new List<string>();
                using (var context = new WhiteHingeContext())
                {
                    results.AddRange(context.SkuKeywords.Where(x => x.Keyword == searchString && x.KeywordType == (int)KeywordType.SearchKeyword).Select(x => x.Sku).Distinct());
                }

                skus = results.Select(result =>
                    WhiteHingeFrameworkExt.SkuGeneration.SkuGeneration.GenerateDataFromSku(result).Result).ToList();
            }

            switch (sortOrder)
            {
                case "sku_desc":
                    skus = skus.OrderByDescending(x => x.Sku).ToList();
                    break;
                case "Sales":
                    skus = skus.OrderBy(x => x.SalesData.Weighted).ToList();
                    break;
                case "sales_desc":
                    skus = skus.OrderByDescending(x => x.SalesData.Weighted).ToList();
                    break;
                default:
                    break;
            }

            GC.Collect();
            var items = HttpContext.Items.Keys.ToList();
            Console.WriteLine(items.Count);
            return View(skus.Take(100));
        }
        /// <summary>
        /// Generates the SKU from the given parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Sku/Details/5
        public ActionResult Details(string id)
        {
            return View(WhiteHingeFrameworkExt.SkuGeneration.SkuGeneration.GenerateDataFromSku(id).Result);
        }

        //// GET: Sku/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Sku/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Sku/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    return View();
        //}

        // POST: Sku/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(string id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Sku/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    return View();
        //}

        //// POST: Sku/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(string id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}