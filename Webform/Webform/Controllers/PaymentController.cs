using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webform.Context;
using Webform.Models;

namespace Webform.Controllers
{
    public class PaymentController : Controller
    {
        db_projectEntities1 dbWeb = new db_projectEntities1();
      

        // GET: Payment
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            else
            {
                /*
                var list_Cart = (List<CartModel>)Session["cart"];
                cus objOrder = new Order();

                objOrder.Name = "Đơn Hàng -" + DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");
                objOrder.UserID = int.Parse(Session["idUser"].ToString());
                objOrder.CreatedOnUtc = DateTime.Now;
                objOrder.Status = 1;
             
                dbWeb.Orders.Add(objOrder);
                dbWeb.SaveChanges();

                int inOrderID = objOrder.ID;
                List<OrderDetail> list_OrderDetail = new List<OrderDetail>();
                foreach(var item in list_Cart)
                {
                    OrderDetail obj = new OrderDetail();
                    obj.Quantity = item.Quantity;
                    obj.OrderID = inOrderID;
                    obj.ProductID = item.Product.ID;
                    list_OrderDetail.Add(obj);
                }
                dbWeb.OrderDetails.AddRange(list_OrderDetail);
                dbWeb.SaveChanges();
                */
            }
            return View();
        }
    }
}