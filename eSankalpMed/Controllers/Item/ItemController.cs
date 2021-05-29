using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSankalpMed.Models;

namespace eSankalpMed.Controllers.Item
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult User_ItemDisplay()
        {
            return View();
        }
        public ActionResult SaveItem(ItemModel model)
        {
            try
            {
                return Json(new { message = (new ItemModel().SaveItem(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetItemList(string ItemName)
        {
            try
            {
                return Json(new { model = (new ItemModel().GetItemList(ItemName)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}