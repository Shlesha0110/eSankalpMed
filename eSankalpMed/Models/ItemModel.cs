using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class ItemModel
    {
       
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int CatId { get; set; }
        public decimal ItemQty { get; set; }
        public string Unit { get; set; }
        public string Details { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public string Barcode { get; set; }
        public string HSN { get; set; }
        public string MFGComapny { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string ExpiryDateString { get; set; }


        public Nullable<decimal> MRP { get; set; }
        public Nullable<decimal> Wprice { get; set; }
        public Nullable<decimal> WoutSalePrice { get; set; }
      
        public Nullable<System.DateTime> MFGDate { get; set; }
        
        public string SaveItem(ItemModel model)
        {
            string Message = "successfull";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            var saveItem = new tbl_Item()
            {

                ItemName = model.ItemName,
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                CatId = model.CatId,
                ItemQty = model.ItemQty,
                Unit = model.Unit,
                Details = model.Details,
                Vat = model.Vat,
                Barcode = model.Barcode,
                HSN = model.HSN,
                MFGComapny = model.MFGComapny,
                ExpiryDate = model.ExpiryDate,
                MRP = model.MRP,
                Wprice = model.Wprice,
                WoutSalePrice = model.WoutSalePrice,
                MFGDate = model.MFGDate


            };
            db.tbl_Item.Add(saveItem);
            db.SaveChanges();
            return Message;
        }

        public List<ItemModel> GetItemList(string ItemName)
        {
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            List<ItemModel> lstItem = new List<ItemModel>();
            var ItemList = db.tbl_Item.Where(p => p.ItemName.Contains(ItemName)).ToList();

            if (ItemList != null)
            {
                foreach (var Item in ItemList)
                {
                    
                    lstItem.Add(new ItemModel()
                    {
                        
                        ItemName = Item.ItemName,
                        PurchasePrice = Item.PurchasePrice,
                       
                    });
                }
            }
            return lstItem;
        }
    }
}
