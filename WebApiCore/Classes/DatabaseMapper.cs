using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteHingeFramework.Classes;
using WhiteHingeFramework.Classes.Items;
using WhiteHingeFramework.Classes.Orders;
using WhiteHingeFrameworkExt.PickingModels;

namespace WebApiCore.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public static class DatabaseMapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static async Task<NewOrder> FindOrderFromId(int orderId)
        {
            using (var context = new PickingDbContext())
            {
                NewOrder newOrderData = new NewOrder();
                newOrderData.OrderId = orderId.ToString();
                newOrderData.Filename = orderId.ToString() + ".ordex";
                newOrderData.State = (NewOrderStatus) context.OrderStates.First(x => x.OrderId == orderId).OrderState;
                newOrderData.Issues = new List<NewIssue>();
                newOrderData.ItemData = new List<NewWhlSku>();
                
            }
            await Task.Delay(0);
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public static async Task<NewWhlSku> LoadItemFromDatabase(string sku)
        {
            await Task.Delay(0);
            return null;
        }
        
    }
}