using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using WebApiCore.Classes;
using WhiteHingeFramework.Classes;
using WhiteHingeFramework.Classes.EmployeeData;
using WhiteHingeFramework.Classes.Orders;
using WhiteHingeFramework.Classes.Picking;
using WhiteHingeFramework.Exceptions;
using WhiteHingeFrameworkExt;
using WhiteHingeFrameworkExt.PickingModels;
using WhiteHingeFrameworkExt.SqlLibrary;

namespace WebApiCore.Controllers.ApiControllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    public class PicklistController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public NewEmployeeCollection NewEmpColl = new NewEmployeeCollection(SqlServer.SelectDataDictionary("SELECT * from WhiteHinge.whldata.employees"));

        
        #region Functions
        private Picklist FindPicklistFromGuid(Guid picklistName)
        {
            var context = new PickingDbContext();
            var orders = context.PicklistOrders.Where(x => x.PicklistId == picklistName).ToList();
            if (orders.Count == 0) throw new PicklistNotFoundException();
            var orderIds = new HashSet<int>();
            foreach (var order in orders)
            {
                orderIds.Add(order.Orderid);
            }
            var newOrders = LoadOrderDataFromDatabase(orderIds);
            
            var returnable = PicklistExt.PicklistFromGuid(picklistName, newOrders);
            context.Dispose();
            return returnable;
        }


        private List<NewOrder> LoadOrderDataFromDatabase(HashSet<int> orderId)
        {
            return null;
        }

        private async void UpdateDatabaseForIssues(Guid picklistName, int orderId, string sku, int employeeId,int quantity, NewOrderStatus orderStatus)
        {
            var order = await DatabaseMapper.FindOrderFromId(orderId);
            
            RemoveOrderFromPicklist(picklistName, orderId);

            
            using (var context = new PickingDbContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    
                    var log = new IssueLog
                    {
                        sku = sku,
                        TimeReported = DateTime.Now,
                        orderStatus = (int)orderStatus,
                        userId = employeeId,
                        picklistId = picklistName
                    };
                    context.IssueLogs.Add(log);
                    var lists = context.PicklistOrders.Where(x => x.PicklistId == picklistName); //Code to remove order from picklist. Will be audited
                    context.PicklistOrders.RemoveRange(lists); //Removes the actual orders from the picklistdb


                    
                    context.SaveChanges();//Commits our changes back to the database
                    trans.Commit();
                }
            }
        }

        /// <summary>
        /// Updates the database to remove the order from the picklist, Preventing it from being reset when the list is finished
        /// </summary>
        /// <param name="picklistName"></param>
        /// <param name="order"></param>
        private void RemoveOrderFromPicklist(Guid picklistName, int order)
        {
            using (var context = new PickingDbContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    var picklistOrders = context.PicklistOrders.Where(x => x.PicklistId == picklistName && x.Orderid == order); //Finds relevant results from the PicklistOrders Table
                    var picklistItems = context.PicklistItems.Where(x => x.orderId == order && x.picklistId == picklistName); //Finds releveant results from the PicklistOrderItems table
                    context.PicklistOrders.RemoveRange(picklistOrders);
                    context.PicklistItems.RemoveRange(picklistItems);

                    context.SaveChanges();
                    trans.Commit(); //Commits our transaction
                }

            }
        }
        #endregion
    }
}